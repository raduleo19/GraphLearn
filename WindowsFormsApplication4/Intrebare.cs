using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Intrebare :UserControl
    {

        string RS;
        public Intrebare()
        {
        InitializeComponent();
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string RS_Query
        {
            get
            {
            return RS;
            }
            set
            {
                RS = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string ID_Query
        {
            get
            {
                return IDBox.Text;
            }
            set
            {
                IDBox.Text = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string R1_Query
        {
            get
            {
                return R1Box.Text;
            }
            set
            {
                R1Box.Text = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string R2_Query
        {
            get
            {
                return R2Box.Text;
            }
            set
            {
                R2Box.Text = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string R3_Query
        {
            get
            {
                return R3Box.Text;
            }
            set
            {
                R3Box.Text = value;
            }
        }
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string R4_Query
        {
            get
            {
                return R4Box.Text;
            }
            set
            {
                R4Box.Text = value;
            }
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string EN_Query
        {
            get
            {
                return ENBox.Text;
            }
            set
            {
                ENBox.Text = value;
            }
        }
      
        public int Ck()
        {
          
                if(R1Box.Checked == true && RS == "1")
                    return 1;
                if(R2Box.Checked == true && RS == "2")
                    return 1;
                if(R3Box.Checked == true && RS == "3")
                    return 1;
                if(R4Box.Checked == true && RS == "4")
                    return 1;

                return 0;
            
        }

        public void Dck()
        {

            R1Box.Checked = false;
        R2Box.Checked = false;
        R3Box.Checked = false;
        R4Box.Checked = false;


        }

    }
}
