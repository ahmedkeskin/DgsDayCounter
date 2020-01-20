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
        System.Globalization.CultureInfo _cultureinfo;
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = _goalDate.ToString("MM/dd/yyyy HH:mm:ss", _cultureinfo);
            _cultureinfo = new System.Globalization.CultureInfo("tr-TR");
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var day= _goalDate.Subtract(now).Days.ToString("##", _cultureinfo);
            var hour = _goalDate.Subtract(now).Hours.ToString("##", _cultureinfo);
            var minute = _goalDate.Subtract(now).Minutes.ToString("##", _cultureinfo);
            var second = _goalDate.Subtract(now).Seconds.ToString("##", _cultureinfo);
            lblHour.Text = $"Last:{day} days, {hour}:{minute}:{second}";


        }
    }
}
