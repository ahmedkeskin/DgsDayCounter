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
        DateTime _goalDate = new DateTime(2020, 7, 5);
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblRemain.Text = $"Remain Day: {DateTime.Now.Subtract(_goalDate).ToString("dd")}";
            lblHour.Text = $"Remain Hour: {_goalDate.Subtract(DateTime.Now).TotalHours.ToString("#.##")}";
        }
    }
}
