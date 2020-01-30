using Instant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instant
{
    public partial class Form1 : Form
    {
        public List<string> lstJpg = new List<string>();
        public List<string> lstVoice = new List<string>();
        public List<string> lsttxt = new List<string>();
        public List<string> lstVide = new List<string>();
        public List<string> lstOgg = new List<string>();

        private bool imgFlag = false;
        private bool videoFlag = false;
        private bool soundFlag = false;
        private bool txtFlag = false;


        public Form1()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            publics.Setinfo();

            GetBtnsText();
            this.Location = new Point(0, 0);

            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.WindowState = FormWindowState.Maximized;
            //dispatcherEMGMSG = new System.Threading.Timer(_ => dispatcherEMGMSG_Tick(), null, 60 * 1000, Timeout.Infinite);
        }

        private void GetBtnsText()
        {
            try
            {
                string[] words = null;
                var file = File.ReadAllText(publics._RootPath + "\\Settings.txt");
                file = file.Replace('\r', ' ');
                if (file != null)
                {
                    words = file.Split('\n');
                }
                btn1.Text = words[0];
                btn2.Text = words[1];
                btn3.Text = words[2];
                btn4.Text = words[3];
                btn5.Text = words[4];
                btn6.Text = words[5];
                btn7.Text = words[6];
                btn8.Text = words[7];
                btn9.Text = words[8];
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private void dispatcherEMGMSG_Tick()
        //{
        //    try
        //    {
        //        var files = Directory.GetFiles(publics._Folderspecialpath);

        //        foreach (string s in files)
        //        {
        //            FileInfo f = new FileInfo(s);

        //            string filetyp = f.Extension;

        //            CheckFiletypAndAddtoList(publics._Folderspecialpath + "\\", filetyp);
        //            break;
        //        }

        //        if (imgFlag)
        //        {
        //            PlayImg();
        //            imgFlag = false;
        //            publics.EMGFlag = true;

        //        }
        //        else if (txtFlag)
        //        {
        //            playText();
        //            txtFlag = false; publics.EMGFlag = true;
        //        }
        //        else if (videoFlag)
        //        {
        //            playVideo(1);

        //            videoFlag = false; publics.EMGFlag = true;
        //        }
        //        else if (soundFlag)
        //        {
        //            PlayVoice(lstOgg, 1);
        //            soundFlag = false; publics.EMGFlag = true;
        //        }



        //        dispatcherEMGMSG.Change(60 * 1000, Timeout.Infinite);

        //    }
        //    catch (Exception)
        //    {

        //        //throw;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //btn1.Font = new Font(btn1.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn2.Font = new Font(btn2.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn3.Font = new Font(btn3.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn4.Font = new Font(btn4.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn5.Font = new Font(btn5.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn6.Font = new Font(btn6.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn7.Font = new Font(btn7.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn8.Font = new Font(btn8.Font.FontFamily, tableLayoutPanel1.Font.Height + 55, FontStyle.Regular);
            //btn9.Font = new Font(btn9.Font.FontFamily, tableLayoutPanel1.Font.Height + 30, FontStyle.Regular);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            BtnClick(sender);
        }
        private void BtnClick(object sender)
        {
            Button Btn = new Button();
            if (sender is Button)
            {
                Btn = (Button)sender;
                string folerp = "";

                if (Btn.Name.ToString() == "btn1")
                {
                    folerp = publics._Folder1path;
                }
                else if (Btn.Name.ToString() == "btn2")
                {
                    folerp = publics._Folder2path;
                }
                else if (Btn.Name.ToString() == "btn3")
                {
                    folerp = publics._Folder3path;
                }
                else if (Btn.Name.ToString() == "btn4")
                {
                    folerp = publics._Folder4path;
                }
                else if (Btn.Name.ToString() == "btn5")
                {
                    folerp = publics._Folder5path;
                }
                else if (Btn.Name.ToString() == "btn6")
                {
                    folerp = publics._Folder6path;
                }
                else if (Btn.Name.ToString() == "btn7")
                {
                    folerp = publics._Folder7path;
                }
                else if (Btn.Name.ToString() == "btn8")
                {
                    // folerp = publics._Folder8path;

                    DateTimeForm DateForm = new DateTimeForm();
                    DateForm.ShowDialog();

                }
                else if (Btn.Name.ToString() == "btn9")
                {
                    //folerp = publics._Folder9path;
                    weatherform frm = new weatherform();
                    frm.ShowDialog();
                }
                if (Directory.Exists(folerp))
                {
                    var Files = Directory.GetFiles(folerp);
                    if (Files != null)
                    {
                        foreach (string s in Files)
                        {
                            FileInfo f = new FileInfo(s);

                            string filetyp = f.Extension;

                            CheckFiletypAndAddtoList(folerp + "\\", filetyp);
                            break;
                        }
                        //////////////////////////////////////////////////////////////////////////////////

                        if (imgFlag)
                        {

                            PlayImg(0);
                            lstJpg.Clear();
                            imgFlag = false;
                        }
                        else if (txtFlag)
                        {
                            playText(0);
                            txtFlag = false;

                        }
                        else if (videoFlag)
                        {
                            playVideo(0);
                            videoFlag = false;
                        }
                        else if (soundFlag)
                        {
                            PlayVoice(lstOgg, 0);
                            soundFlag = false;
                        }
                    }
                }
                else
                {

                    imgFlag = false;
                    txtFlag = false;
                    videoFlag = false;
                    soundFlag = false;
                    //MessageBox.Show("فولدر مورد نظر پیدا نشد ");
                    publics.WriteLogs(Btn.Name.ToString() + "_Click", "فایل مورد نظر پیدا نشد");
                    return;
                }
            }
        }

        private void playText(int flag)
        {
            try
            {
                if (flag == 1)
                {
                    var number = Application.OpenForms;
                    if (!publics.EMGFlag)
                    {
                        foreach (Form f in number)
                        {
                            try
                            {
                                if (f.Name != "Form1")
                                {
                                    Task.Factory.StartNew(() =>
                                    {
                                        this.BeginInvoke(new Action(() =>
                                        {
                                            f.Close();
                                            f.Dispose();
                                        }));
                                    });
                                }
                            }
                            catch (Exception ex)
                            {
                                publics.WriteLogs("ex on close open form", ex.ToString());
                                return;
                            }
                        }
                    }
                    publics.dispatcherflag = true;
                    TextViewer viewer = new TextViewer(lsttxt);
                    viewer.ShowDialog();
                }
                else
                {
                    TextViewer viewer = new TextViewer(lsttxt);
                    viewer.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                publics.WriteLogs("ex on play text", ex.ToString());
            }
        }

        private void PlayVoice(List<string> lstOgg, int flag)
        {
            try
            {

                if (flag == 1)
                {
                    var number = Application.OpenForms;

                    if (!publics.EMGFlag)
                        foreach (Form f in number)
                        {
                            try
                            {
                                if (f.Name != "Form1")
                                {
                                    Task.Factory.StartNew(() =>
                                    {
                                        this.BeginInvoke(new Action(() =>
                                        {
                                            f.Close();
                                            f.Dispose();
                                        }));
                                    });
                                }
                            }
                            catch (Exception ex)
                            {
                                publics.WriteLogs("ex on close open form", ex.ToString());
                                return;
                            }
                        }

                    publics.dispatcherflag = true;
                    if (!publics.playflag)
                    {
                        publics.playflag = true;
                        Task.WaitAll(Task.Factory.StartNew(() =>
                        {

                            this.BeginInvoke(new Action(() =>
                            {
                                VoicePly play1 = new VoicePly(lstOgg);
                                play1.ShowDialog();

                            }));
                        }));
                    }


                }
                else
                {
                    try
                    {
                        VoicePly play = new VoicePly(lstOgg);
                        play.ShowDialog();
                    }
                    catch (Exception)
                    {

                      // Task.Factory.StartNew(=>)
                    }


                }



            }
            catch (Exception ex)
            {

                publics.WriteLogs("ex play voice", ex.ToString());
            }
        }

        private void playVideo(int flag)
        {
            try
            {
                if (flag == 1)
                {

                    var number = Application.OpenForms;
                    if (!publics.EMGFlag)
                        foreach (Form f in number)
                        {
                            try
                            {
                                if (f.Name != "Form1")
                                {
                                    Task.Factory.StartNew(() =>
                                    {
                                        this.BeginInvoke(new Action(() =>
                                        {
                                            f.Close();
                                            f.Dispose();
                                        }));
                                    });
                                }
                            }
                            catch (Exception ex)
                            {
                                publics.WriteLogs("ex on close open form", ex.ToString());
                                return;
                            }
                        }

                    publics.dispatcherflag = true;
                    if (!publics.playflag)
                    {
                        publics.playflag = true;
                        Task.WaitAll(Task.Factory.StartNew(() =>
                                          {
                                              this.BeginInvoke(new Action(() =>
                                              {
                                               
                                                  frmVideo play = new frmVideo(lstVide);
                                                  for(int i = 0; i <= 39; i++)
                                                  {
                                                      Application.DoEvents();
                                                  }
                                                  this.Hide();
                                                  play.Show();
                                              }));
                                          }));
                    }
                }
                else
                {
                    Task.WaitAll(Task.Factory.StartNew(() =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            frmVideo play = new frmVideo(lstVide);
                            for (int i = 0; i <= 39; i++)
                            {
                                Application.DoEvents();
                            }
                            this.Hide();
                            Thread.Sleep(500);
                            play.Show();
                        }));
                    }));


                }
            }
            catch (Exception ex)
            {

                publics.WriteLogs("playVideo", ex.ToString());

                //throw;
            }
        }

        private void PlayImg(int flag)
        {
            try
            {
                if (flag == 1)
                {
                    var number = Application.OpenForms;
                    if (!publics.EMGFlag)
                        foreach (Form f in number)
                        {
                            try
                            {
                                if (f.Name != "Form1")
                                {
                                    Task.Factory.StartNew(() =>
                                    {
                                        this.BeginInvoke(new Action(() =>
                                        {
                                            f.Close();
                                            f.Dispose();
                                        }));
                                    });
                                }
                            }
                            catch (Exception ex)
                            {
                                publics.WriteLogs("ex on close open form", ex.ToString());
                                return;
                            }
                        }

                    publics.dispatcherflag = true;
                    frmIMGshow frm = new frmIMGshow(lstJpg);
                    frm.ShowDialog();
                }
                else
                {
                    frmIMGshow frm = new frmIMGshow(lstJpg);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                publics.WriteLogs("playimg", ex.ToString());
                //throw;
            }
        }

        private void CheckFiletypAndAddtoList(string FileName, string FileExten)
        {
            try
            {
                FileExten = FileExten.ToLower();
                var search = (from s in publics.lstImageFormats where s.Contains(FileExten) || s.StartsWith(FileExten) || s.EndsWith(FileExten) select s).FirstOrDefault();
                var searchsound = (from m in publics.lstSoundsFormats where m.Contains(FileExten) || m.StartsWith(FileExten) || m.EndsWith(FileExten) select m).FirstOrDefault();
                var searchvide = (from t in publics.lstVideosFormats where t.Contains(FileExten) || t.StartsWith(FileExten) || t.EndsWith(FileExten) select t).FirstOrDefault();

                if (search != null)
                {
                    if (search.Count() > 0)
                    {
                        imgFlag = true;

                        txtFlag = false;
                        soundFlag = false;
                        videoFlag = false;

                        lstJpg.Clear();

                        var part1 = Directory.GetFiles(FileName, "*.jpg");
                        var part2 = Directory.GetFiles(FileName, "*.jpeg");
                        var part3 = Directory.GetFiles(FileName, "*.bmp");
                        var part4 = Directory.GetFiles(FileName, "*.png");
                        var part5 = Directory.GetFiles(FileName, "*.tif");
                        var part6 = Directory.GetFiles(FileName, "*.ico");
                        var part7 = Directory.GetFiles(FileName, "*.svg");



                        foreach (var s in part1) { lstJpg.Add(s); }
                        foreach (var s in part2) { lstJpg.Add(s); }
                        foreach (var s in part3) { lstJpg.Add(s); }
                        foreach (var s in part4) { lstJpg.Add(s); }
                        foreach (var s in part5) { lstJpg.Add(s); }
                        foreach (var s in part6) { lstJpg.Add(s); }
                        foreach (var s in part7) { lstJpg.Add(s); }




                        //lstJpg.Add(FileName);
                    }

                }
                else if (FileExten.Contains("txt") || FileExten.StartsWith("txt") || FileExten.EndsWith("txt"))
                {
                    txtFlag = true;

                    imgFlag = false;
                    soundFlag = false;
                    videoFlag = false;
                    lsttxt.Clear();

                    var part1 = Directory.GetFiles(FileName, "*.txt");
                    foreach (var s in part1)
                    {
                        lsttxt.Add(s);
                    }
                    //lsttxt.Add(FileName);
                }
                else if (searchvide != null)
                {
                    if (searchvide.Count() > 0)
                    {
                        videoFlag = true;

                        txtFlag = false;
                        imgFlag = false;
                        soundFlag = false;

                        lstVide.Clear();

                        var part1 = Directory.GetFiles(FileName, "*.avi");
                        var part2 = Directory.GetFiles(FileName, "*.mp4");
                        var part3 = Directory.GetFiles(FileName, "*.mkv");
                        var part4 = Directory.GetFiles(FileName, "*.gif");
                        var part5 = Directory.GetFiles(FileName, "*.3gp");
                        var part6 = Directory.GetFiles(FileName, "*.flv");
                        var part7 = Directory.GetFiles(FileName, "*.mkv");
                        var part8 = Directory.GetFiles(FileName, "*.mov");

                        var part9 = Directory.GetFiles(FileName, "*.mpeg");
                        var part10 = Directory.GetFiles(FileName, "*.ogv");
                        var part11 = Directory.GetFiles(FileName, "*.mpeg-1");
                        var part12 = Directory.GetFiles(FileName, "*.mpeg-2");
                        var part13 = Directory.GetFiles(FileName, "*.mpg");

                        foreach (var s in part1)
                        { lstVide.Add(s); }
                        foreach (var s in part2) { lstVide.Add(s); }
                        foreach (var s in part3) { lstVide.Add(s); }
                        foreach (string s in part4) { lstVide.Add(s); }
                        foreach (string s in part5) { lstVide.Add(s); }
                        foreach (string s in part6) { lstVide.Add(s); }
                        foreach (string s in part7) { lstVide.Add(s); }
                        foreach (string s in part8) { lstVide.Add(s); }
                        foreach (string s in part9) { lstVide.Add(s); }
                        foreach (string s in part10) { lstVide.Add(s); }
                        foreach (string s in part11) { lstVide.Add(s); }
                        foreach (string s in part12) { lstVide.Add(s); }
                        foreach (string s in part13) { lstVide.Add(s); }




                        ///lstVide.Add(FileName);
                    }
                }
                else if (searchsound != null)
                {
                    if (searchsound.Count() > 0)
                    {
                        soundFlag = true;

                        videoFlag = false;
                        txtFlag = false;
                        imgFlag = false;


                        lstOgg.Clear();

                        var part1 = Directory.GetFiles(FileName, "*.ogg");
                        var part2 = Directory.GetFiles(FileName, "*.wav");
                        var part3 = Directory.GetFiles(FileName, "*.mp3");
                        var part4 = Directory.GetFiles(FileName, "*.wma");
                        var part5 = Directory.GetFiles(FileName, "*.acc");
                        var part6 = Directory.GetFiles(FileName, "*.aiff");
                        var part7 = Directory.GetFiles(FileName, "*.mmf");
                        var part8 = Directory.GetFiles(FileName, "*.flac");
                        var part9 = Directory.GetFiles(FileName, "*.m4a");
                        var part10 = Directory.GetFiles(FileName, "*.opus");
                        var part11 = Directory.GetFiles(FileName, "*.m4r");



                        foreach (var s in part1) { lstOgg.Add(s); }
                        foreach (var s in part2) { lstOgg.Add(s); }
                        foreach (var s in part3) { lstOgg.Add(s); }
                        foreach (var s in part4) { lstOgg.Add(s); }
                        foreach (var s in part5) { lstOgg.Add(s); }
                        foreach (var s in part6) { lstOgg.Add(s); }
                        foreach (var s in part7) { lstOgg.Add(s); }
                        foreach (var s in part8) { lstOgg.Add(s); }
                        foreach (var s in part9) { lstOgg.Add(s); }
                        foreach (var s in part10) { lstOgg.Add(s); }
                        foreach (var s in part11) { lstOgg.Add(s); }



                        //lstOgg.Add(FileName);

                    }
                }
                else
                {
                    imgFlag = false;
                    soundFlag = false;
                    txtFlag = false;
                    videoFlag = false;

                }
            }
            catch (Exception ex)
            {
                publics.WriteLogs("ex on CheckFiletypeAndAddtoList", ex.ToString());
            }
        }

        private void btn1_Paint(object sender, PaintEventArgs e)
        {
            SetFont(sender, e);
        }



        public void SetFont(object sender, PaintEventArgs e)
        {
            Button btn;
            if (sender is Button)
            {
                btn = (Button)sender;
                float fontSize = NewFontSize(e.Graphics, btn.Size, btn.Font, btn.Text);

                // set font with Font Class and the returned Size from NewFontSize();
                Font f = new Font("B Nazanin", fontSize - 15, FontStyle.Regular);
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

        

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                var files = Directory.GetFiles(publics._Folderspecialpath);

                foreach (string s in files)
                {
                    FileInfo f = new FileInfo(s);

                    string filetyp = f.Extension;

                    CheckFiletypAndAddtoList(publics._Folderspecialpath + "\\", filetyp);
                    break;
                }

                if (imgFlag)
                {
                    PlayImg(1);
                    imgFlag = false;
                    publics.EMGFlag = true;

                }
                else if (txtFlag)
                {
                    playText(1);
                    txtFlag = false; publics.EMGFlag = true;
                }
                else if (videoFlag)
                {
                    playVideo(1);

                    videoFlag = false; publics.EMGFlag = true;
                }
                else if (soundFlag)
                {
                    PlayVoice(lstOgg, 1);
                    soundFlag = false; publics.EMGFlag = true;
                }





            }
            catch (Exception)
            {

                //throw;
            }
        }

       
    }
}
