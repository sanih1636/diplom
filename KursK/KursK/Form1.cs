using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KursK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string MD5(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            return result;
        }
        private static string SHA256(string pass)
        {
            byte[] data = new UTF8Encoding().GetBytes(pass);
            byte[] resul;
            SHA256 shaM = new SHA256Managed();
            resul = shaM.ComputeHash(data);
            return BitConverter.ToString(resul);
        }
        private static string SHA384(string pass)
        {
            byte[] data = new UTF8Encoding().GetBytes(pass);
            byte[] resul;
            SHA384 shaM = new SHA384Managed();
            resul = shaM.ComputeHash(data);
            return BitConverter.ToString(resul);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a="";
            if (radioButton1.Checked == true) a = MD5(textBox1.Text);
            if (radioButton2.Checked == true) a = SHA256(textBox1.Text);
            if (radioButton3.Checked == true) a = SHA384(textBox1.Text);
            textBox2.Text = a;
        }
    }
}
