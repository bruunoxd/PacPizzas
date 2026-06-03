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
using System.Windows.Forms;

namespace RotinasGerais
{
    public class clsRotinasGerais
    {

        //*** Declara o Construtor do Módulo (Module) de 
        //   Visão Global ***
        private clsRotinasGerais() { } //*** Duas Chaves que faz criar um Módulo *** //*** Módulo= Conjunto de Métodos ***

        //*** Delcaração de Variáveis Globais ***
        // A palavra static faz com que os métodos da classe
        // estejam associados a classe e não com uma instância
        // particular da classe. Eles se tornam acessíveis a 
        // partir da classe pois não precisam ser acessados
        // através de uma instância da classe.
        // Embora também possa ser acessado desta forma.
        // Com isto concluímos que membros declarados como
        // static são membros da classe e não membros de 
        // instância.
        // Logo podemos acessar membros declarados como static
        // em uma classe sem criar uma instância da classe.
        public static int TentativasLogin;
        public static string CPFFuncionario;
        //******************************************** 
        //*** O "Region" Define um bloco de Código ***
        //*** que você pode expandir ou recolher   ***
        //********************************************
        //***     Rotinas e Funções Gerais         ***
        //********************************************
        #region Rotinas e Funções Gerais

        #region Funções Gerais
        
        
        //*** Função ***
        public static string Inverte_Data(string DataOriginal)
        {
            string DataInvertida;

            if (DataOriginal.Trim() == "/ /")
            {
                //*** Se a Data está em Branco retorna zero ***
                DataInvertida = "0000-00-00";
            }
            else
            {
                //*** Se a Data estiver preenchida Inverte a Data ***
                DataInvertida = DataOriginal.Substring(6, 4) + "-" +
                    DataOriginal.Substring(3, 2) + "-" +
                    DataOriginal.Substring(0, 2);
            }
            //*** Remove os Espaços em Branco para não ocorrer problemas
            //    com relação a inserção ***
            DataInvertida = DataInvertida.Trim();

            return DataInvertida;

        }
        public static string TrocaAspasSimples(string Texto)
        {
            string TextoSemAspas;

            TextoSemAspas = Texto.Replace("'", "´");
            TextoSemAspas = TextoSemAspas.Trim();

            return TextoSemAspas;
        }

        public static string TrocaVirgulaPonto(string Texto)
        {
            string TextoPonto;

            TextoPonto = Texto.Replace(",", ".");
            TextoPonto = TextoPonto.Trim();

            return TextoPonto;
        }

        public static string RemoveCaracteres(string Texto, string Caracter)
        {
            string TextoSemCaracter;

            TextoSemCaracter = Texto.Replace(Caracter, "");
            TextoSemCaracter = TextoSemCaracter.Trim();

            return TextoSemCaracter;
        }

        public static string TrocaPontoVirgula(string Texto) // função Publica ..todo valor que entrar vai ser Texto
        {
            string TextoPontoVirgula;

            TextoPontoVirgula = Texto.Replace(".", ",");
            TextoPontoVirgula = TextoPontoVirgula.Trim();
            return TextoPontoVirgula;
        }
        
        #endregion

        #region Rotinas

        //*** Rotina ***
        public static void PulaCampoEnter(int Tecla)
        {
            if (Tecla == 13)
            {
                //*** Caso a Tecla ENTER seja utilizada o Sistema
                //    envia um sinal substituindo a Tecla ENTER
                //    pelo TAB ***
                SendKeys.Send("{TAB}");  
            }
        }

        #endregion

        #endregion

    }
}
