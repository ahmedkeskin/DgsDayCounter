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
        DateTime _goalDate = new DateTime(2020, 7, 5,10,15,00);
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = _goalDate.ToString();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var day= _goalDate.Subtract(now).Days.ToString("##");
            var hour = _goalDate.Subtract(now).Hours.ToString("##");
            var minute = _goalDate.Subtract(now).Minutes.ToString("##");
            var second = _goalDate.Subtract(now).Seconds.ToString("##");
            lblHour.Text = $"Last:{day} days, {hour}:{minute}:{second}";


        }
    }
}
