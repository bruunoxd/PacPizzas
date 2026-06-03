using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacPizzas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Verifica se o Usuário realmente quer sair do 
            //*** Sistema ***
            if (MessageBox.Show("Deseja realmente sair do Sistema?", "Encerrar o Sistema", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            //*** Encerra a Aplicação ***
                Application.Exit();
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de Usuários pelo
            //*** processo Diadlog (Não deixa utilizar os formulários
            //*** que estão atrás enquanto o atual não for finalizado)
            frmUsuarios _frmUsuarios = new frmUsuarios();
            _frmUsuarios.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de 
            //*** Clientes pelo Processo Dialog ( Não deixa
            //*** utilizar os Formulários que estão atrás
            //*** enquanto o atual não for finalizado) ***
            frmClientes _frmClientes = new frmClientes();
            _frmClientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de 
            //*** Produtos pelo Processo Dialog ( Não deixa
            //*** utilizar os Formulários que estão atrás
            //*** enquanto o atual não for finalizado) ***
            frmProdutos _frmProdutos = new frmProdutos();
            _frmProdutos.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de 
            //*** Funcionários pelo Processo Dialog ( Não deixa
            //*** utilizar os Formulários que estão atrás
            //*** enquanto o atual não for finalizado) ***
            frmFuncionarios _frmFuncionarios = new frmFuncionarios();
            _frmFuncionarios.ShowDialog();
        }

        private void faturamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Relatório pelo processo Dialog 
            //*** (Não deixa utilizar os formulários que estão atrás enquanto o atual não for finalizado) ***
            frmRelatorioPeriodo _frmRelatorioPeriodo = new frmRelatorioPeriodo();
            _frmRelatorioPeriodo.ShowDialog();
        }

         //*** Referência Botão Ajuda
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Referência no Manual Pac Pizzas" + Convert.ToChar(13) + Convert.ToChar(10) +
               "Pagina: ");
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de 
            //*** Pedidos pelo Processo Dialog ( Não deixa
            //*** utilizar os Formulários que estão atrás
            //*** enquanto o atual não for finalizado) ***
            frmPedido _frmPedido = new frmPedido();
            _frmPedido.ShowDialog();
        }

        private void entregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de 
            //*** Entregas pelo Processo Dialog ( Não deixa
            //*** utilizar os Formulários que estão atrás
            //*** enquanto o atual não for finalizado) ***
            frmEntregas _frmEntregas = new frmEntregas();
            _frmEntregas.ShowDialog();
        }

        private void pedidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //*** Exibe o Formulário de Cadastro de 
            //*** Itens pelo Processo Dialog ( Não deixa
            //*** utilizar os Formulários que estão atrás
            //*** enquanto o atual não for finalizado) ***
            frmVisualizar _frmVisualizar = new frmVisualizar();
            _frmVisualizar.ShowDialog();
        }
    }
}


