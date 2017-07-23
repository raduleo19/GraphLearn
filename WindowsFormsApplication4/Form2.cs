using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 :Form
    {
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
        }    

       

        private async void button2_Click(object sender, EventArgs e)
        {
            await Grafuri._con.OpenAsync();
            MySqlCommand cmd = Grafuri._con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `theory` WHERE ID=" + PGID.Text;

            await cmd.ExecuteNonQueryAsync();
            await Grafuri._con.CloseAsync();
            MessageBox.Show("Succes", "Stergere reusita!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.InitialDirectory =
                             Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
                openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
            
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {


            await Grafuri._con.OpenAsync();
            MySqlCommand cmd = Grafuri._con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Theory (IMG) VALUES(@file)";
            cmd.Parameters.AddWithValue("@file", File.ReadAllBytes(textBox1.Text));
            await cmd.ExecuteNonQueryAsync();
            await Grafuri._con.CloseAsync();
            MessageBox.Show("Succes", "Adaugare reusita!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
