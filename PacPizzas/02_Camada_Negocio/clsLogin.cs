using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************************
//*** Habilita as Referências (Namespace) a serem utilizadas ***
//**************************************************************
//*** A palavra-chave de namespace (Referência) é usada para
//*** declarar um escopo que contém um conjunto de objetos
//*** relacionados. Você pode usar um namespace para organizar
//*** elementos de código e para criar globalmente tipos 
//*** exclusivos.
using System.Windows.Forms; // Classe de Formulários
using System.Data; // Classe de Dados
using MySql.Data.MySqlClient; // Biblioteca para Acessar o MySQL
using RotinasGerais; // Este é o Módulo de Visão Global
using ConexaoBanco; // Esta é a Classe de Conexão com o Bando de Dados
using PacPizzas; // Esta é a classe Geral do Projeto, onde estão os formulários 



namespace Login
{
    class clsLogin
    {
        #region Instância das Classes
        //*** Instância os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsLogin

        #region Métodos da Classe clsLogin - FUNÇÕES
        //***************
        //*** Funções ***
        //***************

        public bool ValidaDados(frmLogin _frmLogin)
        {
            //*** Declara a Variável de Retorno ***
            bool Resultado;

            //*** Inicializa a Variável de Retorno ***
            Resultado = true;

            //*** O Método(Função) TRIM remove os espaços em Branco do 
            //*** Inicio e do Final, ele não remove os espaços do meio ***
            if (_frmLogin.txtLoginTEXT.Trim() == "")
            {
                //*******************************
                //*** Valida o Campo txtLogin ***
                //*******************************

                Resultado = false;
                MessageBox.Show("Por Favor, Informe o Login do Usuário!");
                _frmLogin.txtLoginFOCUS();
            }
            else if (_frmLogin.txtSenhaTEXT.Trim() == "")
            {

                //*******************************
                //*** Valida o Campo txtSenha ***
                //*******************************

                Resultado = false;
                MessageBox.Show("Por favor, Informe a Senha do Usuário!");
                _frmLogin.txtSenhaFOCUS();
            }

            return Resultado;

        }
        #endregion
        #region Métodos da Classe clsLogin - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void EfetuaLogin(frmLogin _frmLogin)
        {
            string Comando_SQL, vStatus;

            //*** Efetua a Validação de Dados para efetuar o Login ***
            if (ValidaDados(_frmLogin) == true)
            {
                //*** Retorna o ID da Procura na Tabela Usuários ***
                Comando_SQL = "SELECT * FROM usuarios ";
                Comando_SQL = Comando_SQL + "WHERE ";
                Comando_SQL = Comando_SQL + "usuario_login = '" + _frmLogin.txtLoginTEXT.Trim() + "' AND ";
                Comando_SQL = Comando_SQL + "usuario_Senha = '" + _frmLogin.txtSenhaTEXT.Trim() + "' ";

                vStatus = objConexaoBanco.Retorna_ID(Comando_SQL, "usuario_funcionario_cpf");

                if (vStatus != "")
                {
                    //*** Coloca o CPF do Usuário na Variável Global ***
                    clsRotinasGerais.CPFFuncionario = vStatus;

                    //*** Esconde o Formulário de Login ***
                    _frmLogin.Hide();

                    //*** Exibe o Formulário de Menu pelo processo Dialog 
                    //*** (Não deixa utilizar os Formulário que estão atrás
                    //*** enquanto o atual não for finalizado) ***
                    frmMenu _frmMenu = new frmMenu();
                    _frmMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos");

                    //*** Verifica o Número de Tentativas de Login ***
                    clsRotinasGerais.TentativasLogin = clsRotinasGerais.TentativasLogin + 1;

                    if (clsRotinasGerais.TentativasLogin == 3)
                    {
                        MessageBox.Show("Número de tentativa esgotado. A aplicação será encerrada!");

                        //*** Encerra a Aplicação caso as Tentativas sejam esgotadas ***
                        Application.Exit();
                    }
                }
            }
        }
        #endregion
        #endregion
    }
}