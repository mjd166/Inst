using Instant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Instant
{
    public partial class weatherform : Form
    {

        // int part = -1;
        int setp = 0;

        public weatherform()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }
        string[] a = new string[8];

        private async void weatherform_LoadAsync(object sender, EventArgs e)
        {


            lblstatus.Font = lblstatustitle.Font = label1.Font = lblDama.Font = new Font(lblDama.Font.FontFamily, (tableLayoutPanel1.Height / 5) + 4);


            XmlDocument Doc = new XmlDocument();

            var responseString = await publics.client.GetStringAsync("http://parsijoo.ir/api?serviceType=weather-API&q=tabriz");
            if (responseString != null)
            {
                Doc.LoadXml(responseString);
                var day = Doc.DocumentElement.GetElementsByTagName("day");
                int i = 0;
                string vaziatJavvi = "";
                string temp = "";
                string city = "";
                int j = 0;

                foreach (XmlElement d in day)
                {
                    var Day = d.GetElementsByTagName("day-name").Item(0).InnerText;
                    if (i <= 0)
                    {
                        vaziatJavvi = d.GetElementsByTagName("status").Item(0).InnerText;
                        a[j] = vaziatJavvi;

                        temp = d.GetElementsByTagName("temp").Item(0).InnerText;
                        j++; if (j >= 8) break;
                        if (j >= 8) break;
                        a[j] = temp;
                        j++;
                        if (j >= 8) break;
                        city = d.GetElementsByTagName("city-name").Item(0).InnerText;
                        a[j] = city;
                        j++; if (j >= 8) break;
                    }
                    var maxTemp = d.GetElementsByTagName("max-temp").Item(0).InnerText;
                    a[j] = maxTemp;
                    j++; if (j >= 8) break;
                    var MinTemp = d.GetElementsByTagName("min-temp").Item(0).InnerText;
                    a[j] = MinTemp;
                    j++; if (j >= 8) break;

                    if (j >= 8)
                    {
                        break;
                    }

                    if (i == 0)
                    {

                        lblstatus.Text = vaziatJavvi;
                        lblDama.Text = temp;

                    }
                    else if (i == 1)
                    {

                    }
                    else if (i == 2)
                    {

                    }


                    i++;


                }
                NextItem();

            }
            else
            {
                publics.WriteLogs("weatherform_load", "web request not respond . No internet connection maybe");
                this.Close();
                this.Dispose();

                return;
            }

        }



        private void NextItem()
        {
            // part++;
            //if (part == 0)
            //{


            if (setp == 0)
            {
                lblstatustitle.Text = "وضعیت";
                lblstatustitle.Font = new Font(lblstatustitle.Font.FontFamily, (tableLayoutPanel1.Height / 6));
                lblstatustitle.BackColor = Color.Yellow;

                lblstatus.Text = "جوی";
                lblstatustitle.BackColor = Color.Yellow;

                label1.Text = a[0];///وضیعت جوی 
                label1.BackColor = Color.Green;
                lblDama.Text = "";
                lblDama.BackColor = Color.Green;
            }
            else if (setp == 1)
            {
                lblstatustitle.Font = new Font(lblstatustitle.Font.FontFamily, (tableLayoutPanel1.Height / 5) + 4);
                lblstatustitle.Text = "دما";
                lblstatustitle.BackColor = Color.Blue;
                lblstatus.Text = "الان";
                lblstatus.BackColor = Color.Blue;
                label1.Text = a[1];
                lblDama.Text = "";
                label1.BackColor = Color.White;
                lblDama.BackColor = Color.White;




            }
            else if (setp == 2)
            {
                lblstatustitle.Font = new Font(lblstatustitle.Font.FontFamily, (tableLayoutPanel1.Height / 5) + 4);
                lblstatustitle.Text = "حداکثر";
                lblstatustitle.BackColor = Color.Brown;
                lblstatus.BackColor = Color.Brown;
                lblstatus.Text = "دما";
                label1.Text = a[3];

                lblDama.Text = "";

                label1.BackColor = Color.AliceBlue;
                lblDama.BackColor = Color.AliceBlue;



            }
            else if (setp == 3)
            {
                lblstatustitle.Font = new Font(lblstatustitle.Font.FontFamily, (tableLayoutPanel1.Height / 5) + 4);
                lblstatustitle.Text = "حداقل";
                lblstatus.Text = "دما";
                lblstatustitle.BackColor = Color.Pink;
                lblstatus.BackColor = Color.Pink;
                label1.Text = a[4];

                lblDama.Text = "";

                label1.BackColor = Color.DarkGreen;
                lblDama.BackColor = Color.DarkGreen;


            }
            setp++;

            if (setp > 4)
            {
                this.Close();
                this.Dispose();

            }
            //}
            //if (part == 1)
            //{
            //    lblstatustitle.Text = "حداکثر دما";
            //    lblstatus.Text = a[5];

            //    lblDama.Text = "حداقل دما";

            //}
        }

        private void lblstatustitle_Click(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            if(me.Button == MouseButtons.Right)
            {
                this.Close();
                this.Dispose();
                return;
            }
            NextItem();
        }




        public void SetFont(object sender, PaintEventArgs e)
        {
            TextBox btn;
            if (sender is TextBox)
            {
                btn = (TextBox)sender;
                float fontSize = NewFontSize(e.Graphics, btn.Size, btn.Font, btn.Text);

                // set font with Font Class and the returned Size from NewFontSize();
                Font f = new Font("B Nazanin", fontSize, FontStyle.Regular);
                btn.Font = f;
            }
        }

        public static float NewFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return font.Size * ratio;
        }

        private void lblstatustitle_Paint(object sender, PaintEventArgs e)
        {
            SetFont(sender, e);
        }
    }
}
