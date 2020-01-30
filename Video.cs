﻿using AxAXVLC;
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
    public partial class Video : Form
    {
        List<string> _lstplayback = new List<string>();

       
        int selected = 0;
        public Video()
        {
            InitializeComponent();
        }
        public Video(List<string> lstVideo)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            axVLCPlugin21.AutoPlay = true;
            _lstplayback = lstVideo;


            axVLCPlugin21.MediaPlayerEndReached += AxVLCPlugin21_MediaPlayerEndReached;
            //if (publics.dispatcherflag)
            this.axVLCPlugin21.MouseDownEvent += AxVLCPlugin21_MouseDownEvent;

            this.axVLCPlugin21.MediaPlayerPlaying += AxVLCPlugin21_MediaPlayerPlaying;

        }

    

        private void AxVLCPlugin21_MediaPlayerPlaying(object sender, EventArgs e)
        {          Application.DoEvents();
        }

        private void AxVLCPlugin21_MouseDownEvent(object sender, DVLCEvents_MouseDownEvent e)
        {
            MessageBox.Show("oa");
        }

        private void AxVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            try
            {
                if (selected >= _lstplayback.Count - 1)
                {
                    //axVLCPlugin21.playlist.stop();
                    // axVLCPlugin21.Dispose();
                    //Thread.Sleep(3000);
                    for (int i = 0; i <= 99; i++)
                    {
                        Application.DoEvents();
                        Application.DoEvents();
                        // Application.DoEvents();
                    }


                    axVLCPlugin21.playlist.items.clear();
                    _lstplayback.Clear();

                    this.Close();
                    this.Dispose();
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


                    publics.playflag = false;
                }
                //axVLCPlugin21.playlist.playItem(selected);
                //axVLCPlugin21.playlist.stop();
                for (int i = 0; i <= 99; i++)
                {
                    Application.DoEvents();
                    Application.DoEvents();
                }
                // axVLCPlugin21.playlist.next();
                //axVLCPlugin21.playlist.playItem(selected);
                selected += 1;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void Video_Load(object sender, EventArgs e)
        {



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
        private void Video_Shown(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                this.BeginInvoke(new Action(() =>
                {
                    axVLCPlugin21.playlist.playItem(selected);
                }));
            });
            axVLCPlugin21.MediaPlayerMediaChanged += AxVLCPlugin21_MediaPlayerMediaChanged;



        }
        private void AxVLCPlugin21_MediaPlayerMediaChanged(object sender, EventArgs e)
        {
            selected++;
            if (selected > _lstplayback.Count)
            {
                for (int i = 0; i <= 99; i++)
                {
                    Application.DoEvents(); Application.DoEvents();
                }
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


        private void Video_MouseDown(object sender, MouseEventArgs e)
        {



            //MouseEventArgs me = e;

            //if (me.Button == MouseButtons.Right)
            //{

            //    for (int i = 0; i <= 99; i++)
            //    {
            //        Application.DoEvents();
            //        //Application.DoEvents();
            //    }
            //    this.Close();
            //    this.Dispose();
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


            //    publics.playflag = false;
            //    return;
            //}
            //else
            //{

            //    if (selected >= _lstplayback.Count)
            //    {
            //        for (int i = 0; i <= 99; i++)
            //        {
            //            Application.DoEvents();
            //            Application.DoEvents();
            //        }

            //        this.Close();
            //        this.Dispose();
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
            //        return;
            //    }




            //    Task.WaitAll(
            //    Task.Factory.StartNew(() =>
            //    {
            //        this.BeginInvoke(new Action(() =>
            //        {
            //            playnext(selected);
            //        }));
            //    }));



            //}
        }



        private void functon(object sender, DVLCEvents_MouseDownEvent e)
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

       

       
    }
}
