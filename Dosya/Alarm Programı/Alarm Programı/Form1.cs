using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            timer1.Enabled = true;
            for(int i = 0; i <= 23; i++)
            {
                comboBox1.Items.Add(i);
            }
            for(int j = 00; j <= 59; j++)
            {
                comboBox2.Items.Add(j);
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            button1.Visible = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            button3.Visible = true;
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsa.Text = DateTime.Now.Hour.ToString();
            lbldk.Text = DateTime.Now.Minute.ToString();
            lblsn.Text = DateTime.Now.Second.ToString();
            lbluzunta.Text = DateTime.Now.ToLongDateString();//uzun tarih
            lbluzunsa.Text = DateTime.Now.ToLongTimeString();//uzunsaat

            if (comboBox1.Text == lblsa.Text && comboBox2.Text == lbldk.Text)
            {
                timer1.Enabled = false;
                
                axWindowsMediaPlayer1.URL = "C:\\Users\\Ferhat\\source\\repos\\Alarm Programı\\Alarm Programı\\bin\\Debug\\1.mp3";
                button2.Enabled = true;
                MessageBox.Show("Uyanma Zamanı!!!!");
                button2.Visible = true;
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Enabled = true;
            button1.Visible = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
    }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text="";
            button1.Visible = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button3.Visible = false;

        }
    }
}
