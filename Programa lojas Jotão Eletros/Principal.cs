using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    class Principal
    {
        //----------Listas-------------------------------------------------------
        public static List<Servidor> ListaServ = new List<Servidor>();
        public static List<Cliente> ListaCli = new List<Cliente>();
        //----------Objetos------------------------------------------------------
        public static Servidor objClassServ = new Servidor();
        public static Cliente objClassCli = new Cliente();
        //----------Métodos e atributos para classes Servidor e Cliente----------
        string nome1, RG1, CPF1, Data1, senha1,limite;
        // não consegui fazer um loop com o atributo numero1 tentei com for e com while mas não consegui 
        int numero1 = 1;
        public string nome { set { nome1 = value; } get { return nome1; } }
        public string RG { set { RG1 = value; } get { return RG1; } }
        public string CPF { set { CPF1 = value; } get { return CPF1; } }
        public string Data { set { Data1 = value; } get { return Data1; } }
        public string senha { set { senha1 = value; } get { return senha1; } }
        public int numero 
        { 
            set 
            {
            } 
            get { return numero1; } 
        }
        public string limiteconta { set { limite = value; } get { return limite; } }     
        //-----------------------------------------------------------------------
        public static void buscar()
        {
            Console.WriteLine("Teste!!!");
        }
        //-----------------------------------------------------------------------
        public static void Inserir()
        {
            Console.WriteLine("Teste!!!");
        }
        //-----------------------------------------------------------------------
        public static void Listar()
        {
            Console.WriteLine("Teste!!!");
        }
        //-------Métodos de organização(Perfumaria)------------------------------
        public void saudacao() { Console.WriteLine("Inserido com sucesso!!!"); }
        public void perfumaria() { Console.WriteLine("_________________________________________________"); }
        //-----------------------------------------------------------------------
    }
}
