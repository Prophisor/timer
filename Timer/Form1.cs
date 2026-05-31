using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int timerleft = 60;
        private void startbutton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (Counter.Text== "Time is up!")
            {
                timerleft = 60;
                timer1.Start();
                timerleft = timerleft - 1;
                Counter.Text = timerleft + " Seconds";
            }
            
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Counter.Text = timerleft + " Seconds";
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            timerleft = timerleft + 5;
            Counter.Text = timerleft + " Seconds";
        }

        private void subbutton_Click(object sender, EventArgs e)
        {
            timerleft = timerleft - 5;
            Counter.Text = timerleft + " Seconds";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Startagain();
        }

        private void Startagain()
        {
            if (timerleft > 0)
            {
                timerleft = timerleft - 1;
                Counter.Text = timerleft + " Seconds";
            }
            else
            {
                timer1.Stop();
                Counter.Text = "Time is up!";
            }
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerleft = 60;
            Counter.Text = timerleft + " Seconds";
        }
    }
}
