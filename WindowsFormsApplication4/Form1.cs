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
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
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
            if(mouseDownPoint == Point.Empty)
                return;
            Form Form1 = this as Form;
            Form1.Location = new Point(Form1.Location.X + (e.X - mouseDownPoint.X), Form1.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Grafuri._con.Close();
        Grafuri._con.Open();
            MySqlCommand cmd = Grafuri._con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Intrebari (EN,R1,R2,R3,R4,RS) VALUES('" +EN.Text + "','" + R1.Text + "','" + R2.Text + "','" + R3.Text + "','" + R4.Text + "','" + Convert.ToInt32(RS.Text) + "');";

            cmd.ExecuteNonQuery();
            Grafuri._con.Close();
            MessageBox.Show("Succes", "Adaugare reusita!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void button17_Click(object sender, EventArgs e)
        {
            try { Grafuri._con.Open(); }
            catch { }
            MySqlCommand cmd = Grafuri._con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `Intrebari` WHERE ID="+ID.Text;

            try { cmd.ExecuteNonQuery(); Grafuri._con.Close();
                MessageBox.Show("Succes", "Stergere reusita!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erroare", "Stergere nereusita!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //------------End Mouse Move Zone---------//
    }
}
