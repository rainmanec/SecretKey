using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace SecretKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitMacs();
        }

        #region  辅助函数
        public string EncodeHash(string str)
        {
            string SECRET_KEY = this.tb_hash.Text.Trim();
            str = SECRET_KEY + str + SECRET_KEY;
            return this.GetMd5(this.GetMd5(str));
        }
        /// <summary>
        /// Array拼接成字符串
        /// </summary>
        /// <param name="sp"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public string ArrayJoin(string sp, string[] arr)
        {
            string result = "";
            for (int i = 0, length = arr.Length; i < length; i++)
            {
                result += arr[i];
                if (i != length - 1)
                {
                    result += sp;
                }
            }
            return result;
        }

        /// <summary>
        /// List转换为Array
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public string[] ListToArray(List<string> list)
        {
            string[] result = new string[list.Count];
            for (int i = 0, length = list.Count; i < length; i++)
            {
                result[i] = list[i];
            }
            return result;
        }

        /// <summary>
        /// Md5加密字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetMd5(string str)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedDataBytes;
            hashedDataBytes = md5Hasher.ComputeHash(Encoding.GetEncoding("gb2312").GetBytes(str));
            StringBuilder tmp = new StringBuilder();
            foreach (byte i in hashedDataBytes)
            {
                tmp.Append(i.ToString("x2"));
            }
            str = tmp.ToString().ToUpper();
            return str;
        }

        /// <summary>
        /// 获取网卡地址
        /// </summary>
        /// <returns></returns>
        public string[] GetMacAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            List<string> list = new List<string>();
            foreach (ManagementObject mo in moc)
            {
                if (mo["MacAddress"] != null)
                {
                    list.Add(mo["MacAddress"].ToString().Replace('-', ':').ToUpper());
                }
            }
            return this.ListToArray(list);
        }

        public void InitMacs()
        {
            string[] macs = this.GetMacAddress();
            tb_mac.Text = this.ArrayJoin("\r\n", macs);
        }

        #endregion

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string[] macs = this.tb_mac.Text.Trim().Split(new string[] { "\r\n" }, StringSplitOptions.None);
            List<string> list = new List<string>();
            foreach (string m in macs)
            {
                if (m.Trim() != "")
                {
                    list.Add(this.EncodeHash(m.Trim()));
                }
                else
                {
                    list.Add(m);
                }
            }
            this.tb_xlh.Text = this.ArrayJoin("\r\n", this.ListToArray(list));
        }

        private void btn_mac_Click(object sender, EventArgs e)
        {
            this.InitMacs();
        }


    }
}
