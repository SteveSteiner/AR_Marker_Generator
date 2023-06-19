using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace AR_Marker_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateColorPicker();
            chx_IconEnabled.Checked = false;
            txt_Icon.Enabled = false;
        }

        private void btn_CreateCodeMarker_Click(object sender, EventArgs e)
        {
            pbx_CodeDisplay.Image = CreateQRCode("Marker", 352);
        }

        private void btn_SaveCodeToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JPG for Marker (*.jpg)|*.jpg|All files (*.*)|*.*";
            dialog.FileName = txt_CodeContent.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbx_CodeDisplay.Image.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private Bitmap CreateQRCode(string type, int length)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(type + txt_CodeContent.Text + ";" + CreateRandomString(length), QRCodeGenerator.ECCLevel.H, false);
            QRCode code = new QRCode(qrData);

            if (chx_IconEnabled.Checked)
            {
                Bitmap iconImage = new Bitmap(100, 50);
                Graphics graphic = Graphics.FromImage(iconImage);

                graphic.SmoothingMode = SmoothingMode.AntiAlias;
                graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphic.DrawString(txt_Icon.Text, new Font("Arial", 14), Brushes.Black, new Rectangle(1, 1, 99, 25));
                graphic.Flush();

                return code.GetGraphic(4, Color.FromName(cbx_Colors.SelectedItem.ToString()), Color.White, iconImage, 25, 6, true);
            }
            else
            {
                return code.GetGraphic(4, Color.FromName(cbx_Colors.SelectedItem.ToString()), Color.White, false);
            }
        }

        private string CreateRandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        private void PopulateColorPicker()
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (PropertyInfo c in propInfoList)
            {
                this.cbx_Colors.Items.Add(c.Name);
            }
            cbx_Colors.SelectedIndex = 8;
        }

        private void chx_IconEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_IconEnabled.Checked)
            {
                txt_Icon.Enabled = true;
            }
            else
            {
                txt_Icon.Enabled = false;
            }
        }
    }
}
