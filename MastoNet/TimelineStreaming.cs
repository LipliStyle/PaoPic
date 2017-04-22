using Mastonet.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mastonet
{
    public class TimelineStreaming
    {
        private string url;
        private string accessToken;
        private HttpClient client;
        private Stream stream;
        private StreamReader reader;
        private bool flgStop = false;


        public event EventHandler<StreamUpdateEventArgs> OnUpdate;
        public event EventHandler<StreamNotificationEventArgs> OnNotification;
        public event EventHandler<StreamDeleteEventArgs> OnDelete;

        internal TimelineStreaming(string url, string accessToken)
        {
            this.url = url;
            this.accessToken = accessToken;
        }


        public async void Start()
        {
            await GetStream();

            string eventName = null;
            string data = null;
            int count = 0;

            //停止フラグ初期化
            flgStop = false;    

            while (client != null)
            {
                if(flgStop)
                {
                    break;
                }

                try
                {
                    var line = reader.ReadLine();


                    if (string.IsNullOrEmpty(line) || line.StartsWith(":"))
                    {
                        eventName = data = null;
                        continue;
                    }

                    if (line.StartsWith("event: "))
                    {
                        eventName = line.Substring("event: ".Length).Trim();
                    }
                    else if (line.StartsWith("data: "))
                    {
                        data = line.Substring("data: ".Length);

                        switch (eventName)
                        {
                            case "update":
                                var status = JsonConvert.DeserializeObject<Status>(data);
                                OnUpdate?.Invoke(this, new StreamUpdateEventArgs() { Status = status });
                                break;
                            case "notification":
                                var notification = JsonConvert.DeserializeObject<Notification>(data);
                                OnNotification?.Invoke(this, new StreamNotificationEventArgs() { Notification = notification });
                                break;
                            case "delete":
                                var statusId = int.Parse(data);
                                OnDelete?.Invoke(this, new StreamDeleteEventArgs() { StatusId = statusId });
                                break;
                        }
                    }

                    count++;
                }
                catch(Exception ex)
                {
                    //エラーなら抜ける
                    Console.WriteLine(ex);

                    return;
                }

            }
        }

        private async Task<bool> GetStream()
        {
            if(client != null)
            {
                Restart();
            }


            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

            stream = await client.GetStreamAsync(url);

            reader = new StreamReader(stream);

            return true;
        }


        public void Restart()
        {
            client.Dispose();
            client = null;
        }


        public void Stop()
        {
            flgStop = true;
            int cnt = 0;

            while(cnt < 10)
            {
                Thread.Sleep(100);
                cnt++;
            }

            client.Dispose();
            client = null;
        }
    }
}
