using System.Diagnostics;
using System.Net;
using System.Text;

namespace DevTest.HttpServer
{
    public class MyHttpServer
    {
        private HttpListener listerner = null;
        private List<UrlMap> maps = new List<UrlMap>();

        public void Start()
        {
            listerner = new HttpListener();
            listerner.AuthenticationSchemes = AuthenticationSchemes.Anonymous;
            listerner.Prefixes.Add("http://127.0.0.1:8080/");
            listerner.Start();
            listerner.BeginGetContext(EndGetRequest, listerner);
        }

        public void SetUrlMap(List<UrlMap> maps)
        {
            this.maps.Clear();
            this.maps.AddRange(maps);
        }

        void EndGetRequest(IAsyncResult result)
        {
            HttpListenerContext context = null;
            System.Net.HttpListener listener = (System.Net.HttpListener)result.AsyncState;
            if (listener.IsListening)
                listener.BeginGetContext(EndGetRequest, listener);
            try
            {
                context = listener.EndGetContext(result);
                TaskProc(context);
            }
            catch (Exception ex)
            {
                Console.Write("Exception in listener: {0}{1}", Environment.NewLine, ex);
            }
            finally
            {
                try
                {
                    if (context != null)
                        context.Response.Close();
                }
                catch (Exception) { }
            }
        }

        private void TaskProc(HttpListenerContext client)
        {
            if (client == null) return;
            var coding = Encoding.UTF8;
            var request = client.Request;

            var response = client.Response;
            response.StatusCode = 200;
            response.ContentEncoding = coding;

            try
            {
                string url = null;
                foreach (var map in maps)
                {
                    if (map.Host.Equals(request.Url.Host, StringComparison.OrdinalIgnoreCase))
                    {
                        if (url == null)
                        {
                            url = "Http://" + map.OldIp + request.Url.PathAndQuery;
                        }
                        if (map.Used && request.Url.PathAndQuery.StartsWith(map.Url, StringComparison.OrdinalIgnoreCase))
                        {
                            url = "Http://" + map.NewIp + request.Url.PathAndQuery;
                            if (request.HttpMethod.Equals("GET", StringComparison.OrdinalIgnoreCase))
                            {
                                GetTaskProc(url, request, response);
                            }
                            else if (request.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase))
                            {
                                PostTaskProc(url, request, response);
                            }
                            return;
                        }
                    }
                }
                if (url != null)
                {
                    if (request.HttpMethod.Equals("GET", StringComparison.OrdinalIgnoreCase))
                    {
                        GetTaskProc(url, request, response);
                    }
                    else if (request.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase))
                    {
                        PostTaskProc(url, request, response);
                    }
                    return;
                }
                response.StatusCode = 404;
            }
            catch (Exception)
            {
                response.StatusCode = 500;
            }
        }

        private void GetTaskProc(string url, HttpListenerRequest request, HttpListenerResponse response)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Clear();
            try
            {
                foreach (var item in request.Headers.AllKeys)
                {
                    if (item.Equals("Connection", StringComparison.OrdinalIgnoreCase))
                    {
                    }
                    else
                    {
                        Debug.WriteLine($"{item}:{request.Headers[item]}");
                        webClient.Headers.Add(item, request.Headers[item]);
                    }
                }
                byte[] body = webClient.DownloadData(url);

                foreach (var item in webClient.ResponseHeaders.AllKeys)
                {
                    response.Headers.Add(item, webClient.ResponseHeaders[item]);
                }
                BinaryWriter binaryWriter = new BinaryWriter(response.OutputStream);
                binaryWriter.Write(body);
                binaryWriter.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                webClient.Dispose();
            }
        }

        private void PostTaskProc(string url, HttpListenerRequest request, HttpListenerResponse response)
        {
            WebClient webClient = new WebClientEx();
            webClient.Headers.Clear();

            foreach (var item in request.Headers.AllKeys)
            {
                if (item.Equals("Connection", StringComparison.OrdinalIgnoreCase))
                {
                }
                else
                {
                    webClient.Headers.Add(item, request.Headers[item]);
                }
            }

            byte[] postBody;
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryReader binaryReader = new BinaryReader(request.InputStream);
                byte[] bytes = binaryReader.ReadBytes(1024);
                while (bytes.Length > 0)
                {
                    ms.Write(bytes);
                    bytes = binaryReader.ReadBytes(1024);
                }
                postBody = ms.ToArray();
            }

            byte[] body = webClient.UploadData(url, postBody);
            foreach (var item in webClient.ResponseHeaders.AllKeys)
            {
                response.Headers.Add(item, webClient.ResponseHeaders[item]);
            }
            BinaryWriter binaryWriter = new BinaryWriter(response.OutputStream);
            binaryWriter.Write(body);
            binaryWriter.Close();
        }



    }

}
