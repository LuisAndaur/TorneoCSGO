using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_TorneoPRO
{
    public partial class Frm_Estadistica : Form
    {
        public Frm_Estadistica()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Load(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            //Frm_Home home = new Frm_Home();
            //home.Show();
            this.Close();
        }

        
    }
}
