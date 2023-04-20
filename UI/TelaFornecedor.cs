using BLL;
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
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        Fornecedor forn;

        private void CarregaTabela()
        {
            forn = new Fornecedor();
            dgvDados.DataSource = forn.Pesquisar();
        }
        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            CarregaTabela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txtId.Text);
            MessageBox.Show(forn.Excluir()?"Excluído com sucesso!":
                "Não foi possível excluir!");
            CarregaTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Id = int.Parse(txtId.Text);
            forn.Cnpj = txtCnpj.Text;
            forn.Email = txtEmail.Text;
            forn.Telefone = txtTelefone.Text;
            forn.Razao = txtRazao.Text;
            MessageBox.Show(forn.Atualizar() ? "Atualizado com sucesso!" :
                "Não foi possível atualizar!");
            CarregaTabela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            forn = new Fornecedor();
            forn.Cnpj = txtCnpj.Text;
            forn.Email = txtEmail.Text;
            forn.Telefone = txtTelefone.Text;
            forn.Razao = txtRazao.Text;
            MessageBox.Show(forn.Gravar() ? "Salvo com sucesso!" :
                "Não foi possível salvar!");
            CarregaTabela();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            forn.Id = Convert.ToInt32(dgvDados["id", e.RowIndex].Value);
            DataTable dt = forn.PesquisarId();
            txtId.Text = dt.Rows[0]["forn_Id"].ToString();
            txtCnpj.Text= dt.Rows[0]["forn_Cnpj"].ToString();
            txtEmail.Text = dt.Rows[0]["forn_Email"].ToString();
            txtRazao.Text = dt.Rows[0]["forn_Razao"].ToString();
            txtTelefone.Text = dt.Rows[0]["forn_Telefone"].ToString();
        }
    }
}
