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
    public partial class DateTimeForm2 : Form
    {
        public DateTimeForm2()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void DateTimeForm2_Load(object sender, EventArgs e)
        {

            var info = PersianDateTime.GetDateData(DateTime.Now);
            lblTodayMonasebat.Text = info;
            lblTodayMonasebat.BackColor = Color.Blue;



            lblHolidayTomarow.Font = new Font(lblHolidayTomarow.Font.FontFamily,(tableLayoutPanel1.Height/6)+7);
            lblTodayMonasebat.Font = new Font(lblTodayMonasebat.Font.FontFamily, (tableLayoutPanel1.Height /6) + 7);
            var tomarow = new PersianDateTime(DateTime.Now.AddDays(1));
            if (tomarow.IsHoliDay)
            {
                 lblHolidayTomarow.Text = "فردا تعطیل است";
                 lblHolidayTomarow.BackColor = Color.Red;

            }
            else
            {
                lblHolidayTomarow.Text = "فردا تعطیل نیست";
                 lblHolidayTomarow.BackColor = Color.Pink;
            }




        }

        private void DateTimeForm2_Click(object sender, EventArgs e)
        {
            
        }

        private void lblHolidayTomarow_Click(object sender, EventArgs e)
        {
this.Close();
            this.Dispose();
        }
    }
}
