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

namespace Relatorio
{
    class clsRelatorio
    {
        #region Instância das Classes
        //*** Instancia os Objetos das Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion
        #region Métodos da Classe clsRelatório
        #region Métodos da Classe clsRelatório - Rotinas
        public void CarregaDadosRelatorio(frmRelatorio _frmRelatorio, frmRelatorioPeriodo _frmRelatorioPeriodo)
        {
            //*** Declara as Variáveis Necessárias para se Gerar o Relatório ***
            string Comando_SQL;

            //*** Prepara o Comando SQL para Data Adapter e Receber o Resultado do SQL ***
            Comando_SQL = "SELECT ";
            Comando_SQL = Comando_SQL + "pedido_codigo, ";
            Comando_SQL = Comando_SQL + "DATE_FORMAT(pedido_data, '%d/%m/%Y') AS pedido_data, ";
            Comando_SQL = Comando_SQL + "pedido_horario, ";
            Comando_SQL = Comando_SQL + "pedido_total, ";
            Comando_SQL = Comando_SQL + "pedido_cliente_sequencial, ";
            Comando_SQL = Comando_SQL + "pedido_funcionario_cpf ";
            Comando_SQL = Comando_SQL + "FROM ";
            Comando_SQL = Comando_SQL + "pedidos ";
            Comando_SQL = Comando_SQL + "WHERE ";
            Comando_SQL = Comando_SQL + "pedido_cliente_sequencial <> 0 AND ";
            Comando_SQL = Comando_SQL + "pedido_data >= '" +
                clsRotinasGerais.Inverte_Data(_frmRelatorioPeriodo.txtDataInicioTEXT.Trim()) +
                "' AND pedido_data <= '" +
                clsRotinasGerais.Inverte_Data(_frmRelatorioPeriodo.txtDataFinalTEXT.Trim()) + "' ";

            //*** Instancia os Objetos Necessários (Data Adapter e Data Set) ***
            MySqlDataAdapter da = new MySqlDataAdapter(Comando_SQL, clsConexaoBanco.objconexaoMySQL);
            DataSet ds = new DataSet();

            ds.Tables.Clear();
            da.Fill(ds);

            //*** Efetua a Ativação do Relatório enviando o DS ***
            _frmRelatorio.rptPedidosATIVACAO(ds);
        }
        #endregion
        #endregion
    }
}
