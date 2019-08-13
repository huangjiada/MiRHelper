using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiRHelper
{
    class APIHelper
    {
        private string apiUrl = string.Empty;
        public static string methodUrl = string.Empty;
        public static string postStr = null;
        public APIHelper(string ip)
        {
            apiUrl = $"http://{ip}:8080/v2.0.0";
        }
        public string ExecudeGet(string parameterurl)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{apiUrl}/{parameterurl}");
            httpWebRequest.Method = "GET";
            HttpWebResponse httpWebResponse = null;
            try
            {
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
                return streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("409"))
                {
                    return "{\"error_human\":\"The resource already exists.\",\"error_code\":\"409\"}";
                }
                if (ex.Message.Contains("404"))
                {
                    return "{\"error_human\":\"Not Found.\",\"error_code\":\"404\"}";
                }
                return "{\"error_human\":\"Error.\",\"error_code\":\"400\"}";
            }
        }
        public string ExecutePut(string parameterurl, string jsonValue)
        {
            try
            {
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                string text = "";
                string s = jsonValue.ToString();
                byte[] bytes = aSCIIEncoding.GetBytes(s);
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{apiUrl}/{parameterurl}");
                httpWebRequest.KeepAlive = false;
                httpWebRequest.Method = "PUT";
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.ContentLength = bytes.Length;
                Stream requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                char[] array = new char[256];
                for (int num = streamReader.Read(array, 0, 256); num > 0; num = streamReader.Read(array, 0, 256))
                {
                    string str = new string(array, 0, num);
                    text += str;
                }
                httpWebResponse.Close();
                string text2 = text;
                return text;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("409"))
                {
                    return "{\"error_human\":\"The resource already exists.\",\"error_code\":\"409\"}";
                }
                if (ex.Message.Contains("404"))
                {
                    return "{\"error_human\":\"Not Found.\",\"error_code\":\"404\"}";
                }
                return "{\"error_human\":\"Error.\",\"error_code\":\"400\"}";
            }
        }

        public string ExecutePost(string parameterurl, string jsonValue)
        {
            try
            {
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                string text = "";
                string s = jsonValue.ToString();
                byte[] bytes = aSCIIEncoding.GetBytes(s);
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{apiUrl}/{parameterurl}");
                httpWebRequest.KeepAlive = false;
                httpWebRequest.Method = "Post";
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.ContentLength = bytes.Length;
                Stream requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                char[] array = new char[256];
                for (int num = streamReader.Read(array, 0, 256); num > 0; num = streamReader.Read(array, 0, 256))
                {
                    string str = new string(array, 0, num);
                    text += str;
                }
                httpWebResponse.Close();
                string text2 = text;
                return text;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("409"))
                {
                    return "{\"error_human\":\"The resource already exists.\",\"error_code\":\"409\"}";
                }
                if (ex.Message.Contains("404"))
                {
                    return "{\"error_human\":\"Not Found.\",\"error_code\":\"404\"}";
                }
                return "{\"error_human\":\"Error.\",\"error_code\":\"400\"}";
            }
        }

        public string ExecuteDelete(string parameterurl)
        {
            try
            {
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                string text = "";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{apiUrl}/{parameterurl}");
                httpWebRequest.KeepAlive = false;
                httpWebRequest.Method = "Delete";
                httpWebRequest.ContentType = "application/json";
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                char[] array = new char[256];
                for (int num = streamReader.Read(array, 0, 256); num > 0; num = streamReader.Read(array, 0, 256))
                {
                    string str = new string(array, 0, num);
                    text += str;
                }
                httpWebResponse.Close();
                string text2 = text;
                return text;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
