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
using PacPizzas; // Esta é a Classe Geral do Projeto, onde estão os Formulários

namespace Funcionarios
{
    class clsFuncionarios
    {
        #region Instância das Classes
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsFuncionarios

        #region Métodos da Classe clsFuncionarios - FUNÇÕES
        //***************
        //*** Funções ***
        //***************
        public DataTable CarregarGrid(string BuscarPor, string ProcurarEm)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Funcionarios ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "funcionario_cpf, ";
            Comando_SQL = Comando_SQL + "funcionario_nome, ";
            Comando_SQL = Comando_SQL + "funcionario_sobrenome, ";
            Comando_SQL = Comando_SQL + "funcionario_rg, ";
            Comando_SQL = Comando_SQL + "funcionario_logradouro, ";
            Comando_SQL = Comando_SQL + "funcionario_numero_residencia, ";
            Comando_SQL = Comando_SQL + "funcionario_cidade, ";
            Comando_SQL = Comando_SQL + "funcionario_bairro, ";
            Comando_SQL = Comando_SQL + "funcionario_cep, ";
            Comando_SQL = Comando_SQL + "funcionario_estado, ";
            Comando_SQL = Comando_SQL + "funcionario_telefone, ";
            Comando_SQL = Comando_SQL + "funcionario_celular, ";
            Comando_SQL = Comando_SQL + "funcionario_funcao, ";
            Comando_SQL = Comando_SQL + "IF(LENGTH(funcionario_salario) < 7,LPAD(FORMAT(funcionario_salario,2),7,' '),LPAD(FORMAT(funcionario_salario,2),8,' ')) AS funcionario_salario, ";// Formatar o valor Unitário para não deslocar para esquerda
            Comando_SQL = Comando_SQL + "DATE_FORMAT(funcionario_admissao, '%d/%m/%Y') AS funcionario_admissao, ";
            Comando_SQL = Comando_SQL + "DATE_FORMAT(funcionario_demissao, '%d/%m/%Y') AS funcionario_demissao ";
            Comando_SQL = Comando_SQL + "FROM funcionarios ";

            //*** Se for  Selecionado alguma Busca, o Comando sofrefá um acrescento de outros Comandos SQL ***
            //*** O Método TRIM (Função Trim) Remove os espaços em Branco do Início e do Final, Ele não
            //*** remove os espaços da parte central ***
            if (BuscarPor.Trim() != "")
            {
                if (ProcurarEm.Trim() != "")
                {
                    if (ProcurarEm.Trim() == "CPF")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_cpf = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Nome")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_nome = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Sobrenome")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_sobrenome = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "RG")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_rg = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Logradouro")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_logradouro = '" + BuscarPor.Trim() + "' ";
                    }

                    else if (ProcurarEm.Trim() == "Nro. Residência")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_numero_residencia =  '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Cidade")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_cidade = '" + BuscarPor.Trim() + "' ";
                    }
                    
                    else if (ProcurarEm.Trim() == "Bairro")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_bairro = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "CEP")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_cep = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Estado")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_estado = '" + BuscarPor.Trim() + "' ";
                    }

                    else if (ProcurarEm.Trim() == "Tel. Fixo")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_telefone = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Tel. Celular")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_celular = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Função")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_funcao = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Salário")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_salario = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Data de Admissão")
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_admissao =  '" + clsRotinasGerais.Inverte_Data(BuscarPor.Trim()) + "' ";
                    }
                    else
                    {
                        Comando_SQL = Comando_SQL + "WHERE funcionario_demissao =  '" + clsRotinasGerais.Inverte_Data(BuscarPor.Trim()) + "' ";
                    }
                    
                }
            }

            Comando_SQL = Comando_SQL + "ORDER BY funcionario_nome";

            //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public bool ValidaDados(frmFuncionarios _frmFuncionarios)
        {
            bool Resultado;
            string Comando_SQL;

            Resultado = true;

            if (_frmFuncionarios.txtFuncionario_CPFTEXT.Trim() == ".   .   -")
            {
                //**************************************
                //*** Valida o Campo txtFuncionario_CPF ***
                //**************************************

                Resultado = false;
                MessageBox.Show("Por Favor, Informe o CPF!");
                _frmFuncionarios.txtFuncionario_CPFFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_NomeTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Nome ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Nome!");
                _frmFuncionarios.txtFuncionario_NomeFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_SobrenomeTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Sobrenome ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Sobrenome!");
                _frmFuncionarios.txtFuncionario_SobrenomeFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_RGTEXT.Trim() == ".   .   -")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_RG ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o RG!");
                _frmFuncionarios.txtFuncionario_RGFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_LogradouroTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Logradouro ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Logradouro!");
                _frmFuncionarios.txtFuncionario_LogradouroFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_Numero_ResidenciaTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Numero_Residencia ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Numero da Residência!");
                _frmFuncionarios.txtFuncionario_Numero_ResidenciaFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_CidadeTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Cidade ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Cidade!");
                _frmFuncionarios.txtFuncionario_CidadeFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_BairroTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Bairro ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Bairro!");
                _frmFuncionarios.txtFuncionario_BairroFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_CEPTEXT.Trim() == "-")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_CEP ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o CEP!");
                _frmFuncionarios.txtFuncionario_CEPFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_TelefoneTEXT.Trim() == "(  )    -")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Telefone ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Telefone!");
                _frmFuncionarios.txtFuncionario_TelefoneFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_CelularTEXT.Trim() == "(  )     -")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Celular ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Celular!");
                _frmFuncionarios.txtFuncionario_CelularFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_FuncaoTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Funcao ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Função!");
                _frmFuncionarios.txtFuncionario_FuncaoFOCUS();
            }
            else if (_frmFuncionarios.txtFuncionario_SalarioTEXT.Trim() == "R$ .   ,")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Salario ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Salário!");
                _frmFuncionarios.txtFuncionario_SalarioFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_AdmissaoTEXT.Trim() == "/  /")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Admissao ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Data de Admissão!");
                _frmFuncionarios.txtFuncionario_AdmissaoFOCUS();
            }

            else if (_frmFuncionarios.txtFuncionario_DemissaoTEXT.Trim() == "/  /")
            {
                //**********************************************
                //*** Valida o Campo txtFuncionario_Dedmissao ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Data de Demissão!");
                _frmFuncionarios.txtFuncionario_DemissaoFOCUS();
            }
            else
            {
                //********************************************** 
                //*** Verifica se o CPF já existe na Tabela ***
                //**********************************************

                if (_frmFuncionarios.txtFuncionario_CPFENABLE == true)
                {
                    Comando_SQL = "SELECT ";
                    Comando_SQL = Comando_SQL + "funcionario_cpf ";
                    Comando_SQL = Comando_SQL + "FROM ";
                    Comando_SQL = Comando_SQL + "funcionarios ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "funcionario_cpf = '" +
                       _frmFuncionarios.txtFuncionario_CPFTEXT.Trim() + "' ";

                    if (objConexaoBanco.Retorna_ID(Comando_SQL, "funcionario_CPF").Trim() != "")
                    {
                        Resultado = false;
                        MessageBox.Show("Este CPF já existe, por favor, informe outro!");
                        _frmFuncionarios.txtFuncionario_CPFFOCUS();
                    }

                }
            }
            return Resultado;
        }
        #endregion

        #region Métodos da Classe Funcionarios - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void LimpaCampos(frmFuncionarios _frmFuncionarios)
        {
            //*** Limpa os Campos para a Próxima Inserção ***
            _frmFuncionarios.txtFuncionario_CPFTEXT = "";
            _frmFuncionarios.txtFuncionario_NomeTEXT = "";
            _frmFuncionarios.txtFuncionario_SobrenomeTEXT = "";
            _frmFuncionarios.txtFuncionario_RGTEXT = "";
            _frmFuncionarios.txtFuncionario_LogradouroTEXT = "";
            _frmFuncionarios.txtFuncionario_Numero_ResidenciaTEXT = "";
            _frmFuncionarios.txtFuncionario_CidadeTEXT = "";
            _frmFuncionarios.txtFuncionario_BairroTEXT = "";
            _frmFuncionarios.txtFuncionario_CEPTEXT = "";
            _frmFuncionarios.cmbFuncionario_EstadoTEXT = "";
            _frmFuncionarios.txtFuncionario_TelefoneTEXT = "";
            _frmFuncionarios.txtFuncionario_CelularTEXT = "";
            _frmFuncionarios.txtFuncionario_FuncaoTEXT = "";
            _frmFuncionarios.txtFuncionario_SalarioTEXT = "";
            _frmFuncionarios.txtFuncionario_AdmissaoTEXT = "";
            _frmFuncionarios.txtFuncionario_DemissaoTEXT = "";

            //*** Trava os Campos do Formulário ***
            _frmFuncionarios.txtFuncionario_CPFENABLE = false;
            _frmFuncionarios.txtFuncionario_NomeENABLE = false;
            _frmFuncionarios.txtFuncionario_SobrenomeENABLE = false;
            _frmFuncionarios.txtFuncionario_RGENABLE = false;
            _frmFuncionarios.txtFuncionario_LogradouroENABLE = false;
            _frmFuncionarios.txtFuncionario_Numero_ResidenciaENABLE = false;
            _frmFuncionarios.txtFuncionario_CidadeENABLE = false;
            _frmFuncionarios.txtFuncionario_BairroENABLE = false;
            _frmFuncionarios.txtFuncionario_CEPENABLE = false;
            _frmFuncionarios.cmbFuncionario_EstadoENABLE = false;
            _frmFuncionarios.txtFuncionario_TelefoneENABLE = false;
            _frmFuncionarios.txtFuncionario_CelularENABLE = false;
            _frmFuncionarios.txtFuncionario_FuncaoENABLE = false;
            _frmFuncionarios.txtFuncionario_SalarioENABLE = false;
            _frmFuncionarios.txtFuncionario_AdmissaoENABLE = false;
            _frmFuncionarios.txtFuncionario_DemissaoENABLE = false;

            //*** Envia o Foco para  o Campo de Busca ***
            _frmFuncionarios.txtBuscarPorFOCUS();
        }

        public void FormataGrid(frmFuncionarios _frmFuncionarios)
        {
            //*** Formata o Caption da Coluna no Data Grid ***
            _frmFuncionarios.dgvRegistros_funcionario_cpf_HEADERTEXT = "CPF";
            _frmFuncionarios.dgvRegistros_funcionario_nome_HEADERTEXT = "Nome";
            _frmFuncionarios.dgvRegistros_funcionario_sobrenome_HEADERTEXT = "Sobrenome";
            _frmFuncionarios.dgvRegistros_funcionario_rg_HEADERTEXT = "RG";
            _frmFuncionarios.dgvRegistros_funcionario_logradouro_HEADERTEXT = "Logradouro";
            _frmFuncionarios.dgvRegistros_funcionario_numero_residencia_HEADERTEXT = "Nro. Residência";
            _frmFuncionarios.dgvRegistros_funcionario_cidade_HEADERTEXT = "Cidade";
            _frmFuncionarios.dgvRegistros_funcionario_bairro_HEADERTEXT = "Bairro";
            _frmFuncionarios.dgvRegistros_funcionario_cep_HEADERTEXT = "CEP";
            _frmFuncionarios.dgvRegistros_funcionario_estado_HEADERTEXT = "Estado";
            _frmFuncionarios.dgvRegistros_funcionario_telefone_HEADERTEXT = "Telefone";
            _frmFuncionarios.dgvRegistros_funcionario_celular_HEADERTEXT = "Celular";
            _frmFuncionarios.dgvRegistros_funcionario_funcao_HEADERTEXT = "Função";
            _frmFuncionarios.dgvRegistros_funcionario_salario_HEADERTEXT = "Salário";
            _frmFuncionarios.dgvRegistros_funcionario_admissao_HEADERTEXT = "Data de Admissão";
            _frmFuncionarios.dgvRegistros_funcionario_demissao_HEADERTEXT = "Data de Demissão";

            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmFuncionarios.dgvRegistros_funcionario_cpf_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_nome_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_sobrenome_WIDTH = 125;
            _frmFuncionarios.dgvRegistros_funcionario_rg_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_logradouro_WIDTH = 125;
            _frmFuncionarios.dgvRegistros_funcionario_numero_residencia_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_cidade_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_bairro_WIDTH = 125;
            _frmFuncionarios.dgvRegistros_funcionario_cep_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_estado_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_telefone_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_celular_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_funcao_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_salario_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_admissao_WIDTH = 100;
            _frmFuncionarios.dgvRegistros_funcionario_demissao_WIDTH = 100;

        }

        public void EfetuaGravacao(frmFuncionarios _frmFuncionarios)
        {
            string Comando_SQL;

            //*** Efetua a Validação de Dados para a Gravação na Tabela de 
            //*** Funcionarios ***
            if (ValidaDados(_frmFuncionarios) == true)
            {
                //*** Verifica se o Processo de Gravação será de Inclusão ou Alteração
                if (_frmFuncionarios.txtFuncionario_CPFENABLE == true)
                {
                    //****************************
                    //*** Processo de Inclusão ***
                    //****************************

                    //*** Prepara Comando de Inclusão ***
                    Comando_SQL = " INSERT INTO Funcionarios(";
                    Comando_SQL = Comando_SQL + "funcionario_cpf, ";
                    Comando_SQL = Comando_SQL + "funcionario_nome, ";
                    Comando_SQL = Comando_SQL + "funcionario_sobrenome, ";
                    Comando_SQL = Comando_SQL + "funcionario_rg, ";
                    Comando_SQL = Comando_SQL + "funcionario_logradouro, ";
                    Comando_SQL = Comando_SQL + "funcionario_numero_residencia, ";
                    Comando_SQL = Comando_SQL + "funcionario_cidade, ";
                    Comando_SQL = Comando_SQL + "funcionario_bairro, ";
                    Comando_SQL = Comando_SQL + "funcionario_cep, ";
                    Comando_SQL = Comando_SQL + "funcionario_estado, ";
                    Comando_SQL = Comando_SQL + "funcionario_telefone, ";
                    Comando_SQL = Comando_SQL + "funcionario_celular, ";
                    Comando_SQL = Comando_SQL + "funcionario_funcao, ";
                    Comando_SQL = Comando_SQL + "funcionario_salario, ";
                    Comando_SQL = Comando_SQL + "funcionario_admissao, ";
                    Comando_SQL = Comando_SQL + "funcionario_demissao) ";
                    Comando_SQL = Comando_SQL + "VALUES (";
                    Comando_SQL = Comando_SQL + "'" + _frmFuncionarios.txtFuncionario_CPFTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_NomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_SobrenomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + _frmFuncionarios.txtFuncionario_RGTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_LogradouroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_Numero_ResidenciaTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_CidadeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_BairroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + _frmFuncionarios.txtFuncionario_CEPTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + _frmFuncionarios.cmbFuncionario_EstadoTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_TelefoneTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_CelularTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_FuncaoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaVirgulaPonto(clsRotinasGerais.RemoveCaracteres(clsRotinasGerais.RemoveCaracteres(_frmFuncionarios.txtFuncionario_SalarioTEXT.Trim(), "R$"),".")) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.Inverte_Data(_frmFuncionarios.txtFuncionario_AdmissaoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.Inverte_Data(_frmFuncionarios.txtFuncionario_DemissaoTEXT.Trim()) + "')";

                    //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Inclusão Efetuado ***
                    MessageBox.Show("Inclusão Efetuada!!!");
                    LimpaCampos(_frmFuncionarios);
                }
                else
                {
                    //*****************************
                    //*** Processo de Alteração ***
                    //*****************************

                    //*** Prepara o Comando de Inserção
                    Comando_SQL = "UPDATE Funcionarios SET ";
                    Comando_SQL = Comando_SQL + "funcionario_nome = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_NomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_sobrenome = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_SobrenomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_rg = '" + _frmFuncionarios.txtFuncionario_RGTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_logradouro = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_LogradouroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_numero_residencia = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_Numero_ResidenciaTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_cidade = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_CidadeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_bairro = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_BairroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_cep = '" + _frmFuncionarios.txtFuncionario_CEPTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_estado = '" + _frmFuncionarios.cmbFuncionario_EstadoTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_telefone = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_TelefoneTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_celular = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_CelularTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_funcao = '" + clsRotinasGerais.TrocaAspasSimples(_frmFuncionarios.txtFuncionario_FuncaoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_salario = '" + clsRotinasGerais.TrocaVirgulaPonto(clsRotinasGerais.RemoveCaracteres(clsRotinasGerais.RemoveCaracteres(_frmFuncionarios.txtFuncionario_SalarioTEXT.Trim(), "R$"), ".")) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_admissao = '" + clsRotinasGerais.Inverte_Data(_frmFuncionarios.txtFuncionario_AdmissaoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "funcionario_demissao = '" + clsRotinasGerais.Inverte_Data(_frmFuncionarios.txtFuncionario_DemissaoTEXT.Trim()) + "' ";
                    Comando_SQL = Comando_SQL + "WHERE funcionario_cpf = '" + _frmFuncionarios.txtFuncionario_CPFTEXT.Trim() + "' ";
                    
                    //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Alteração Efetuado ***
                    MessageBox.Show("Alteração Efetuada!!!");
                    LimpaCampos(_frmFuncionarios);
                }
                //*** Após a Alteração, realiza a Busca na Tabela de Funcionarios e 
                //*** Mostra o resultado no Grid ***
                _frmFuncionarios.dgvRegistrosDATASOURCE = CarregarGrid(_frmFuncionarios.txtBuscarPorTEXT.Trim(), _frmFuncionarios.cmbProcurarEmTEXT.Trim());
                FormataGrid(_frmFuncionarios);
            }
        }

        public void EfetuaExclusao(frmFuncionarios _frmFuncionarios)
        {
            string Comando_SQL;

            //*** Verifica se foi selecionado um registro para exclusão ***
            if (_frmFuncionarios.txtFuncionario_NomeTEXT.Trim() != "")
            {
                if (MessageBox.Show("Deseja Excluir o Registro com o Nome: " +
                    _frmFuncionarios.txtFuncionario_NomeTEXT.Trim() +
                    " ?", "Exclusão de Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //*** Prepara o Comando de Exclusão ***
                    Comando_SQL = "DELETE FROM Funcionarios ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "funcionario_cpf = '" +
                    _frmFuncionarios.txtFuncionario_CPFTEXT.Trim() + "'";

                    //*** Executa o Comando Preparado Acima utilizando o 
                    //*** Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Exclusão Efetuada ***
                    MessageBox.Show("Exclusão Efetuada!!!");

                    LimpaCampos(_frmFuncionarios);

                    //*** Após a Exclusão, realiza a Busca na Tabela de Funcionarios
                    //*** e Mostra o resultado no Grid ***
                    _frmFuncionarios.dgvRegistrosDATASOURCE = CarregarGrid(_frmFuncionarios.txtBuscarPorTEXT.Trim(), _frmFuncionarios.cmbProcurarEmTEXT.Trim());
                    FormataGrid(_frmFuncionarios);

                }
            }
            else
            {
                MessageBox.Show("Por Favor, Selecione um Registro!");
            }
        }

        public void CarregarCamposGrid(frmFuncionarios _frmFuncionarios)
        {
            //*** Carrega os Campos da Linha que foi Clicada ***

            _frmFuncionarios.txtFuncionario_CPFTEXT = _frmFuncionarios.dgvRegistros_funcionario_cpf_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_NomeTEXT = _frmFuncionarios.dgvRegistros_funcionario_nome_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_SobrenomeTEXT = _frmFuncionarios.dgvRegistros_funcionario_sobrenome_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_RGTEXT = _frmFuncionarios.dgvRegistros_funcionario_rg_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_LogradouroTEXT = _frmFuncionarios.dgvRegistros_funcionario_logradouro_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_Numero_ResidenciaTEXT = _frmFuncionarios.dgvRegistros_funcionario_numero_residencia_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_CidadeTEXT = _frmFuncionarios.dgvRegistros_funcionario_cidade_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_BairroTEXT = _frmFuncionarios.dgvRegistros_funcionario_bairro_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_CEPTEXT = _frmFuncionarios.dgvRegistros_funcionario_cep_GRIDCLICK;
            _frmFuncionarios.cmbFuncionario_EstadoTEXT = _frmFuncionarios.dgvRegistros_funcionario_estado_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_TelefoneTEXT = _frmFuncionarios.dgvRegistros_funcionario_telefone_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_CelularTEXT = _frmFuncionarios.dgvRegistros_funcionario_celular_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_FuncaoTEXT = _frmFuncionarios.dgvRegistros_funcionario_funcao_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_SalarioTEXT = _frmFuncionarios.dgvRegistros_funcionario_salario_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_AdmissaoTEXT = _frmFuncionarios.dgvRegistros_funcionario_admissao_GRIDCLICK;
            _frmFuncionarios.txtFuncionario_DemissaoTEXT = _frmFuncionarios.dgvRegistros_funcionario_demissao_GRIDCLICK;
            
            

            //*** Desativa o Campo que receberá o ID ***
            _frmFuncionarios.txtFuncionario_CPFENABLE = false;

            //*** Ativa o Campo de Senha ***
            _frmFuncionarios.txtFuncionario_NomeENABLE = true;
            _frmFuncionarios.txtFuncionario_SobrenomeENABLE = true;
            _frmFuncionarios.txtFuncionario_RGENABLE = true;
            _frmFuncionarios.txtFuncionario_LogradouroENABLE = true;
            _frmFuncionarios.txtFuncionario_Numero_ResidenciaENABLE = true;
            _frmFuncionarios.txtFuncionario_CidadeENABLE = true;
            _frmFuncionarios.txtFuncionario_BairroENABLE = true;
            _frmFuncionarios.txtFuncionario_CEPENABLE = true;
            _frmFuncionarios.cmbFuncionario_EstadoENABLE = true;
            _frmFuncionarios.txtFuncionario_TelefoneENABLE = true;
            _frmFuncionarios.txtFuncionario_CelularENABLE = true;
            _frmFuncionarios.txtFuncionario_FuncaoENABLE = true;
            _frmFuncionarios.txtFuncionario_SalarioENABLE = true;
            _frmFuncionarios.txtFuncionario_AdmissaoENABLE = true;
            _frmFuncionarios.txtFuncionario_DemissaoENABLE = true;   
        
        
        }
        #endregion

        #endregion
    }
}