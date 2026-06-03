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
using ConexaoBanco; // Esta é a Classe de Conexão com o Banco de Dados
using PacPizzas; // Esta é a Classe Geral do Projeto, onde estão os Formulários.

namespace Usuarios
{
    class clsUsuarios
    {
        #region Instância das Classes
        //*** Instancia os Objetos da Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsUsuarios
        #region Métodos da Classe clsUsuarios - FUNÇÕES

        //*************** 
        //*** Funções ***
        //***************

        public DataTable CarregarGrid(string BuscarPor, string ProcurarEm)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Usuarios ***
            Comando_SQL = " SELECT ";
            Comando_SQL = Comando_SQL + "usuario_login, ";
            Comando_SQL = Comando_SQL + "usuario_Senha, ";
            Comando_SQL = Comando_SQL + "usuario_funcionario_cpf ";
            Comando_SQL = Comando_SQL + "FROM Usuarios ";

            //*** Se for selecionado alguma Busca, o Comando sofrerá um 
            //*** acrescento de outros Comandos SQL. O Método TRIM
            //*** (Função TRIM) Remove os espaços em Branco do 
            //*** Início e do Final, Ele não remove os espaços da 
            //*** parte central.

            if (BuscarPor.Trim() != "")
            {
                if (ProcurarEm.Trim() != "")
                {
                    if (ProcurarEm.Trim() == "Login")
                    {
                        Comando_SQL = Comando_SQL +
                            "WHERE usuario_login LIKE '%" +
                            BuscarPor.Trim() + "%' ";
                    }
                    else 
                    { 
                       Comando_SQL = Comando_SQL + "WHERE usuario_funcionario_cpf = '" + BuscarPor.Trim() + "' ";
                    }
                }
            }

            Comando_SQL = Comando_SQL + "ORDER BY usuario_login";

            //*** Prepara o Data Grid
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public bool ValidaDados(frmUsuarios _frmUsuarios)
        {
            bool Resultado;
            string Comando_SQL;

            Resultado = true;

            if (_frmUsuarios.txtUsuario_LoginTEXT.Trim() == "")
            {
                //*** ***********************************
                //*** Valida o Campo txtUsuario_Login ***
                //***************************************

                Resultado = false;
                MessageBox.Show("Por favor, Informe o Login!");
                _frmUsuarios.txtUsuario_LoginFOCUS();
            }

            else if (_frmUsuarios.txtUsuario_SenhaTEXT.Trim() == "")
            {
                //*************************************** 
                //*** Valida o Campo txtUsuario_Senha ***
                //***************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Senha!");
                _frmUsuarios.txtUsuario_SenhaFOCUS();
            }

            else if (_frmUsuarios.cmbUsuarioCPFTEXT.Trim() == "")
            {
                //*************************************** 
                //*** Valida o Campo cmbUsuarioCPF ***
                //***************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o CPF!");
                _frmUsuarios.cmbUsuarioCPFFOCUS();
            }
            
            else
            {
                //***********************************************
                //*** Verifica se o Login já existe na Tabela ***
                //***********************************************

                if (_frmUsuarios.txtUsuario_LoginENABLE == true)
                {
                    Comando_SQL = "SELECT ";
                    Comando_SQL = Comando_SQL + "usuario_login ";
                    Comando_SQL = Comando_SQL + "FROM ";
                    Comando_SQL = Comando_SQL + "usuarios ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "usuario_login =  '" +
                    clsRotinasGerais.TrocaAspasSimples(_frmUsuarios.txtUsuario_LoginTEXT.Trim()) + "'";


                    if (objConexaoBanco.Retorna_ID(Comando_SQL, "usuario_login").Trim() != "")
                    {
                        Resultado = false;
                        MessageBox.Show("Este Login já existe, por favor, informe outro!");
                        _frmUsuarios.txtUsuario_LoginFOCUS();
                    }
                }
            }

            return Resultado;
        }

        public string RetornaCPFComboFuncionario(string cpfRecebido)
        {
            string RetornaCPF;

            RetornaCPF = cpfRecebido.Substring(0, 14);
            RetornaCPF = RetornaCPF.Trim();

            return RetornaCPF;
        }
        #endregion

        #region Métodos da Classe clsUsuarios - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void LimpaCampos(frmUsuarios _frmUsuarios)
        {
            //** Limpa os Campos para a próximo Inserção ***
            _frmUsuarios.txtUsuario_LoginTEXT = "";
            _frmUsuarios.txtUsuario_SenhaTEXT = "";
            _frmUsuarios.cmbUsuarioCPFTEXT = "";
            //
           
            
            //*** Trava os Campos do Formulário ***
            _frmUsuarios.txtUsuario_LoginENABLE = false;
            _frmUsuarios.txtUsuario_SenhaENABLE = false;

            //*** Envia o Foco para o Campo de Busca ***
            _frmUsuarios.txtBuscarPor_FOCUS();
        }


        public void FormataGrid(frmUsuarios _frmUsuarios)
        {
            //*** Formata o Caption da Coluna do Data Grid ***
            _frmUsuarios.dgvRegistros_Login_HEADERTEX = "Login";
            _frmUsuarios.dgvRegistros_Senha_HEADERTEX = "Senha";
            _frmUsuarios.dgvRegistros_usuario_funcionario_cpf_HEADERTEXT = "CPF";

            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmUsuarios.dgvRegistros_Login_WIDTH = 400;
            _frmUsuarios.dgvRegistros_usuario_funcionario_cpf_WIDTH = 400;

            //*** Por questões de segurança, deixa a coluna de Senha Invisível ***
            _frmUsuarios.dgvRegistros_Senha_VISIBLE = false;
        }

        public void EfetuaGravacao(frmUsuarios _frmUsuarios)
        {
            string Comando_SQL;

            //*** Efetua a Validação da Dados para a Gravação na Tabela
            //*** de Usuarios ***
            if (ValidaDados(_frmUsuarios) == true)
            {
                //*** Verifica se o Processo de Gravação será de Inclusão
                //*** ou Alteração ***
                if (_frmUsuarios.txtUsuario_LoginENABLE == true)
                {
                    //****************************
                    //*** Processo de Inclusão ***
                    //****************************

                    //*** Prepara Comando de Inclusão ***
                    Comando_SQL = "INSERT INTO Usuarios(";
                    Comando_SQL = Comando_SQL + "usuario_login, ";
                    Comando_SQL = Comando_SQL + "usuario_senha, ";
                    Comando_SQL = Comando_SQL + "usuario_funcionario_cpf) ";
                    Comando_SQL = Comando_SQL + "VALUES (";
                    Comando_SQL = Comando_SQL + "'" +
                        clsRotinasGerais.TrocaAspasSimples(_frmUsuarios.txtUsuario_LoginTEXT) + "', ";
                    Comando_SQL = Comando_SQL + "'" +
                        clsRotinasGerais.TrocaAspasSimples(_frmUsuarios.txtUsuario_SenhaTEXT) + "', ";
                    Comando_SQL = Comando_SQL + "'" +
                        RetornaCPFComboFuncionario(_frmUsuarios.cmbUsuarioCPFTEXT) + "') ";
                    //*** Executa o Comando Preparado Acima utilizando o 
                    //*** Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Inclusão Efetuado ***
                    MessageBox.Show("Inclusão Efetuada!!!");
                    LimpaCampos(_frmUsuarios);
                }
                else
                {
                    //***************************** 
                    //*** Processo de Alteração ***
                    //*****************************

                    //*** Prepara o Comando de Inserção ***
                    Comando_SQL = "UPDATE usuarios SET ";
                    Comando_SQL = Comando_SQL + "usuario_senha = '" +
                        clsRotinasGerais.TrocaAspasSimples(_frmUsuarios.txtUsuario_SenhaTEXT) + "', ";
                    Comando_SQL = Comando_SQL + "usuario_funcionario_cpf = '" +
                     RetornaCPFComboFuncionario(_frmUsuarios.cmbUsuarioCPFTEXT) + "' ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "usuario_login = '" +
                        clsRotinasGerais.TrocaAspasSimples(_frmUsuarios.txtUsuario_LoginTEXT) + "' ";


                    //*** Executa o Comando Preparado Acima utilizando o 
                    //*** Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Inclusão Efetuado ***
                    MessageBox.Show("Alteração Efetuada!!!");
                    LimpaCampos(_frmUsuarios);
                }

                //*** Após a Alteração, realiza a Busca na Tabela de Usuarios e 
                //*** Mostra o resultado no Grid ***
                _frmUsuarios.dgvRegistrosDATASOURCE = CarregarGrid(_frmUsuarios.txtBuscarPorTEXT.Trim(), _frmUsuarios.cmbProcurarEmTEXT.Trim());
                FormataGrid(_frmUsuarios);

                //*** Desativa o Campo para Digitação ***
                _frmUsuarios.txtUsuario_LoginENABLE = false;
                _frmUsuarios.txtUsuario_SenhaENABLE = false;
                _frmUsuarios.cmbUsuarioCPFENABLE = false;
            }

        }

        public void EfetuaExclusao(frmUsuarios _frmUsuarios)
        {
            string Comando_SQL;

            //*** Verifica se foi selecionado um registro para 
            //*** exclusão.
            if (_frmUsuarios.txtUsuario_LoginTEXT.Trim() != "")
            {
                if (MessageBox.Show("Deseja Exlcluir o Registro de Login: " +
                    _frmUsuarios.txtUsuario_LoginTEXT.Trim() +
                    " ?",
                    "Exclusão de Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //*** Prepara Comando de Exclusão ***
                    Comando_SQL = "DELETE FROM Usuarios ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "usuario_login = '" +
                        _frmUsuarios.txtUsuario_LoginTEXT.Trim() + "'";

                    //*** Executa o Comando Preparado Acima utilizando o 
                    //*** Objeto do Banco.
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Exlusão Efetuada ***
                    MessageBox.Show("Exclusão Efetuada!!!");

                    LimpaCampos(_frmUsuarios);


                    //*** Após a Exclusão, realiza a Busca na Tabela de Usuários e
                    //*** e Mostra o resultado no Grid ***
                    _frmUsuarios.dgvRegistrosDATASOURCE = CarregarGrid(_frmUsuarios.txtBuscarPorTEXT.Trim(), _frmUsuarios.cmbProcurarEmTEXT.Trim());
                    FormataGrid(_frmUsuarios);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um Registro!");
            }
        }


        public void CarregaCamposGrid(frmUsuarios _frmUsuarios)
        {
            //*** Carrega os campos da Linha que foi Clicada ***
            _frmUsuarios.txtUsuario_LoginTEXT = _frmUsuarios.dgvRegistros_usuario_login_GRIDCLICK;
            _frmUsuarios.txtUsuario_SenhaTEXT = _frmUsuarios.dgvRegistros_usuario_senha_GRIDCLICK;
            _frmUsuarios.cmbUsuarioCPFLOCALIZA(_frmUsuarios.dgvRegistros_usuario_funcionario_cpf_GRIDCLICK);

            //*** Desativa os Campos da Linha que foi Clicada ***                
            _frmUsuarios.txtUsuario_LoginENABLE = false;

            //*** Ativa o Campo de Senha ***
            _frmUsuarios.txtUsuario_SenhaENABLE = true;
        }

        public void CarregaComboFuncionarios(frmUsuarios _frmUsuarios)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Clientes ***
            Comando_SQL = "SELECT CONCAT(funcionario_cpf,'-',funcionario_nome,' ',funcionario_sobrenome) AS funcionario_cpf_nome FROM funcionarios ORDER BY funcionario_nome";

            //*** Prepara o Data Adapter ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            _frmUsuarios.cmbUsuarioCPFDATASOURCE = ds.Tables[0];
            _frmUsuarios.cmbUsuarioCPFDISPLAYMEMBER = "funcionario_cpf_nome";
            _frmUsuarios.cmbUsuarioCPFVALUEMEMBER = "funcionario_cpf_nome";
        }

        #endregion
        #endregion
    }
}
