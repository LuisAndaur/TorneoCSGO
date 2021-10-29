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
    public partial class Frm_ModalABM : Form
    {
        public Frm_ModalABM()
        {
            InitializeComponent();
        }
        private void Frm_ModalABM_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
