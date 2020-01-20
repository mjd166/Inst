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
    public partial class VoicePly : Form
    {


        List<string> _lstplaysound = new List<string>();






        int selected = 0;


        public VoicePly()
        {
            InitializeComponent();
        }
        public VoicePly(List<string> lstplay)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            axVLCPlugin21.AutoPlay = true;



            _lstplaysound = lstplay;



            // axVLCPlugin21.MediaPlayerOpening += AxVLCPlugin21_MediaPlayerOpening;

            axVLCPlugin21.MediaPlayerEndReached += AxVLCPlugin21_MediaPlayerEndReached;

            if (publics.dispatcherflag)
            {
                this.axVLCPlugin21.MouseDownEvent += new AxAXVLC.DVLCEvents_MouseDownEventHandler(this.axVLCPlugin21_MouseDownEvent);
            }
        }

        private void AxVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            try
            {
                if (selected >= _lstplaysound.Count - 1)
                {
                    //axVLCPlugin21.playlist.stop();
                    // axVLCPlugin21.Dispose();
                    //Thread.Sleep(3000);
                    for (int i = 0; i <= 99999; i++)
                    {
                        Application.DoEvents();
                        Application.DoEvents();
                        // Application.DoEvents();
                    }



                    axVLCPlugin21.playlist.items.clear();

                    if (publics.dispatcherflag)
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
                    }

                    _lstplaysound.Clear();
                    publics.playflag = false;
                    this.Close();
                    this.Dispose();




                }

                //axVLCPlugin21.playlist.playItem(selected);

                //axVLCPlugin21.playlist.stop();

                for (int i = 0; i <= 99999; i++)
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

        private void AxVLCPlugin21_MediaPlayerOpening(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }




        private void VoicePly_Load(object sender, EventArgs e)
        {



            foreach (var s in _lstplaysound)
            {
                string pre = "file:///";
                string m = s;
                m = m.Replace('\\', '/');

                string filename = Path.GetFileName(s);
                pre += m;
                axVLCPlugin21.playlist.add(pre);

            }









            //axVLCPlugin21.playlist.add("file:///D:/OfficialWorkDocs/2/Del-01.mp4");

        }




        private void VoicePly_Shown(object sender, EventArgs e)
        {
            // axVLCPlugin21.playlist.playItem(selected);
            Task.Factory.StartNew(() =>
            {
                this.BeginInvoke(new Action(() =>
                 {
                     axVLCPlugin21.playlist.playItem(selected);
                 }));
            });

            axVLCPlugin21.MediaPlayerMediaChanged += AxVLCPlugin21_MediaPlayerMediaChanged;
            // 
        }

        private void AxVLCPlugin21_MediaPlayerMediaChanged(object sender, EventArgs e)
        {

            selected++;

            if (selected > _lstplaysound.Count)
            {
                for (int i = 0; i <= 99999; i++)
                {
                    Application.DoEvents(); Application.DoEvents();
                }
                if (publics.dispatcherflag)
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
                }
                this.Close();
                this.Dispose();
            }
        }



        private void axVLCPlugin21_ClickEvent(object sender, EventArgs e)
        {







        }

        private void playnext(int selected)
        {




            if (selected >= _lstplaysound.Count)
            {
                for (int i = 0; i <= 99999; i++)
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
                    publics.playflag = false;
                    this.Close();
                    this.Dispose();
                   

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

        private void VoicePly_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void axVLCPlugin21_MouseMoveEvent(object sender, AxAXVLC.DVLCEvents_MouseMoveEvent e)
        {


        }

        private void axVLCPlugin21_MouseDownEvent(object sender, AxAXVLC.DVLCEvents_MouseDownEvent e)
        {


            AxAXVLC.DVLCEvents_MouseDownEvent me = e;

            if (me.button == 2)
            {
                if (publics.dispatcherflag)
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
                }
                this.Close();
                this.Dispose();
            }
            else
            {

                try
                {

                    if (selected >= _lstplaysound.Count)
                    {
                        if (publics.dispatcherflag)
                        {
                            this.Close();
                            this.Dispose();
                            for (int i = 0; i <= 9999999; i++)
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

        private void VoicePly_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void VoicePly_FormClosing(object sender, FormClosingEventArgs e)
        {
            publics.playflag = false;
        }
    }



}
