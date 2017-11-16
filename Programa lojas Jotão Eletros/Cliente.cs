using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    class Cliente : Principal
    {
        //--------------------------------------------------------------------------------------------------------------
        public void InserirCli()
        {
            for (int i = 0; i < 3; i++)
            {
                Cliente objClassCli = new Cliente();
                //-------------------------------------------------------------------
                Console.WriteLine("Numero do cartão do cliente é: " + numero);
                Console.WriteLine("Nome do Cliente: ");
                objClassCli.nome = Console.ReadLine();
                Console.WriteLine("CPF do Cliente: ");
                objClassCli.CPF = Console.ReadLine();
                Console.WriteLine("RG do Cliente: ");
                objClassCli.RG = Console.ReadLine();
                Console.WriteLine("Data de nascimento do Cliente: ");
                objClassCli.Data = Console.ReadLine();
                Console.WriteLine("Limite da conta:");
                objClassCli.limiteconta = Console.ReadLine();
                Console.WriteLine("Senha do Cliente(de no Mínimo quatro dígitos): ");
                objClassCli.senha = Console.ReadLine();
                //-------------------------------------------------------------------
                ListaCli.Add(objClassCli);
                //-------------------------------------------------------------------
                perfumaria();
                Console.WriteLine();
                saudacao();
                Console.WriteLine();
                perfumaria();
            }
            pausaclass();
        }
        //--------------------------------------------------------------------------------------------------------------
        public void BuscarCli()
        {
            // nesse método buscar eu queria saber como faz pra ele buscar todos os clientes de mesmo nome ou número
            //o senhor tinha falado na aula que tinha varias formas de fazer isso mas não encontrei nenhuma
            //-------------------------------------------------------------------
            string num;
            Console.WriteLine("Senha do Cliente: ");
            num = Console.ReadLine();
            int AUX = 0;
            Boolean acheiCli = false;
            //-------------------------------------------------------------------
            while ((acheiCli == false) && (AUX < 3))
            {
                if (ListaCli[AUX].senha == num)
                {
                    acheiCli = true;
                    perfumaria();
                    perfumaria();
                    Console.WriteLine("Nome do Cliente:" + ListaCli[AUX].nome);
                    Console.WriteLine("CPF do Cliente:" + ListaCli[AUX].CPF);
                    Console.WriteLine("RG do Cliente:" + ListaCli[AUX].RG);
                    Console.WriteLine("Data de nascimento do Cliente:" + ListaCli[AUX].Data);
                    Console.WriteLine("Numero do cartão do Cliente:" + ListaCli[AUX].numero);
                    Console.WriteLine("Limite da conta:" + ListaCli[AUX].limiteconta);
                    perfumaria();
                    perfumaria();
                }
                AUX++;
            }
            //-------------------------------------------------------------------
            if (acheiCli == false)
            {
                Console.WriteLine("Cliente não encontrado!!!");
            }
            //-------------------------------------------------------------------
        }
        //--------------------------------------------------------------------------------------------------------------
        public void ListarCli()
        {
            //-------------------------------------------------------------------
            if (ListaCli.Count == 0)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem clientes inseridos!!!");
                Console.ResetColor();
            }
            //-------------------------------------------------------------------
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    perfumaria();
                    perfumaria();
                    Console.WriteLine("Nome do Cliente:" + ListaCli[i].nome);
                    Console.WriteLine("CPF do Cliente:" + ListaCli[i].CPF);
                    Console.WriteLine("RG do Cliente:" + ListaCli[i].RG);
                    Console.WriteLine("Numero do cartão do Cliente:" + ListaCli[i].numero);
                    Console.WriteLine("Limite da conta:" + ListaCli[i].limiteconta);
                    perfumaria();
                    perfumaria();
                }
            }
            //-------------------------------------------------------------------
           
        }
        //--------------------------------------------------------------------------------------------------------------
        public void SenhaGerente()
        {
           string sgerente = "jotao";
           
           Console.WriteLine("Inserir senha do gerente(senha ta no método SenhaGerente) :");
           sgerente = Console.ReadLine();
           //-------------------------------------------------------------------
            if (sgerente == "jotao")
            { 
                Console.WriteLine("Senha correta!!! ");
                ListarCli();
            }
            else
            {          
                   Console.Beep();
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Digite uma senha valida!!!");
                   Console.ResetColor();
            }
            //-------------------------------------------------------------------
        }
        //--------------------------------------------------------------------------------------------------------------
        public void pausaclass()
        {
            int escolha = 0;
            //-------------------------------------------------------------------
            while (escolha != 2012)
            {
                Console.WriteLine("Deseja substituir os clientes inseridos?");
                Console.WriteLine("1 - sim");
                Console.WriteLine("2 - não\n");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    //-------------------------------------------------------------------
                    case 1:
                        //aki eu to com a mesma dúvida do if logo em baixo
                        Console.WriteLine();
                        perfumaria();
                        Console.WriteLine("A empresa ta crescendo!!!");
                        perfumaria();
                        Console.WriteLine();
                        InserirCli();
                        break;
                    //-------------------------------------------------------------------
                    case 2:
                        /* aki nesse if eu queria saber como posso fazer pra que ele seja exibido
                        quando eu criar um dos 3 clientes e não depois dos três como o senhor deve ter observado*/ 
                        if (escolha != 2012)
                        {
                            escolha = 2012;
                            Console.WriteLine();
                            perfumaria();
                            Console.WriteLine("Obrigado pela atenção!!!");
                            perfumaria();
                            Console.WriteLine();
                        }
                        break;
                    //-------------------------------------------------------------------
                    default:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("Digite um valor valido(1 ou 2)");
                        Console.WriteLine();
                        Console.ResetColor();
                        break;
                    //-------------------------------------------------------------------
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------
    }
}

