using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.CenterToScreen();
            label1.Hide();

        }


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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button17_Click(object sender, EventArgs e)
        {
        label1.Show();
            // int rez = await Grafuri.Login(textBox1.Text, textBox2.Text);
            int rez = 0;
        if(rez == 0) { MessageBox.Show("Parola sau Nume gresit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        label1.Hide(); }
            else if(rez == -1) { MessageBox.Show("Fara raspuns de la baza de date,va rugam logativa ca vizitator", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        label1.Hide(); }
        else {
        label1.Hide();
        Grafuri Form = new WindowsFormsApplication4.Grafuri();
        Form.Show();
        this.Hide();
        }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register Form = new WindowsFormsApplication4.Register();
            Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Progresul nu va fi salvat!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Grafuri.isConnectedToDB = 0;
            Grafuri Form = new WindowsFormsApplication4.Grafuri();
            Form.Show();
            this.Hide();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
    public partial class CustomLabel : Label
    {
        private TextRenderingHint _hint = TextRenderingHint.SystemDefault;
        public TextRenderingHint TextRenderingHint
        {
            get { return this._hint; }
            set { this._hint = value; }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.TextRenderingHint = TextRenderingHint;
            base.OnPaint(pe);
        }
    }
}
