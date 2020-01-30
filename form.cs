using Instant.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instant
{
    public partial class form : Form
    {
        List<string> lstVide = new List<string>();


        int selected = 0;

        public form()
        {
            InitializeComponent();
        }
        private void CheckFiletypAndAddtoList(string FileName, string FileExten)
        {
            try
            {
                FileExten = FileExten.ToLower();
                var search = (from s in publics.lstImageFormats where s.Contains(FileExten) || s.StartsWith(FileExten) || s.EndsWith(FileExten) select s).FirstOrDefault();
                var searchsound = (from m in publics.lstSoundsFormats where m.Contains(FileExten) || m.StartsWith(FileExten) || m.EndsWith(FileExten) select m).FirstOrDefault();
                var searchvide = (from t in publics.lstVideosFormats where t.Contains(FileExten) || t.StartsWith(FileExten) || t.EndsWith(FileExten) select t).FirstOrDefault();

            
            
                if (searchvide != null)
                {
                    if (searchvide.Count() > 0)
                    {
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
             
               
            }
            catch (Exception ex)
            {
                publics.WriteLogs("ex on CheckFiletypeAndAddtoList", ex.ToString());
            }
        }
        private void form_Load(object sender, EventArgs e)
        {
            //this is test\
            string folerp = publics._Folder2path;
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

                 
                 
                }
            }

            foreach (var s in lstVide)
            {
                string pre = "file:///";
                string m = s;
                m = m.Replace('\\', '/');
                string filename = Path.GetFileName(s);
                pre += m;
                axVLCPlugin21.playlist.add(pre);
            }

            axVLCPlugin21.MediaPlayerEndReached += AxVLCPlugin21_MediaPlayerEndReached;
            axVLCPlugin21.MouseDownEvent += axVLCPlugin21_MouseDownEvent;
           


        }

   

        private void AxVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            selected++;
            axVLCPlugin21.playlist.playItem(selected);
        }

        private void axVLCPlugin21_MouseDownEvent(object sender, AxAXVLC.DVLCEvents_MouseDownEvent e)
        {
            MessageBox.Show("ok");
        }

        private void form_Shown(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.playItem(selected);
        }
    }
}
