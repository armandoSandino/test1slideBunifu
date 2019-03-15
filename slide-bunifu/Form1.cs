using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide_bunifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bib_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bib_menu_Click(object sender, EventArgs e)
        {
            //f1 es nuestro panel
            if (panel_izquierdo.Width == 50)
            {
                panel_izquierdo.Visible = false;
                panel_izquierdo.Width = 280;
                PanelTransicion.ShowSync(panel_izquierdo);
                LogoTransicion.ShowSync(pictureBox1_logo);
            }else {
                LogoTransicion.Hide( pictureBox1_logo );
                panel_izquierdo.Visible = false;
                panel_izquierdo.Width = 50;
                PanelTransicion.ShowSync( panel_izquierdo );
            }
        }
        

        private void bft_service_Click(object sender, EventArgs e)
        {

        }

        private void bfb_home_Click(object sender, EventArgs e)
        {

        }

        private void bfb_contact_Click(object sender, EventArgs e)
        {

        }

        private void bfb_comunity_Click(object sender, EventArgs e)
        {

        }

        private void bfn_blog_Click(object sender, EventArgs e)
        {

        }
    }
}
