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

namespace Clientes
{
    class clsClientes
    {
        #region Instância das Classes
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsClientes

        #region Métodos da Classe clsClientes - FUNÇÕES
        //***************
        //*** Funções ***
        //***************
        public DataTable CarregarGrid(string BuscarPor, string ProcurarEm)
        {
            string Comando_SQL;

            //*** Monta o Comando SQL de Busca na Tabela de Clientes ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "cliente_sequencial, ";
            Comando_SQL = Comando_SQL + "cliente_nome, ";
            Comando_SQL = Comando_SQL + "cliente_cpf, ";
            Comando_SQL = Comando_SQL + "cliente_logradouro, ";
            Comando_SQL = Comando_SQL + "cliente_numero_residencia, ";
            Comando_SQL = Comando_SQL + "cliente_complemento, ";
            Comando_SQL = Comando_SQL + "cliente_bairro, ";
            Comando_SQL = Comando_SQL + "cliente_ponto_referencia, ";
            Comando_SQL = Comando_SQL + "cliente_cep, ";
            Comando_SQL = Comando_SQL + "cliente_telefone, ";
            Comando_SQL = Comando_SQL + "IF(cliente_status = '1','Ativo','Inativo') AS cliente_status ";
            Comando_SQL = Comando_SQL + "FROM clientes ";

            //*** Se for  Selecionado alguma Busca, o Comando sofrefá um acrescento de outros Comandos SQL ***
            //*** O Método TRIM (Função Trim) Remove os espaços em Branco do Início e do Final, Ele não
            //*** remove os espaços da parte central ***
            if (BuscarPor.Trim() != "")
            {
                if (ProcurarEm.Trim() != "")
                {
                    if (ProcurarEm.Trim() == "Nro.Sequencial")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_sequencial = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Nome")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_nome = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "CPF")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_cpf = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Logradouro")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_logradouro = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Numero Residencia")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_numero_residencia = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Status")
                    {
                        if (BuscarPor.Trim() == "Ativo")
                        {
                            Comando_SQL = Comando_SQL + "WHERE cliente_status = '1' ";
                        }
                        else
                        {
                            Comando_SQL = Comando_SQL + "WHERE cliente_status = '0' ";
                        }
                    }

                    else if (ProcurarEm.Trim() == "Complemento")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_complemento = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Bairro")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_bairro = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "Ponto de Referência")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_ponto_referencia = '" + BuscarPor.Trim() + "' ";
                    }
                    else if (ProcurarEm.Trim() == "CEP")
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_cep = '" + BuscarPor.Trim() + "' ";
                    }
                    else
                    {
                        Comando_SQL = Comando_SQL + "WHERE cliente_telefone = '" + BuscarPor.Trim() + "' ";
                    }

                }
            }

            Comando_SQL = Comando_SQL + "ORDER BY cliente_nome";

            //*** Prepara o Data Grid ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public bool ValidaDados(frmClientes _frmClientes)
        {
            bool Resultado;
            string Comando_SQL;

            Resultado = true;

            if (_frmClientes.txtCliente_NomeTEXT.Trim() == "")
            {
                //**********************************************
                //*** Valida o Campo txtCliente_Nome ***
                //**********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Nome!");
                _frmClientes.txtCliente_NomeFOCUS();
            }
            else if (_frmClientes.txtCliente_CPFTEXT.Trim() == ".  .  -")
            {
                //**************************************
                //*** Valida o Campo txtCliente_CPF ***
                //**************************************

                Resultado = false;
                MessageBox.Show("Por Favor, Informe o CPF!");
                _frmClientes.txtCliente_CPFFOCUS();
            }

            else if (_frmClientes.txtCliente_LogradouroTEXT.Trim() == "")
            {
                //***********************************************
                //*** Valida o Campo txtCliente_Logradouro ***
                //***********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Logradouro");
                _frmClientes.txtCliente_LogradouroFOCUS();

            }

            else if (_frmClientes.txtCliente_Numero_ResidenciaTEXT.Trim() == "")
            {
                //***********************************************
                //*** Valida o Campo txtCliente_Numero_Residencia ***
                //***********************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Numero da Residência!");
                _frmClientes.txtCliente_Numero_ResidenciaFOCUS();
            }
           
             else if (_frmClientes.txtCliente_BairroTEXT.Trim() == "")
            {
                //****************************************
                //*** Valida o Campo txtCliente_Bairro ***
                //****************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Bairro!");
                _frmClientes.txtCliente_BairroFOCUS();

            }
            
            else if (_frmClientes.txtCliente_CEPTEXT.Trim() == "-")
            {
                //****************************************
                //*** Valida o Campo txtCliente_CEP ***
                //****************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o CEP!");
                _frmClientes.txtCliente_CEPFOCUS();
            }
            else if (_frmClientes.txtCliente_TelefoneTEXT.Trim() == "(  )     -")
            {
                //****************************************
                //*** Valida o Campo txtCliente_Telefone ***
                //****************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe o Telefone!!");
                _frmClientes.txtCliente_TelefoneFOCUS();
            }
            else
            {
                //********************************************** 
                //*** Verifica se o Telefone já existe na Tabela na INCLUSÃO ***
                //**********************************************

                if (_frmClientes.txtCliente_SequencialTEXT.Trim() == "")
                {
                    Comando_SQL = "SELECT ";
                    Comando_SQL = Comando_SQL + "cliente_telefone ";
                    Comando_SQL = Comando_SQL + "FROM ";
                    Comando_SQL = Comando_SQL + "clientes ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "cliente_telefone = '" +
                        clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_TelefoneTEXT.Trim()) + "' ";

                    if (objConexaoBanco.Retorna_ID(Comando_SQL, "cliente_telefone").Trim() != "")
                    {
                        Resultado = false;
                        MessageBox.Show("Este Telefone já existe, por favor, informe outro!");
                        _frmClientes.txtCliente_TelefoneFOCUS();
                    }

                }
                else
                {
                    //*** Buscar telefones iguais na ALTERAÇÃO
                    Comando_SQL = "SELECT ";
                    Comando_SQL = Comando_SQL + "cliente_telefone ";
                    Comando_SQL = Comando_SQL + "FROM ";
                    Comando_SQL = Comando_SQL + "clientes ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "cliente_telefone = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_TelefoneTEXT.Trim()) + "' ";
                    Comando_SQL = Comando_SQL + "AND ";
                    Comando_SQL = Comando_SQL + "cliente_sequencial <> " + _frmClientes.txtCliente_SequencialTEXT.Trim() + " ";


                    if (objConexaoBanco.Retorna_ID(Comando_SQL, "cliente_telefone").Trim() != "")
                    {
                        Resultado = false;
                        MessageBox.Show("Este Telefone já existe, por favor, informe outro!");
                        _frmClientes.txtCliente_TelefoneFOCUS();
                    }
                }
            }
            return Resultado;
        }
        #endregion

        #region Métodos da Classe clsClientes - ROTINAS
        //***************
        //*** Rotinas ***
        //***************

        public void LimpaCampos(frmClientes _frmClientes)
        {
            //*** Limpa os Campos para a Próxima Inserção ***
            _frmClientes.txtCliente_SequencialTEXT = "";
            _frmClientes.txtCliente_NomeTEXT = "";
            _frmClientes.txtCliente_CPFTEXT = "";
            _frmClientes.txtCliente_LogradouroTEXT = "";
            _frmClientes.txtCliente_Numero_ResidenciaTEXT = "";
            _frmClientes.txtCliente_ComplementoTEXT = "";
            _frmClientes.txtCliente_BairroTEXT = "";
            _frmClientes.txtCliente_Ponto_ReferenciaTEXT = "";
            _frmClientes.txtCliente_CEPTEXT = "";
            _frmClientes.txtCliente_TelefoneTEXT = "";
            
            //*** Trava os Campos do Formulário ***
            _frmClientes.txtCliente_NomeENABLE = false;
            _frmClientes.txtCliente_CPFENABLE = false;
            _frmClientes.txtCliente_LogradouroENABLE = false;
            _frmClientes.txtCliente_Numero_ResidenciaENABLE = false;
            _frmClientes.txtCliente_ComplementoENABLE = false;
            _frmClientes.txtCliente_BairroENABLE = false;
            _frmClientes.txtCliente_Ponto_ReferenciaENABLE = false;
            _frmClientes.txtCliente_CEPENABLE = false;
            _frmClientes.txtCliente_TelefoneENABLE = false;
            _frmClientes.rdbAtivoENABLE = false;
            _frmClientes.rdbInativoENABLE = false;

            //*** Envia o Foco para  o Campo de Busca ***
            _frmClientes.txtBuscarPorFOCUS();
        }

        public void FormataGrid(frmClientes _frmClientes)
        {
            //*** Formata o Caption da Coluna no Data Grid ***
            _frmClientes.dgvRegistros_cliente_sequencial_HEADERTEXT = "Nro. Sequencial";
            _frmClientes.dgvRegistros_cliente_nome_HEADERTEXT = "Nome";
            _frmClientes.dgvRegistros_cliente_cpf_HEADERTEXT = "CPF";
            _frmClientes.dgvRegistros_cliente_logradouro_HEADERTEXT = "Logradouro";
            _frmClientes.dgvRegistros_cliente_numero_residencia_HEADERTEXT = "Numero Residência";
            _frmClientes.dgvRegistros_cliente_complemento_HEADERTEXT = "Complemento";
            _frmClientes.dgvRegistros_cliente_bairro_HEADERTEXT = "Bairro";
            _frmClientes.dgvRegistros_cliente_ponto_referencia_HEADERTEXT = "Ponto de Referência";
            _frmClientes.dgvRegistros_cliente_cep_HEADERTEXT = "CEP";
            _frmClientes.dgvRegistros_cliente_telefone_HEADERTEXT = "Telefone";
            _frmClientes.dgvRegistros_cliente_status_HEADERTEXT = "Status";

            //*** Formata o Tamanho da Coluna no Data Grid ***
            _frmClientes.dgvRegistros_cliente_sequencial_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_nome_WIDTH = 125;
            _frmClientes.dgvRegistros_cliente_cpf_WIDTH = 110;
            _frmClientes.dgvRegistros_cliente_logradouro_WIDTH = 125;
            _frmClientes.dgvRegistros_cliente_numero_residencia_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_complemento_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_bairro_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_ponto_referencia_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_cep_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_telefone_WIDTH = 100;
            _frmClientes.dgvRegistros_cliente_status_WIDTH = 100;

        }

        public void EfetuaGravacao(frmClientes _frmClientes)
        {
            string Comando_SQL, vStatus;

            //*** Verifica qual o Radio Button foi Clicado ***
            if (_frmClientes.rdbAtivoCHECKED == true)
            {
                vStatus = "1";
            }
            else
            {
                vStatus = "0";
            }
            //*** Efetua a Validação de Dados para a Gravação na Tabela de 
            //*** Clientes ***
            if (ValidaDados(_frmClientes) == true)
            {
                //*** Verifica se o Processo de Gravação será de Inclusão ou Alteração
                if (_frmClientes.txtCliente_SequencialTEXT.Trim() == "")
                {
                    //****************************
                    //*** Processo de Inclusão ***
                    //****************************

                    //*** Prepara Comando de Inclusão ***
                    Comando_SQL = " INSERT INTO Clientes(";
                    Comando_SQL = Comando_SQL + "cliente_nome, ";
                    Comando_SQL = Comando_SQL + "cliente_cpf, ";
                    Comando_SQL = Comando_SQL + "cliente_logradouro, ";
                    Comando_SQL = Comando_SQL + "cliente_numero_residencia, ";
                    Comando_SQL = Comando_SQL + "cliente_complemento, ";
                    Comando_SQL = Comando_SQL + "cliente_bairro, ";
                    Comando_SQL = Comando_SQL + "cliente_ponto_referencia, ";
                    Comando_SQL = Comando_SQL + "cliente_cep, ";
                    Comando_SQL = Comando_SQL + "cliente_telefone, ";
                    Comando_SQL = Comando_SQL + "cliente_status) ";
                    Comando_SQL = Comando_SQL + "VALUES (";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_NomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + _frmClientes.txtCliente_CPFTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_LogradouroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_Numero_ResidenciaTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_ComplementoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_BairroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_Ponto_ReferenciaTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "'" + _frmClientes.txtCliente_CEPTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + _frmClientes.txtCliente_TelefoneTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "'" + vStatus.Trim() + "')";

                    //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Inclusão Efetuado ***
                    MessageBox.Show("Inclusão Efetuada!!!");
                    LimpaCampos(_frmClientes);
                }
                else
                {
                    //*****************************
                    //*** Processo de Alteração ***
                    //*****************************

                    //*** Prepara o Comando de Inserção
                    Comando_SQL = "UPDATE Clientes SET ";
                    Comando_SQL = Comando_SQL + "cliente_nome = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_NomeTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "cliente_cpf = '" + _frmClientes.txtCliente_CPFTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "cliente_logradouro = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_LogradouroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "cliente_numero_residencia = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_Numero_ResidenciaTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "cliente_complemento = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_ComplementoTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "cliente_bairro = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_BairroTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "cliente_ponto_referencia = '" + clsRotinasGerais.TrocaAspasSimples(_frmClientes.txtCliente_Ponto_ReferenciaTEXT.Trim()) + "', ";
                    Comando_SQL = Comando_SQL + "cliente_cep = '" + _frmClientes.txtCliente_CEPTEXT.Trim() + "', ";
                    Comando_SQL = Comando_SQL + "cliente_telefone = '" + _frmClientes.txtCliente_TelefoneTEXT.Trim() + "', "; 
                    Comando_SQL = Comando_SQL + "cliente_status = '" + vStatus.Trim() + "' ";
                    Comando_SQL = Comando_SQL + "WHERE cliente_sequencial = " + _frmClientes.txtCliente_SequencialTEXT.Trim() + " ";

                    //*** Executa o Comando Preparado Acima utilizando o Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Alteração Efetuado ***
                    MessageBox.Show("Alteração Efetuada!!!");
                    LimpaCampos(_frmClientes);
                }
                //*** Após a Alteração, realiza a Busca na Tabela de Clientes e 
                //*** Mostra o resultado no Grid ***
                _frmClientes.dgvRegistrosDATASOURCE = CarregarGrid(_frmClientes.txtBuscarPorTEXT.Trim(), _frmClientes.cmbProcurarEmTEXT.Trim());
                FormataGrid(_frmClientes);
            }
        }

        public void EfetuaExclusao(frmClientes _frmClientes)
        {
            string Comando_SQL;

            //*** Verifica se foi selecionado um registro para exclusão ***
            if (_frmClientes.txtCliente_NomeTEXT.Trim() != "")
            {
                if (MessageBox.Show("Deseja Excluir o Registro com o Nome: " +
                    _frmClientes.txtCliente_NomeTEXT.Trim() +
                    " ?", "Exclusão de Registro", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //*** Prepara o Comando de Exclusão ***
                    Comando_SQL = "DELETE FROM Clientes ";
                    Comando_SQL = Comando_SQL + "WHERE ";
                    Comando_SQL = Comando_SQL + "cliente_sequencial = '" +
                    _frmClientes.txtCliente_SequencialTEXT.Trim() + "'";

                    //*** Executa o Comando Preparado Acima utilizando o 
                    //*** Objeto do Banco ***
                    objConexaoBanco.Executar_Comando(Comando_SQL);

                    //*** Exibe a Mensagem de Exclusão Efetuada ***
                    MessageBox.Show("Exclusão Efetuada!!!");

                    LimpaCampos(_frmClientes);

                    //*** Após a Exclusão, realiza a Busca na Tabela de Clientes
                    //*** e Mostra o resultado no Grid ***
                    _frmClientes.dgvRegistrosDATASOURCE = CarregarGrid(_frmClientes.txtBuscarPorTEXT.Trim(), _frmClientes.cmbProcurarEmTEXT.Trim());
                    FormataGrid(_frmClientes);

                }
            }
            else
            {
                MessageBox.Show("Por Favor, Selecione um Registro!");
            }
        }

        public void CarregarCamposGrid(frmClientes _frmClientes)
        {
            //*** Carrega os Campos da Linha que foi Clicada ***
            _frmClientes.txtCliente_SequencialTEXT = _frmClientes.dgvRegistros_cliente_sequencial_GRIDCLICK;
            _frmClientes.txtCliente_NomeTEXT = _frmClientes.dgvRegistros_cliente_nome_GRIDCLICK;
            _frmClientes.txtCliente_CPFTEXT = _frmClientes.dgvRegistros_cliente_cpf_GRIDCLICK;
            _frmClientes.txtCliente_LogradouroTEXT = _frmClientes.dgvRegistros_cliente_logradouro_GRIDCLICK;
            _frmClientes.txtCliente_Numero_ResidenciaTEXT = _frmClientes.dgvRegistros_cliente_numero_residencia_GRIDCLICK;
            _frmClientes.txtCliente_ComplementoTEXT = _frmClientes.dgvRegistros_cliente_complemento_GRIDCLICK;
            _frmClientes.txtCliente_BairroTEXT = _frmClientes.dgvRegistros_cliente_bairro_GRIDCLICK;
            _frmClientes.txtCliente_Ponto_ReferenciaTEXT = _frmClientes.dgvRegistros_cliente_ponto_referencia_GRIDCLICK;
            _frmClientes.txtCliente_CEPTEXT = _frmClientes.dgvRegistros_cliente_cep_GRIDCLICK;
            _frmClientes.txtCliente_TelefoneTEXT = _frmClientes.dgvRegistros_cliente_telefone_GRIDCLICK;

            if (_frmClientes.dgvRegistros_cliente_status_GRIDCLICK == "Ativo")
            {
                _frmClientes.rdbAtivoCHECKED = true;
            }
            else
            {
                _frmClientes.rdbInativoCHECKED = true;
            }

            //*** Desativa o Campo que receberá o ID ***
            _frmClientes.txtCliente_SequencialENABLE = false;

            //*** Ativa o Campo de Senha ***
            _frmClientes.txtCliente_NomeENABLE = true;
            _frmClientes.txtCliente_CPFENABLE = true;
            _frmClientes.txtCliente_LogradouroENABLE = true;
            _frmClientes.txtCliente_Numero_ResidenciaENABLE = true;
            _frmClientes.txtCliente_ComplementoENABLE = true;
            _frmClientes.txtCliente_BairroENABLE = true;
            _frmClientes.txtCliente_Ponto_ReferenciaENABLE = true;
            _frmClientes.txtCliente_CEPENABLE = true;
            _frmClientes.txtCliente_TelefoneENABLE = true;
            _frmClientes.rdbAtivoENABLE = true;
            _frmClientes.rdbInativoENABLE = true;

        }
        #endregion

        #endregion
    }
}