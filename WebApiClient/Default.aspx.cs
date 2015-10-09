using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApiClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tbtime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                tbmd5.Text = CreateSignature(tbk.Text.ToString(), tbflag.Text.ToString(), tbfield.Text.ToString(), Convert.ToDateTime(tbtime.Text.ToString()));
            }
        }

        protected void btntime_Click(object sender, EventArgs e)
        {
            tbtime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        protected void btnmd5_Click(object sender, EventArgs e)
        {
            tbmd5.Text = CreateSignature(tbk.Text.ToString(), tbflag.Text.ToString(), tbfield.Text.ToString(), Convert.ToDateTime(tbtime.Text.ToString()));
        }
        protected void btnurl_Click(object sender, EventArgs e)
        {
            string url = tburl.Text.ToString();
            HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse webreponse = (HttpWebResponse)webrequest.GetResponse();
            Stream stream = webreponse.GetResponseStream();
            byte[] rsByte = new Byte[webreponse.ContentLength];  //save data in the stream
            string str = "[]";
            try
            {
                stream.Read(rsByte, 0, (int)webreponse.ContentLength);
                str = System.Text.Encoding.UTF8.GetString(rsByte, 0, rsByte.Length).ToString();
            }
            catch (Exception exp)
            {
                str = exp.ToString();
            }
            Label1.Text = str;
        }

        protected void btnmake_Click(object sender, EventArgs e)
        {
            string urlp = string.Format("http://eswebapi.test.sci99.com/api/member/getme/?flag={0}&field={1}&keyword={2}&tracktype=5&start=0&size=15&timestamp={3}&sign={4}", tbflag.Text.ToString(), tbfield.Text.ToString(), tbk.Text.ToString(), tbtime.Text.ToString(), tbmd5.Text.ToString()); ;
            tburl.Text = urlp;
        }

        private string CreateSignature(string keyword, string flag, string field, DateTime timestamp)
        {
            string sign = "";
            try
            {
                TimeSpan toNow = DateTime.Now.Subtract(timestamp);
                string nowTS = toNow.TotalSeconds.ToString();
                int ts = 0;
                if (toNow.TotalSeconds != 0)
                {
                    ts = int.Parse(nowTS.Substring(0, nowTS.IndexOf('.')));
                }
                if (Math.Abs(ts) < 120)
                {
                    sign = ("keyword=" + keyword + "&flag=" + flag + "&field=" + field + "&timestamp=" + timestamp.ToString("yyyy-MM-dd HH:mm:ss")).ToUpper();
                    sign = GetMD5HashFromStr(sign);
                }
            }
            catch (Exception)
            {
                sign = "";
            }
            return sign;
        }

        private static string GetMD5HashFromStr(string str)
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                {
                    MD5 md5Hash = MD5.Create();
                    byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
                    StringBuilder sBuilder = new StringBuilder();
                    for (int i = 0; i < data.Length; i++)
                    {
                        sBuilder.Append(data[i].ToString("x2"));
                    }
                    return sBuilder.ToString().ToUpper();
                }
                else
                {
                    return str;
                }
            }
            catch (Exception)
            {
                return str;
            }
        }


    }
}