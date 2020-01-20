using PersianTools.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instant
{
    public partial class DateTimeForm : Form
    {
        public DateTimeForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

        }

        int wordstep = 0;
        int yearindex = -1;
        string year = "";

        List<string> words = new List<string>();
        private void DateTimeForm_Load(object sender, EventArgs e)
        {

            // var dt1 = new PersianDateTime(1399, 10, 13);


            var d1 = PersianDateTime.Now.ToLongStringYMD();// جمعه بیست و هفت مهر سال یکهزار و سیصد و نود و هفت

            var w = d1.Split(' ');
            foreach (string s in w)
            {
                if (s != "")
                {
                    words.Add(s);
                }
            }




            lblDateFull.Font = new Font(lblDateFull.Font.FontFamily, (tableLayoutPanel1.Height / 5) + 0);
            lblDayofWeek.Font = new Font(lblDayofWeek.Font.FontFamily, (tableLayoutPanel1.Height / 6) + 20);
            lbl4.Font = lbl3.Font = new Font(lbl3.Font.FontFamily, (tableLayoutPanel1.Height / 5) + 0);
            int j = 0;
            foreach (string s in words)
            {
                if (s == "سال")
                {
                    break;
                }
                j++;
            }
            yearindex = j;
            var year1 = PersianDateTime.Now.Year;
            year = year1.ToString();

            lblDayofWeek.Text = words[wordstep];
            wordstep++;
            lblDateFull.Text = words[wordstep];
            wordstep++;

            lbl3.Text = words[wordstep];

            wordstep++;
            if (j > wordstep)
            {
                lbl4.Text = words[wordstep];
                wordstep++;
            }
            else
            {
                lbl4.Text = words[wordstep];
                wordstep++;

            }





            lblDayofWeek.BackColor = Color.Yellow;
            lblDateFull.BackColor = Color.Yellow;

            lbl3.BackColor = Color.Green
                ;
            lbl4.BackColor = Color.Green;




        }

        private void lblDayofWeek_Click(object sender, EventArgs e)
        {
            //DateTimeForm2 f2 = new DateTimeForm2();
            //f2.ShowDialog();
            //this.Close();
            //this.Dispose();
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                this.Close();
                this.Dispose();
            }
            NextItem();

        }


        int part = 0;
        int step = 0;
        bool flag = false;
        private void NextItem()
        {


            string[] monasebat = PersianDateTime.GetDateData(DateTime.Now).Split(' ');



            if ((yearindex < 4) && !flag)
            {
                lblDayofWeek.Text = year;
                flag = true;
                lblDateFull.Text = "";
                lbl3.Text = "";
                lbl4.Text = "";
                return;
            }
            if (wordstep > yearindex)
            {
                if (step >= monasebat.Length)
                {
                    part = 1000000;

                    if (part == 1)
                    {
                        var nowdate = PersianDateTime.Now;
                        if (nowdate.IsHoliDay)
                        {
                            lblDayofWeek.Text = "امروز";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "است";

                        }
                        else
                        {
                            lblDayofWeek.Text = "امروز";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "نیست";
                        }
                    }
                    else if (part == 2)
                    {
                        var nowdat = PersianDateTime.Now.AddDays(1);
                        if (nowdat.IsHoliDay)
                        {
                            lblDayofWeek.Text = "فردا";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "است";

                        }
                        else
                        {
                            lblDayofWeek.Text = "فردا";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "نیست";
                        }

                    }
                    else if (part == 3)
                    {



                    }
                    else
                    {
                        this.Close();
                        this.Dispose();

                    }
                }
                else
                {
                    if (part >= 3)
                    {
                        part = 3;

                    }
                    else
                        part++;
                    if (part == 1)
                    {
                        var nowdate = PersianDateTime.Now;
                        if (nowdate.IsHoliDay)
                        {
                            lblDayofWeek.Text = "امروز";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "است";

                        }
                        else
                        {
                            lblDayofWeek.Text = "امروز";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "نیست";
                        }
                    }
                    else if (part == 2)
                    {
                        var nowdat = PersianDateTime.Now.AddDays(1);
                        if (nowdat.IsHoliDay)
                        {
                            lblDayofWeek.Text = "فردا";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "است";

                        }
                        else
                        {
                            lblDayofWeek.Text = "فردا";
                            lblDateFull.Text = "تعطیل";
                            lbl3.Text = "نیست";
                        }
                    }
                    else if (part == 3)
                    {
                        part = 3;
                        if (monasebat[step] != "")
                            lblDayofWeek.Text = monasebat[step];
                        else
                        {
                            step++;
                            if (step >= monasebat.Length)
                            {
                                this.Close();
                                this.Dispose();
                                return;
                            }
                            else
                            {
                                lblDayofWeek.Text = monasebat[step];
                            }

                        }

                        step++; if (step >= monasebat.Length)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                            this.Dispose();
                            return;
                        }

                        if (monasebat[step] != "")
                        {
                            lblDateFull.Text = monasebat[step];
                        }
                        else
                        {
                            step++; lblDateFull.Text = monasebat[step];

                        }

                        step++; if (step >= monasebat.Length)
                        {
                            this.Close();
                            this.Dispose();
                        }


                        if (monasebat[step] != "")
                        {
                            lbl3.Text = monasebat[step];
                        }
                        else
                        {
                            step++;
                            lbl3.Text = monasebat[step];

                        }

                        step++;
                        if (step >= monasebat.Length)
                        {
                            this.Close();
                            this.Dispose();
                            return;
                        }
                        if (monasebat[step] != "")
                        {
                            lbl4.Text = monasebat[step];
                        }
                        else
                        {
                            step++;
                            lbl4.Text = monasebat[step];
                        }

                        step++;
                        if (step >= monasebat.Length)
                        {
                            this.Close();
                            this.Dispose();
                        }



                    }
                }
            }
            else
            {
                
                if (wordstep >= yearindex)
                {
                    lblDayofWeek.Text = "سال";
                    lblDateFull.Text = year;
                    lbl3.Text = lbl4.Text = "";

                }
                else
                {
                    lblDayofWeek.Text = words[wordstep];
                }


                wordstep++;
                if (wordstep < yearindex)
                {
                    lblDateFull.Text = words[wordstep];
                    wordstep++;
                    if (wordstep < yearindex)
                    {
                        lbl3.Text = words[wordstep];
                    }
                    else
                    {
                        lbl3.Text = "سال";
                    }
                    wordstep++;
                    if (wordstep < yearindex)
                    {
                        lbl4.Text = words[wordstep];
                    }
                    else
                    {
                        lbl4.Text = year;
                    }

                }
                else
                {

                    lblDateFull.Text = year;
                    lbl3.Text = "";
                    lbl4.Text = "";


                    //lblDateFull.Text = "";
                    //lblDayofWeek.Text = "";
                    //lbl3.Text = lbl4.Text = "";
                }


                //  NextItem();
            }





        }






        public void SetFont(object sender, PaintEventArgs e)
        {
            Label btn;
            if (sender is Label)
            {
                btn = (Label)sender;
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

        private void lblDayofWeek_Paint(object sender, PaintEventArgs e)
        {
            //SetFont(sender, e);
        }
    }
}
