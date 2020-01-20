using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Instant.Class
{
    static class publics
    {
        public static string _Folder1path = @"D:\OfficialWorkDocs\1";
        public static string _Folder2path = @"D:\OfficialWorkDocs\2";
        public static string _Folder3path = @"D:\OfficialWorkDocs\3";
        public static string _Folder4path = @"D:\OfficialWorkDocs\4";

        public static string _Folder5path = @"D:\OfficialWorkDocs\5";
        public static string _Folder6path = @"D:\OfficialWorkDocs\6";
        public static string _Folder7path = @"D:\OfficialWorkDocs\7";

        public static string _Folder8path = @"D:\OfficialWorkDocs\8";
        public static string _Folder9path = @"D:\OfficialWorkDocs\9";

        public static string _Folderspecialpath = @"D:\OfficialWorkDocs\special";

        public static string _RootPath = @"D:\OfficialWorkDocs";

        public static bool playflag = false;
        public static bool EMGFlag = false;

        public static  PersianCalendar PCal = new PersianCalendar();

        public static readonly HttpClient client = new HttpClient();


        public static bool dispatcherflag = false;

        public static List<string> lstSoundsFormats = new List<string>();

        internal static void GetBtnsText()
        {
            throw new NotImplementedException();
        }

        public static List<string> lstVideosFormats = new List<string>();

        public static List<string> lstImageFormats = new List<string>();


        public static void Setinfo()
        {

            lstSoundsFormats.Add(".mp3");
            lstSoundsFormats.Add(".ogg");
            lstSoundsFormats.Add(".wma");
            lstSoundsFormats.Add(".acc");
            lstSoundsFormats.Add(".aiff");
            lstSoundsFormats.Add(".mmf");
            lstSoundsFormats.Add(".flac");
            lstSoundsFormats.Add(".wav");
            lstSoundsFormats.Add(".m4a");
            lstSoundsFormats.Add(".opus");
            lstSoundsFormats.Add(".m4r");
            //////////////////////////////////////////////////////////////////
            ///
            lstImageFormats.Add(".jpg");
            lstImageFormats.Add(".jpeg");
            lstImageFormats.Add(".png");
            lstImageFormats.Add(".bmp");
            lstImageFormats.Add(".tiff");
            lstImageFormats.Add(".eps");
            lstImageFormats.Add(".ico");
            lstImageFormats.Add(".svg");
            lstImageFormats.Add(".tga");

            ////////////////////////////////////////////////////////////////////////////
            ///

            lstVideosFormats.Add(".avi");
            lstVideosFormats.Add(".mp4");
            lstVideosFormats.Add(".3gp");
            lstVideosFormats.Add(".flv");
            lstVideosFormats.Add(".mkv");
            lstVideosFormats.Add(".mov");
            lstVideosFormats.Add(".mpg");
            lstVideosFormats.Add(".mpeg");
            lstVideosFormats.Add(".mpeg-1");
            lstVideosFormats.Add(".mpeg-2");
            lstVideosFormats.Add(".ogv");



        }


        public static void WriteLogs(string Title,string Err)
        {
            try
            {
                string datet = publics.GetDateTime();
                string path = AppDomain.CurrentDomain.BaseDirectory + @"\ErrLog.txt";
                if (!File.Exists(path))
                {
                    // File.Create(path);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(Title + Environment.NewLine + datet +  Environment.NewLine  + Err.ToString());
                    }
                }
                else
                {
                    using (StreamWriter Writer = new StreamWriter(
                                   new FileStream(path,
                                   FileMode.Append,
                                   FileAccess.Write)))
                    {
                        Writer.WriteLine(Title + Environment.NewLine  + datet +  Environment.NewLine  + Err.ToString());
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        public static string GetDateTime()
        {
            try
            {

                string Current_date = PCal.GetYear(DateTime.Now) + "/" + PCal.GetMonth(DateTime.Now).ToString("00") + "/" + PCal.GetDayOfMonth(DateTime.Now).ToString("00");
                return Current_date;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
