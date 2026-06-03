using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*****************************************************
//*** Habilita as Referência (Namespace) a serem ****** 
//*** utilizadas                                 ******
//*****************************************************
//*** A palavra-chave de namespace (Referência) é usada 
//*** para declarar um escopo que contém um conjunto de
//*** objetos relacionados. Você pode usar um namespace
//*** para organizar elementos de código e para criar
//*** globalmente tipos exclusivos.
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;


namespace ConexaoBanco
{
    class clsConexaoBanco
    {
        #region Variáveis Globais
        //***************************************
        //*** Declaração de Variáveis Globais ***
        //***************************************
        public static string conexaoMySQL = ("Server=localhost; user id=root; password=bru4178@*; database=PacPizzas;");
        //public static string conexaoMySQL = ("Server=127.0.0.1; port=3306; user id=root; database=PacPizzas;");
        public static MySqlConnection objconexaoMySQL = new MySqlConnection(conexaoMySQL);
        #endregion

        #region Rotinas
        //***************
        //*** Rotinas ***
        //***************

        //*** Rotina para a Abertura de Banco de Dados ***
        public void AbrirBanco()
        {
            if (objconexaoMySQL.State == ConnectionState.Closed)
            {
                try
                {
                    objconexaoMySQL.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //*** Encerra a Aplicação ***
                    Application.Exit();
                }
            }
        }



        //*** Rotina para Fechar o Banco de Dados ***
        public void FecharBanco()
        {
            if (objconexaoMySQL.State == ConnectionState.Open)
            {
                objconexaoMySQL.Close();
            }
        }

        //*** Apenas Executa o Comando e não Traz resultado ***
        public void Executar_Comando(string ComandoSQL)
        {
            MySqlCommand objComando = new MySqlCommand(ComandoSQL, objconexaoMySQL);

            AbrirBanco();
            objComando.ExecuteNonQuery();
            FecharBanco();
        }

        #endregion

        #region Funções
        //***************
        //*** Funções ***
        //***************

        //*** Executa o Comando e Devolve o valor de um campo ***
        public string Retorna_ID(string ComandoSQL, string CampoID)
        {
            AbrirBanco();
            MySqlDataAdapter da = new MySqlDataAdapter(ComandoSQL, objconexaoMySQL);
            DataSet ds = new DataSet();
            string ValorRetorno;
            ds.Tables.Clear();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ValorRetorno = ds.Tables[0].Rows[0][CampoID].ToString();
            }
            else
            {
                ValorRetorno = "";
            }
            FecharBanco();

            return ValorRetorno;

        }

        //*** Apenas Executa o Comando e Traz o Resultado ***
        public MySqlDataReader Executar_Comando_Resultado(string ComandoSQL)
        {
            MySqlCommand objComando = new MySqlCommand(ComandoSQL, objconexaoMySQL);
            MySqlDataReader Retorno_Resultado;

            AbrirBanco();
            Retorno_Resultado = objComando.ExecuteReader();

            return Retorno_Resultado;
        }
        #endregion

    }
}