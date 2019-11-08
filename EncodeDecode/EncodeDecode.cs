using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodeDecode
{
    public partial class EncodeDecode : Form
    {
        public EncodeDecode()
        {
            InitializeComponent();
            InitializeCBAlgorithms();
        }

        protected void InitializeCBAlgorithms()
        {
            this.cbAlgorithms.Items.Add("b16 - Hex");
            this.cbAlgorithms.Items.Add("Adler-32");
            this.cbAlgorithms.Items.Add("CRC-32");
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            this.txbDecode.Text = ToHexString(this.txbEncode.Text);

            if (this.cbAlgorithms.SelectedItem.Equals("Adler-32"))
            {
                this.txbDecode.Text = Adler32(this.txbEncode.Text);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            this.txbEncode.Text = FromHexString(this.txbDecode.Text);
        }

        public static string ToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString(); 
        }

        public static string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes);
        }

        private static string Adler32(string str)
        {
            const int mod = 65521;
            uint a = 1, b = 0;
            foreach (char c in str)
            {
                a = (a + c) % mod;
                b = (b + a) % mod;
            }
            return ((b << 16) | a).ToString("X");
        }
    }
}
