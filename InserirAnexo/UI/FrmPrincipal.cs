using InserirAnexo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirAnexo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_InserirAnexos_Click(object sender, EventArgs e)
        {
            FrmInserirAnexos anexos = new FrmInserirAnexos();
            anexos.Show();
        }
    }
}
