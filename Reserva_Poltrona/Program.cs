using System;

namespace Reserva_Poltrona
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetorPoltronas = new string[150];
            string nome, cancelarpoltrona;
            int select = 0, poltronaescolhida = 0, faturamento = 0;

            for (int i = 0; i < vetorPoltronas.Length; i++)
            {
                vetorPoltronas[i] = "vazia";
            }

            for (int i = 0; i < vetorPoltronas.Length; i++)
            {
                Console.WriteLine("poltrona {0}: {1} ", i, vetorPoltronas[i]);
            }

            do
            {
                Console.WriteLine(" 1 - para fazer reserva da poltrona ");
                Console.WriteLine(" 2 - para cancelar reservas ");
                Console.WriteLine(" 3 - para exibir a fatura ");
                Console.WriteLine(" 4 - para consultar poltrona ");
                Console.WriteLine(" 5 - para sair ");
                select = int.Parse(Console.ReadLine());

                if (select == 1)
                {
                    {
                        Console.WriteLine(" Escolha uma poltrona de 0 à 150");
                        poltronaescolhida = int.Parse(Console.ReadLine());

                        if (vetorPoltronas[poltronaescolhida] != "vazia")
                        {
                            Console.WriteLine(" Essa Poltrona já está ocupada! ");
                        }

                        else
                        {
                            Console.WriteLine(" Informe seu nome: ");
                            nome = Console.ReadLine();
                            vetorPoltronas[poltronaescolhida] = nome;
                        }
                    }
                }


                if (select == 2)
                {
                    Console.WriteLine("escolha poltrona de 0 a 149 para ser cancelada");
                    poltronaescolhida = int.Parse(Console.ReadLine());
                    for (int i = 0; i < vetorPoltronas.Length; i++)
                    {
                        if (vetorPoltronas[poltronaescolhida] == "vazia")
                        {
                            Console.WriteLine("Poltrona vazia, escolha outra");
                        }
                        if (vetorPoltronas[poltronaescolhida] != "vazia")
                        {
                            Console.WriteLine("poltrona {0} ", vetorPoltronas[poltronaescolhida]);
                            Console.WriteLine("Deseja cancelar s/n ");
                            cancelarpoltrona = Console.ReadLine();

                            if (cancelarpoltrona == "s")
                            {
                                vetorPoltronas[poltronaescolhida] = "vazia";
                            }

                            else
                            {
                                Console.WriteLine("Cancelamento não realizado");
                            }

                            break;
                        }
                    }

                }


                if (select == 3)
                {
                    for (int i = 0; i < vetorPoltronas.Length; i++)
                    {
                        if (i <= 49 && vetorPoltronas[i] != "vazia")
                        {
                            faturamento = faturamento + 450;
                        }

                        else if (i >= 50 && i <= 100 && vetorPoltronas[i] != "vazia")
                        {
                            faturamento = faturamento + 250;
                        }

                        else if (i >= 100 && vetorPoltronas[i] != "vazia")
                        {
                            faturamento = faturamento + 150;
                        }

                    }
                    Console.WriteLine(" O Faturamento é : {0}$", faturamento);
                    faturamento = 0;

                }

                if (select == 4)
                {
                    for (int i = 0; i < vetorPoltronas.Length; i++)
                    {
                        if (vetorPoltronas[i] != "vazia")
                        {
                            Console.WriteLine("poltrona {0}: {1} ", i, vetorPoltronas[i]);
                        }
                    }
                }
                if (select == 5)
                    for (int i = 0; i < vetorPoltronas.Length; i++)
                    {
                        Console.WriteLine("poltrona {0}: {1} ", i, vetorPoltronas[i]);
                    }

            }
            while (select != 5);
        }
    }
}




