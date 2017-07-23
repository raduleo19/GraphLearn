using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Register : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Register()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
        }

        //-------------Mouse Move Zone-------------//
        Point mouseDownPoint = Point.Empty;
        private void Form_mouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }
        private void Form_mouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }
        private void Form_mouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint == Point.Empty) return;

            this.Location = new Point(this.Location.X + (e.X - mouseDownPoint.X), this.Location.Y + (e.Y - mouseDownPoint.Y));
        }
        //-------------End Mouse Move Zone-------------//



        //----------Button Events Zone----------// 
        private void Namebox_Click(object sender, EventArgs e)
        {
            Namebox.Clear();
        }
        private void Passbox_Click(object sender, EventArgs e)
        {
            Passbox.Clear();
        }
        private void Mailbox_Click(object sender, EventArgs e)
        {
            Mailbox.Clear();
        }
        private void Classbox_Click(object sender, EventArgs e)
        {
            Classbox.Clear();
        }
        private void ProfBox_Click(object sender, EventArgs e)
        {
            ProfBox.Clear();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
                      
          
            Grafuri.Register(Namebox.Text, Passbox.Text, Mailbox.Text, ProfBox.Text, Classbox.Text, 1);
            MessageBox.Show("Succes", "Registration Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Grafuri.User = Namebox.Text;
            Grafuri.Clasa = Classbox.Text;
            Grafuri.isConnectedToDB = 1;
            Grafuri Form = new WindowsFormsApplication4.Grafuri();
            Form.Show();
            this.Hide();
        }
        //----------End Button Events Zone----------//
    }
}
