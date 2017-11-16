using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa_lojas_Jotão_Eletros
{
    class Opcli : Cliente
    {
        public void Produtobone()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_______Produtos_______________________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_______1 - Aba reta = R$ 25,00________________");
            Console.WriteLine("_______2 - Aba redonda = R$ 20,00_____________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:");
            Console.ResetColor();
            int opção = int.Parse(Console.ReadLine());
            //-----------------------------------------------------------------------------
            switch (opção)
            {
                case 1:
                    int Valor1 = 25;
                    string num;
                    Console.WriteLine("Senha do Cliente: ");
                    num = Console.ReadLine();
                    int AUX = 0;
                    Boolean acheiCli = false;
                    while ((acheiCli == false) && (AUX < 3))
                    {
                        if (ListaCli[AUX].senha == num)
                        {
                            acheiCli = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX].limiteconta + " - " + Valor1);
                            perfumaria();
                            perfumaria();
                        }
                        AUX++;
                    }
                    if (acheiCli == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    } break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 2:
                    int Valor2 = 20;
                    string num2;
                    Console.WriteLine("Senha do Cliente: ");
                    num2 = Console.ReadLine();
                    int AUX2 = 0;
                    Boolean acheiCli2 = false;
                    while ((acheiCli2 == false) && (AUX2 < 3))
                    {
                        if (ListaCli[AUX2].senha == num2)
                        {
                            acheiCli = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX2].limiteconta + " - " + Valor2);
                            perfumaria();
                            perfumaria();
                        }
                        AUX2++;
                    }
                    if (acheiCli2 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    } break;
                //-----------------------------------------------------------------------------
                default:
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor valido!!!");
                    Console.ResetColor();
                    break;
                //-----------------------------------------------------------------------------
            }
        }
        public void Produtocamisa()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______Produtos_______________________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_______1 - Camisa manga longa = R$ 50,00______");
            Console.WriteLine("_______2 - Camisa manga curta = R$ 35,00______");
            Console.WriteLine("_______3 - Camisa social = R$ 70,00___________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:");
            Console.ResetColor();
            int opção = int.Parse(Console.ReadLine());

            switch (opção)
            {
                //-----------------------------------------------------------------------------
                case 1:
                    int valor3 = 50;
                    string num3;
                    Console.WriteLine("Senha do Cliente: ");
                    num3 = Console.ReadLine();
                    int AUX3 = 0;
                    Boolean acheiCli3 = false;
                    while ((acheiCli3 == false) && (AUX3 < 3))
                    {
                        if (ListaCli[AUX3].senha == num3)
                        {
                            acheiCli3 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX3].limiteconta + " - " + valor3);
                            perfumaria();
                            perfumaria();
                        }
                        AUX3++;
                    }
                    if (acheiCli3 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 2:
                    int valor4 = 35;
                    string num4;
                    Console.WriteLine("Senha do Cliente: ");
                    num4 = Console.ReadLine();
                    int AUX4 = 0;
                    Boolean acheiCli4 = false;
                    while ((acheiCli4 == false) && (AUX4 < 3))
                    {
                        if (ListaCli[AUX4].senha == num4)
                        {
                            acheiCli4 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX4].limiteconta + " - " + valor4);
                            perfumaria();
                            perfumaria();
                        }
                        AUX4++;
                    }
                    if (acheiCli4 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 3:
                    int valor5 = 70;
                    string num5;
                    Console.WriteLine("Senha do Cliente: ");
                    num5 = Console.ReadLine();
                    int AUX5 = 0;
                    Boolean acheiCli5 = false;
                    while ((acheiCli5 == false) && (AUX5 < 3))
                    {
                        if (ListaCli[AUX5].senha == num5)
                        {
                            acheiCli5 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX5].limiteconta + " - " + valor5);
                            perfumaria();
                            perfumaria();
                        }
                        AUX5++;
                    }
                    if (acheiCli5 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                default:
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor valido!!!");
                    Console.ResetColor();
                    break;
                //-----------------------------------------------------------------------------
            }
        }
        public void Produtocalca()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______Produtos_______________________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_______1 - Calça Jeans = R$ 110,00____________");
            Console.WriteLine("_______2 - Calça esportiva = R$ 80,00_________");
            Console.WriteLine("_______3 - Calça social = R$ 100,00___________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:");
            Console.ResetColor();
            int opção = int.Parse(Console.ReadLine());

            switch (opção)
            {
                //-----------------------------------------------------------------------------
                case 1:
                    int valor6 = 110;
                    string num6;
                    Console.WriteLine("Senha do Cliente: ");
                    num6 = Console.ReadLine();
                    int AUX6 = 0;
                    Boolean acheiCli6 = false;
                    while ((acheiCli6 == false) && (AUX6 < 3))
                    {
                        if (ListaCli[AUX6].senha == num6)
                        {
                            acheiCli6 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX6].limiteconta + " - " +valor6);
                            perfumaria();
                            perfumaria();
                        }
                        AUX6++;
                    }
                    if (acheiCli6 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 2:
                    int valor7 = 80;
                    string num7;
                    Console.WriteLine("Senha do Cliente: ");
                    num7 = Console.ReadLine();
                    int AUX7 = 0;
                    Boolean acheiCli7 = false;
                    while ((acheiCli7 == false) && (AUX7 < 3))
                    {
                        if (ListaCli[AUX7].senha == num7)
                        {
                            acheiCli7 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX7].limiteconta + " - " + valor7);
                            perfumaria();
                            perfumaria();
                        }
                        AUX7++;
                    }
                    if (acheiCli7 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 3:
                    int valor8 = 100;
                    string num8;
                    Console.WriteLine("Senha do Cliente: ");
                    num8 = Console.ReadLine();
                    int AUX8 = 0;
                    Boolean acheiCli8 = false;
                    while ((acheiCli8 == false) && (AUX8 < 3))
                    {
                        if (ListaCli[AUX8].senha == num8)
                        {
                            acheiCli8 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX8].limiteconta + " - " + valor8);
                            perfumaria();
                            perfumaria();
                        }
                        AUX8++;
                    }
                    if (acheiCli8 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                default:
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor valido!!!");
                    Console.ResetColor();
                    break;
                //-----------------------------------------------------------------------------
            }
        }
        public void Produtotenis()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______Produtos_______________________________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("_______1 - Tênis bico redondo = R$ 80,00______");
            Console.WriteLine("_______2 - Tênis esportivo = R$ 220,00________");
            Console.WriteLine("_______3 - Sapato social = R$ 100,00__________");
            Console.WriteLine("______________________________________________");
            Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ACIMA:");
            Console.ResetColor();
            int opção = int.Parse(Console.ReadLine());

            switch (opção)
            {
                //-----------------------------------------------------------------------------
                case 1:
                    int valor9 = 80;
                    string num9;
                    Console.WriteLine("Senha do Cliente: ");
                    num9 = Console.ReadLine();
                    int AUX9 = 0;
                    Boolean acheiCli9 = false;
                    
                    while ((acheiCli9 == false) && (AUX9 < 3))
                    {
                        if (ListaCli[AUX9].senha == num9)
                        {
                            acheiCli9 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX9].limiteconta + " - " + valor9);

                            perfumaria();
                            perfumaria();
                        }
                        AUX9++;
                    }
                    if (acheiCli9 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 2:
                    int valor10 = 220;
                    string num10;
                    Console.WriteLine("Senha do Cliente: ");
                    num10 = Console.ReadLine();
                    int AUX10 = 0;
                    Boolean acheiCli10 = false;
                    while ((acheiCli10 == false) && (AUX10 < 3))
                    {
                        if (ListaCli[AUX10].senha == num10)
                        {
                            acheiCli10 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX10].limiteconta + " - " + valor10);
                            perfumaria();
                            perfumaria();
                        }
                        AUX10++;
                    }
                    if (acheiCli10 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                //-----------------------------------------------------------------------------
                case 3:
                    int valor11 = 100;
                    string num11;
                    Console.WriteLine("Senha do Cliente: ");
                    num11 = Console.ReadLine();
                    int AUX11 = 0;
                    Boolean acheiCli11 = false;
                    while ((acheiCli11 == false) && (AUX11 < 3))
                    {
                        if (ListaCli[AUX11].senha == num11)
                        {
                            acheiCli11 = true;
                            perfumaria();
                            perfumaria();
                            Console.WriteLine("Compra realizada com sucesso!!!");
                            Console.WriteLine("Limite da conta:" + ListaCli[AUX11].limiteconta + " - " + valor11);
                            perfumaria();
                            perfumaria();
                        }
                        AUX11++;
                    }
                    if (acheiCli11 == false)
                    {
                        Console.WriteLine("Cliente não encontrado!!!");
                    }; break;
                //-----------------------------------------------------------------------------
                default:
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um valor valido!!!");
                    Console.ResetColor();
                    break;
                //-----------------------------------------------------------------------------
            }
        }
    }
}
