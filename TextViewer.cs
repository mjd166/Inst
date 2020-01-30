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
    public partial class TextViewer : Form
    {


        List<string> _lstFiles = new List<string>();


        string _text = "";
        //string[] words;
        int selected = 1;
        int selectedFiles = 0;

        public TextViewer()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        private long WordCount(string strInput)
        {
            long intCount = 0;
            for (int i = 1; i < strInput.Length; i++)
            {
                if (char.IsWhiteSpace(strInput[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(strInput[i]) == true ||
                        char.IsPunctuation(strInput[i]))
                    {
                        intCount++;
                    }
                }
            }
            if (strInput.Length > 2)
            {
                intCount++;
            }
            return intCount - 1;
        }


        List<string> lstwords = new List<string>();


        public TextViewer(List<string> text)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _lstFiles = text;
            _text = File.ReadAllText(_lstFiles[0]);
            _text = _text.Trim();
            //_text = _text.Replace(" ", "");

            _text = _text.Replace('\n', ' ');
            _text = _text.Replace('\r', ' ');

            AddTolist(_text);


        }


        private void AddTolist(string text)
         {
            lstwords.Clear();
           text = text.Replace('\n', ' ');
            text = text.Replace('.', ' ');
            text = text.Replace('\r', ' ');
            var words = text.Split(' ');

            int i = 0;
            foreach (string s in words)
            {

                if (s != "")
                {
                    lstwords.Add(words[i]);
                }
                i++;
            }
        }
        private void TextViewer_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, (tableLayoutPanel1.Height / 6), FontStyle.Regular);
            label2.Font = new Font(label2.Font.FontFamily, (tableLayoutPanel1.Height / 6), FontStyle.Regular);

            if (lstwords.Count > 1)
            {
                if (lstwords[0] != "")
                    label1.Text = lstwords[0];


                label2.Text = lstwords[1];

            }


            //SizeLabelFont(label1);
        }


        private void Nextitem()
        {
            try
            {

                selected++;

                if (selected == 1)
                    if (!(selected > lstwords.Count))
                        label1.Text = lstwords[selected];
                    else
                    {
                        if (selectedFiles > _lstFiles.Count )
                        {
                            if (publics.dispatcherflag)
                            {
                                this.Dispose();
                                this.Close();
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
                                this.Dispose();
                                this.Close();
                            }

                        }
                        else
                        {
                            selectedFiles++;
                            _text = File.ReadAllText(_lstFiles[selectedFiles]);
                            AddTolist(_text);
                            selected = -1;
                            Nextitem();
                        }
                    }


                if (!(selected > lstwords.Count))
                {
                    label1.Text = lstwords[selected];
                    selected++;
                    if (!(selected >= lstwords.Count))
                        label2.Text = lstwords[selected];
                    else
                    {
                        label2.Text = "";
                        return;
                        if (selectedFiles > _lstFiles.Count )
                        {
                            if (publics.dispatcherflag)
                            {

                                this.Close();
                                this.Close();
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
                                this.Close();
                                this.Close();
                            }

                        }
                        else
                        {
                            selectedFiles++;
                            _text = File.ReadAllText(_lstFiles[selectedFiles]);
                            AddTolist(_text);
                            selected = -1;
                            Nextitem();
                        }

                    }
                }
                else
                {
                    selectedFiles++;
                    if (selectedFiles >= _lstFiles.Count )
                    {
                        if (publics.dispatcherflag)
                        {

                            this.Close();
                            this.Close();
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
                            this.Close();
                            this.Close();
                        }
                    }
                    else
                    {
                        selectedFiles++;
                        _text = File.ReadAllText(_lstFiles[selectedFiles]);
                        AddTolist(_text);
                        selected = -1;
                        Nextitem();
                    }
                }


            }
            catch (Exception exNext)
            {
                selected++;
                Class.publics.WriteLogs("exNetx item on TextViewer", exNext.ToString());
                return;

            }
        }
        private void Label1_SizeChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }


        private void SizeLabelFont(Label lbl)
        {
            // Only bother if there's text.
            string txt = lbl.Text;
            if (txt.Length > 0)
            {
                int best_size = 100;

                // See how much room we have, allowing a bit
                // for the Label's internal margin.
                int wid = lbl.DisplayRectangle.Width - 3;
                int hgt = lbl.DisplayRectangle.Height - 3;

                // Make a Graphics object to measure the text.
                using (Graphics gr = lbl.CreateGraphics())
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        using (Font test_font = new Font(lbl.Font.FontFamily, i))
                        {
                            // See how much space the text would
                            // need, specifying a maximum width.
                            SizeF text_size = gr.MeasureString(txt, test_font);
                            if ((text_size.Width > wid) ||
                                (text_size.Height > hgt))
                            {
                                best_size = i - 1;
                                break;
                            }
                        }
                    }
                }

                // Use that font size.
                lbl.Font = new Font(lbl.Font.FontFamily, best_size);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                if (publics.dispatcherflag)
                {
                    this.Close();
                    this.Dispose();

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
                    this.Close();
                    this.Dispose();

                }

            }

            Nextitem();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            SetFont(sender, e);
        }

        public void SetFont(object sender, PaintEventArgs e)
        {
            TextBox btn;
            if (sender is TextBox)
            {
                btn = (TextBox)sender;
                float fontSize = NewFontSize(e.Graphics, btn.Size, btn.Font, btn.Text);

                // set font with Font Class and the returned Size from NewFontSize();
                Font f = new Font("B Nazanin", fontSize+30, FontStyle.Bold);
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
    }
}
