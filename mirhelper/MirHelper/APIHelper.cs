using System;
using System.IO;
using System.Net;
using System.Text;
using System.Security.Cryptography;

namespace MirHelper
{
    public class APIHelper
    {
        private string apiUrl = string.Empty;

        public static string methodUrl = string.Empty;

        public static string postStr = null;

        private string svcCredentials;//使用该apihelper时应输入授权的账号密码，由类本身来初始化，字符串传来传去太麻烦了

        /// <summary>
        /// 输入小车所在IP，以及有权限操作api接口的账号密码，
        /// </summary>
        /// <param name="ip">小车所在ip</param>
        /// <param name="userid">账号</param>
        /// <param name="password">密码</param>
        public APIHelper(string ip, string userid, string password)
        {
            apiUrl = $"http://{ip}/api/v2.0.0";
            svcCredentials = string.Format("Basic {0}", Encode(userid, password)); 
        }

        #region 小车编码
        private static string GerSHA256HashFromString(string strData)
        {
            byte[] bytValue = System.Text.Encoding.UTF8.GetBytes(strData);
            try
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                byte[] retVal = sha256.ComputeHash(bytValue);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetSHA256HashFormString() fail, error:" + ex.Message);
            }
        }
        private static string ToBase64String(string value)
        {
            if (value == null || value == "")
            {
                return "";
            }
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }
        private static string Encode(string name, string passwd)
        {
            string convert = name + ":" + GerSHA256HashFromString(passwd);
            return ToBase64String(convert);
        } 
        #endregion
        public string ExecuteGet(string parameterurl)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{apiUrl}/{parameterurl}");
            httpWebRequest.Method = "GET";
            httpWebRequest.Timeout = 5000;
            httpWebRequest.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", this.svcCredentials);
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
                httpWebRequest.Timeout = 5000;
                httpWebRequest.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", this.svcCredentials);
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
                httpWebRequest.Timeout = 5000;
                httpWebRequest.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", this.svcCredentials);
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
                httpWebRequest.Timeout = 5000;
                httpWebRequest.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", this.svcCredentials);
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
