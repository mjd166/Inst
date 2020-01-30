using AxAXVLC;
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
    public partial class frmVideo : Form
    {
        List<string> _lstplayback = new List<string>();
        int selected = 0;

        public frmVideo()
        {
            InitializeComponent();
        }
        public frmVideo(List<string> lstVideo)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            axVLCPlugin21.AutoPlay = true;
            _lstplayback = lstVideo;

        }

        private void AxVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (selected >= _lstplayback.Count - 1)
            //        {
            //            //axVLCPlugin21.playlist.stop();
            //            // axVLCPlugin21.Dispose();
            //            //Thread.Sleep(3000);
            //            for (int i = 0; i <= 99; i++)
            //            {
            //                Application.DoEvents();
            //                Application.DoEvents();
            //                // Application.DoEvents();
            //            }


            //            axVLCPlugin21.playlist.items.clear();
            //            _lstplayback.Clear();

            //            this.Close();
            //            this.Dispose();
            //            if (publics.dispatcherflag)
            //            {
            //                foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
            //                {
            //                    try
            //                    {
            //                        File.Delete(file);
            //                    }
            //                    catch (Exception exdelete)
            //                    {
            //                        publics.WriteLogs("exdelete", exdelete.ToString());

            //                        //throw;
            //                    }
            //                    publics.dispatcherflag = false;

            //                }
            //            }


            //            publics.playflag = false;
            //        }
            //        //axVLCPlugin21.playlist.playItem(selected);
            //        //axVLCPlugin21.playlist.stop();
            //        for (int i = 0; i <= 99; i++)
            //        {
            //            Application.DoEvents();
            //            Application.DoEvents();
            //        }
            //        // axVLCPlugin21.playlist.next();
            //        //axVLCPlugin21.playlist.playItem(selected);
            //        selected += 1;
            //    }
            //    catch (Exception)
            //    {
            //        //throw;
            //    }
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            //Panel panel1 = new Panel();

            //// fill panel1 on his parent control
            //panel1.Dock = DockStyle.Fill;


            ////Now set your Events you want but use panel1 and not vlcControl1
            ////for example i use this one
            //panel1.MouseClick += Panel1_MouseClick; ;

            ////panel1 has no parent control
            ////add panel1 to vlcControl1
            //axVLCPlugin21.Controls.Add(panel1);
            //this.BackColor = Color.White;

            //panel1.BackColor = Color.FromArgb(1, Color.Black);
            //this.Opacity = 20;

            ////need to bring panel1 to front
            //panel1.BringToFront();

            foreach (var s in _lstplayback)
            {
                string pre = "file:///";
                string m = s;
                m = m.Replace('\\', '/');
                string filename = Path.GetFileName(s);
                pre += m;
                axVLCPlugin21.playlist.add(pre);
            }
        }




        private void frmVideo_Shown(object sender, EventArgs e)
        {
            axVLCPlugin21.MediaPlayerEndReached += AxVLCPlugin21_MediaPlayerEndReached;
            //axVLCPlugin21.MouseDownEvent += axVLCPlugin21_MouseDownEvent;
            axVLCPlugin21.MediaPlayerMediaChanged += AxVLCPlugin21_MediaPlayerMediaChanged;


            axVLCPlugin21.playlist.playItem(selected);






        }



        private void AxVLCPlugin21_MediaPlayerMediaChanged(object sender, EventArgs e)
        {
            //selected++;
            //if (selected > _lstplayback.Count)
            //{
            //    for (int i = 0; i <= 99; i++)
            //    {
            //        Application.DoEvents(); Application.DoEvents();
            //    }
            //    if (publics.dispatcherflag)
            //    {
            //        foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
            //        {
            //            try
            //            {
            //                File.Delete(file);
            //            }
            //            catch (Exception exdelete)
            //            {
            //                publics.WriteLogs("exdelete", exdelete.ToString());

            //                //throw;
            //            }
            //            publics.dispatcherflag = false;
            //        }
            //    }
            //    this.Close();
            //    this.Dispose();
            //    publics.playflag = false;
            //}
        }


        private void playnext(int selected)
        {
            if (selected >= _lstplayback.Count)
            {
                for (int i = 0; i <= 89; i++)
                {
                    Application.DoEvents(); Application.DoEvents();
                }
                try
                {
                    if (publics.dispatcherflag)
                    {
                        foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
                        {
                            try
                            {
                                File.Delete(file);
                            }
                            catch (Exception exdelete)
                            {
                                publics.WriteLogs("exdelete", exdelete.ToString());

                                //throw;
                            }
                            publics.dispatcherflag = false;

                        }
                    }
                    this.Close();
                    this.Dispose();
                    publics.playflag = false;

                }
                catch (Exception)
                {
                    if (publics.dispatcherflag)
                    {
                        foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
                        {
                            try
                            {
                                File.Delete(file);
                            }
                            catch (Exception exdelete)
                            {
                                publics.WriteLogs("exdelete", exdelete.ToString());

                                //throw;
                            }
                            publics.dispatcherflag = false;

                        }
                    }

                    Task.Factory.StartNew(() =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            this.Close();
                            this.Dispose();
                            publics.playflag = false;

                        }));
                    });

                }



            }

            try
            {

                //for (int i = 0; i <= 99999; i++)
                //{
                //    Application.DoEvents(); Application.DoEvents();
                //}

                try
                {
                    // Thread.Sleep(1500);

                    axVLCPlugin21.playlist.next();

                }
                catch (Exception)
                {
                    //Thread.Sleep(1500);
                    //Task.Factory.StartNew(() =>
                    //{
                    //    this.BeginInvoke(new Action(() =>
                    //    {
                    //        axVLCPlugin22.playlist.next();
                    //    }));
                    //});

                }


            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void functon(object sender, AxAXVLC.DVLCEvents_MouseDownEvent e)
        {

            AxAXVLC.DVLCEvents_MouseDownEvent me = e;

            if (me.button == 2)
            {
                if (publics.dispatcherflag)
                {
                    for (int i = 0; i <= 20; i++)
                    {
                        Application.DoEvents();
                    }
                    this.Close();
                    this.Dispose();
                    for (int i = 0; i <= 99; i++)
                    {
                        Application.DoEvents();

                    }
                    foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception exdelete)
                        {
                            publics.WriteLogs("exdelete", exdelete.ToString());

                            //throw;
                        }
                        publics.dispatcherflag = false;
                    }

                }
                this.Close();
                this.Dispose();
            }
            else
            {

                try
                {

                    if (selected >= _lstplayback.Count)
                    {
                        if (publics.dispatcherflag)
                        {
                            this.Close();
                            this.Dispose();
                            for (int i = 0; i <= 99; i++)
                            {
                                Application.DoEvents();

                            }
                            foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
                            {
                                try
                                {
                                    File.Delete(file);
                                }
                                catch (Exception exdelete)
                                {
                                    publics.WriteLogs("exdelete", exdelete.ToString());

                                    //throw;
                                }
                                publics.dispatcherflag = false;

                            }
                        }



                        return;
                    }

                    Task.WaitAll(Task.Factory.StartNew(() =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            playnext(selected);
                        }));
                    }));
                }
                catch (Exception)
                {

                    // throw;
                }



            }
        }

      

        private void axVLCPlugin21_MouseDownEvent_1(object sender, DVLCEvents_MouseDownEvent e)
        {


            AxAXVLC.DVLCEvents_MouseDownEvent me = e;

            if (me.button == 2)
            {
                if (publics.dispatcherflag)
                {

                    for (int i = 0; i <= 29; i++)
                    {
                        Application.DoEvents();

                    }
                    this.BeginInvoke(new Action(() =>
                    {
                        this.Close();
                        this.Dispose();

                    }));
                    for (int i = 0; i <= 29; i++)
                    {
                        Application.DoEvents();

                    }
                    try
                    {
                        this.Hide();
                    }
                    catch (Exception)
                    {

                        // throw;
                    }
                    Form1 frmmain = new Form1();
                    frmmain.Show();
                    foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch (Exception exdelete)
                        {
                            publics.WriteLogs("exdelete", exdelete.ToString());
                            //throw;
                        }
                        publics.dispatcherflag = false;
                    }
                }
                else
                {
                    for (int i = 0; i <= 29; i++)
                    {
                        Application.DoEvents();

                    }
                  
                    this.BeginInvoke(new Action(() =>
                    {
                        axVLCPlugin21.playlist.pause();
                        Thread.Sleep(100);
                        this.Close();
                        Thread.Sleep(100);
                        this.Dispose();
                        Thread.Sleep(100);

                    }));
                    for (int i = 0; i <= 29; i++)
                    {
                        Application.DoEvents();
                    }
                    try
                    {
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        // throw;
                    }
                    Form1 frmmain = new Form1();
                    frmmain.Show();

                }

            }
            else
            {

                try
                {

                    if (selected >= _lstplayback.Count)
                    {
                        if (publics.dispatcherflag)
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                axVLCPlugin21.playlist.pause();
                                Thread.Sleep(100);

                                this.Close();
                                Thread.Sleep(100);
                                this.Dispose();
                                Thread.Sleep(100);

                            }));
                            for (int i = 0; i <= 99; i++)
                            {
                                Application.DoEvents();

                            }
                            foreach (var file in Directory.GetFiles(publics._Folderspecialpath))
                            {
                                try
                                {
                                    File.Delete(file);
                                }
                                catch (Exception exdelete)
                                {
                                    publics.WriteLogs("exdelete", exdelete.ToString());

                                    //throw;
                                }
                                publics.dispatcherflag = false;

                            }
                        }



                        return;
                    }

                    Task.WaitAll(Task.Factory.StartNew(() =>
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            playnext(selected);
                        }));
                    }));
                }
                catch (Exception)
                {

                    // throw;
                }



            }

        }
    }
}
