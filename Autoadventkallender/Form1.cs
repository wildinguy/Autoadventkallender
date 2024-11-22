using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoadventkallender
{
    public partial class Form1 : Form
    {
        PictureBox m_offeneKarte1 = null;

        public Form1()
        {
            InitializeComponent();
            LadenBilder();
        }

        void LadenBilder()
        {
            foreach (Control control in this.Controls)
            {

                if (control is PictureBox pictureBox)
                {
                    
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    
                    try
                    {
                        pictureBox.Image = Image.FromFile(@".\Pictures\Christmasrückseite.png");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Laden des Bildes: {ex.Message}");
                    }
                }


            }


        }
    }
}
