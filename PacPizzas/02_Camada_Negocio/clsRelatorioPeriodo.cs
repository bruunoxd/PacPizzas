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

namespace RelatorioPeriodo
{
    class clsRelatorioPeriodo
    {
        #region Instância das Classes
        //*** Instancia os Objetos da Classes Correspondentes ***
        clsConexaoBanco objConexaoBanco = new clsConexaoBanco();
        #endregion

        #region Métodos da Classe clsRelatorioPeriodo

        #region Métodos da Classe clsRelatorioPeriodo - FUNÇÕES
        //***************
        //*** Funções ***
        //***************

        public bool ValidaDados(frmRelatorioPeriodo _frmRelatorioPeriodo)
        {
            bool Resultado;

            Resultado = true;

            if (_frmRelatorioPeriodo.txtDataInicioTEXT.Trim() == "/  /")
            {
                //************************************
                //*** Valida o Campo txtDataInicio ***
                //************************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Data de Início!");
                _frmRelatorioPeriodo.txtDataInicioFOCUS();
            }
            else if (_frmRelatorioPeriodo.txtDataFinalTEXT.Trim() == "/  /")
            {
                //***********************************
                //*** Valida o Campo txtDataFinal ***
                //***********************************
                Resultado = false;
                MessageBox.Show("Por favor, Informe a Data de Término!");
                _frmRelatorioPeriodo.txtDataFinalFOCUS();
            }
            else if (Convert.ToDateTime(_frmRelatorioPeriodo.txtDataInicioTEXT) > Convert.ToDateTime(_frmRelatorioPeriodo.txtDataFinalTEXT))
            {
                //*************************************
                //*** Verifica o Intervalo de Datas ***
                //*************************************
                Resultado = false;
                MessageBox.Show("A Data de Início está Maior que a Data de Término, Por favor, Informe Corretamente!");
                _frmRelatorioPeriodo.txtDataInicioFOCUS();
            }

            return Resultado;
        }
        #endregion

        #region Métodos da Classe clsRelatorioPeriodo - Rotinas
        //***************
        //*** Rotinas ***
        //***************

        public void GerarRelatorio(frmRelatorioPeriodo _frmRelatorioPeriodo)
        {
            //*** Efetua a Validação de Dados para a Geração do Relatório ***
            if (ValidaDados(_frmRelatorioPeriodo) == true)
            {
                frmRelatorio _frmRelatorio = new frmRelatorio(_frmRelatorioPeriodo);
                _frmRelatorio.ShowDialog();
            }
        }
        #endregion
        #endregion
    }
}
