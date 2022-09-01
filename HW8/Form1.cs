using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8
{
    public partial class mform1 : Form
    {
        public mform1()
        {
            InitializeComponent();
        }

        private void lottery_Click(object sender, EventArgs e)
        {
            midterm_project.Form2 m1 = new midterm_project.Form2();
            if(this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            m1.MdiParent = this;
            m1.StartPosition = FormStartPosition.Manual;
            m1.Location = (Point)new Size(0, 0);
            m1.Show();
            m1.FormClosed += new FormClosedEventHandler(formclose);
        }
        void form3close(object sender, FormClosedEventArgs e)
        {
            midterm_project.Form2 m1 = new midterm_project.Form2();
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            m1.MdiParent = this;
            m1.StartPosition = FormStartPosition.Manual;
            m1.Location = (Point)new Size(0, 0);
            m1.Show();
            m1.FormClosed += new FormClosedEventHandler(formclose);
        }
        void formclose(object sender, FormClosedEventArgs e)
        {
            midterm_project.Form2 F2 = (midterm_project.Form2)sender;
            if(F2.aa() == 1)
            {
                int ti = 0;
                string st = "";
                int[][] F = new int[5][];
                ti = F2.passt();
                st = F2.passstr();
                F = F2.passnumber();
                midterm_project.Form3 F3 = new midterm_project.Form3();
                F3.times(ti);
                F3.setstring(st);
                for (int i = 0; i <= ti; i++)
                {
                    F3.number(F[i]);
                }
                F3.MdiParent = this;
                F3.StartPosition = FormStartPosition.Manual;
                F3.Location = (Point)new Size(0, 0);
                F3.Show();
            }
            
            //F3.FormClosed += new FormClosedEventHandler(formclose);
        }
        private void poker_Click(object sender, EventArgs e)
        {
            HW5.Form1 h1 = new HW5.Form1();
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            h1.StartPosition = FormStartPosition.Manual;
            h1.Location = (Point)new Size(0, 0);
            h1.MdiParent = this;
            h1.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mform1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void mform1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
