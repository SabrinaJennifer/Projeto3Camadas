using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camadas
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela;
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaFornecedor
            {
                TopLevel = false,
                Dock=DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }
    }
}
