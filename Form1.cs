using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DgsDayCounter
{
    public partial class Form1 : Form
    {
        private enum TaskBarLocation { TOP, BOTTOM, LEFT, RIGHT }

        DateTime _goalDate = new DateTime(2020, 7, 5,10,15,00);
        System.Globalization.CultureInfo _cultureinfo;
        public Form1()
        {
            InitializeComponent();
            //lblDate.Text = _goalDate.ToString("MM/dd/yyyy HH:mm:ss", _cultureinfo);
            _cultureinfo = new System.Globalization.CultureInfo("tr-TR");
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var day= _goalDate.Subtract(now).Days.ToString();
            var hour = _goalDate.Subtract(now).Hours.ToString("00");
            var minute = _goalDate.Subtract(now).Minutes.ToString("00");
            var second = _goalDate.Subtract(now).Seconds.ToString("00");
            lblHour.Text = $"Last:{day} days, {hour}:{minute}:{second}";


        }
        
        private TaskBarLocation GetTaskBarLocation()
        {
            TaskBarLocation taskBarLocation = TaskBarLocation.BOTTOM;
            bool taskBarOnTopOrBottom = (Screen.PrimaryScreen.WorkingArea.Width == Screen.PrimaryScreen.Bounds.Width);
            if (taskBarOnTopOrBottom)
            {
                if (Screen.PrimaryScreen.WorkingArea.Top > 0) taskBarLocation = TaskBarLocation.TOP;
            }
            else
            {
                if (Screen.PrimaryScreen.WorkingArea.Left > 0)
                {
                    taskBarLocation = TaskBarLocation.LEFT;
                }
                else
                {
                    taskBarLocation = TaskBarLocation.RIGHT;
                }
            }
            return taskBarLocation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var height = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            var width = Screen.PrimaryScreen.WorkingArea.Width;
            width -= Width;
            Left = width - 150;
            Top = height;
            Height = 15;
            Opacity = 0.35;
        }

        private void lblHour_DoubleClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            Opacity = 1;
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            Opacity = 0.35;
        }
    }
}
