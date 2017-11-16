using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    class Program
    {
        // objetos a serem usados para classes
        public static Servidor objServ = new Servidor();
        public static Cliente objCli = new Cliente();
        public static Opcli objOpcli = new Opcli();

        static void Main(string[] args)
        {
            int OP = 0;
            while (OP != 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("_____Lojas Jotão eletrons____________________");
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("_____1 - fazer operações de Servidor_________");
                Console.WriteLine("_____2 - fazer operações de Cliente__________");
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:\n");
                Console.ResetColor();
                OP = int.Parse(Console.ReadLine());

                switch (OP)
                {
                    //daqui vai pra o Menugerente que ta aqui mesmo no programa principal
                    case 1: MenuServidor(); break;
                    //daqui vai pra o MenuCliente que tambem ta aqui no programa principal
                    case 2: MenuCliente(); break;
                    default:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um valor valido!!!");
                        Console.ResetColor();
                        break;
                }
                
            }
        }
        public static void MenuServidor()
        {

            int OPmenuServ;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_____Lojas Jotão eletrons_____________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_____1 - Inserir clientes_____________________");
            Console.WriteLine("_____2 - Buscar dados do cliente______________");
            Console.WriteLine("_____3 - Listar clientes adastrados___________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_____4 - Inserir Servidor_____________________");
            Console.WriteLine("_____5 - Buscar dados do Servidor_____________");
            Console.WriteLine("_____6 - Listar Servidores cadastrados________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:");
            Console.ResetColor();
            OPmenuServ = int.Parse(Console.ReadLine());
            
            //daqui vai pra classe gerente ou cliente executando seus métodos
            switch (OPmenuServ)
            {
                case 1: objCli.InserirCli(); break;
                case 2: objCli.BuscarCli(); break;
                case 3: objCli.SenhaGerente(); break;
                case 4: objServ.InserirServ(); break;
                case 5: objServ.BuscarServ(); break;
                case 6: objServ.Senhagerente(); break;
                default:
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor valido!!!");
                    Console.ResetColor();
                    break;
            }

        }
        public static void MenuCliente()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("________________Comprar produtos_____________________");
            Console.WriteLine("______1 - Bonés______________________________________");
            Console.WriteLine("______2 - Camisas____________________________________");
            Console.WriteLine("______3 - Calças_____________________________________");
            Console.WriteLine("______4 - Tênis ou Sapato____________________________");
            Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:");
            Console.ResetColor();
            int opção = int.Parse(Console.ReadLine());
            //daqui vai pra classe Opcli tambem executando seus métodos
            switch (opção)
            {
                case 1: objOpcli.Produtobone() ; break;
                case 2: objOpcli.Produtocamisa() ; break;
                case 3: objOpcli.Produtocalca(); break;
                case 4: objOpcli.Produtotenis() ; break;
                default: 
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor valido!!!");
                    Console.ResetColor();
                    break;
            }
        }
    }
}