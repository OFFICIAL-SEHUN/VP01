using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using window media player;

namespace _029_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //WindowsMediaPlayer player = new WindowsMediaPlayer();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Today;
            DateTime sDay = dateTimePicker1.Value;

            txtDate.Text = Today.Subtract(sDay).TotalDays.ToString("0");
        }
    }
}
