using System;


namespace TREINO2
{
    class Program
    {
        static void Main(string[] args)
        {


            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int soma = 0;
            int mult = 1;
            int div = 0;
            int sub = 0;
            int div1;
            int div2;
            double aDelta = 0, bDelta = 0, cDelta = 0, delta, raiz1, raiz2;
            string final = "modificada";
            do
            {



                Console.WriteLine("Digite quantos numeros você deseja realizar equações: ");
                int num = int.Parse(Console.ReadLine());
                int[] numeros = new int[num];

                Console.WriteLine("você selecionou " + num + " !!!");
                Console.WriteLine("Digite os numeros escolhidos agora");
                for (int i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("O que você deseja fazer com esses valores? Escolha uma opção abaixo: ");
                Console.WriteLine("1- somar");
                Console.WriteLine("2 - multiplicar");
                Console.WriteLine("3 - dividir");
                Console.WriteLine("4 - subtrair");
                Console.WriteLine("5 - Delta/Baskara");
                Console.WriteLine("6 - Raiz Quadrada");


                int resp = int.Parse(Console.ReadLine());

                if (resp == 1)
                {
                    Console.WriteLine("deseja fazer a soma de todos os numeros: ");
                    string resp2 = Console.ReadLine();

                    if (resp2 == "sim")
                    {
                        for (int i = 0; i < numeros.Length; i++)
                        {

                            soma = soma + numeros[i];
                        }
                        Console.WriteLine("Resultado da soma de todos os valores: " + soma);
                    }
                    else
                    {

                        Console.WriteLine("Quantos números você deseja somar?");
                        Console.WriteLine("OBS: MAXIMO DE 5 NUMEROS E MINIMO DE 2");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA - TENTE NOVAMENTE");

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();

                        }
                        else if (escolha == 2)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a soma: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 )");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);


                            }

                            int resultadosoma = num1 + num2;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosoma);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();




                        }
                        else if (escolha == 3)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a soma: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);


                            }

                            int resultadosoma = (num1 + num2) + num3;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosoma);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();


                        }
                        else if (escolha == 4)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a soma: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                                num4 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[3])]);


                            }

                            int resultadosoma = ((num1 + num2) + num3) + num4;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosoma);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();


                        }
                        else if (escolha == 5)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a soma: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                                num4 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[3])]);
                                num5 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[4])]);


                            }

                            int resultadosoma = (((num1 + num2) + num3) + num4) + num5;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosoma);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();

                        }


                    }

                }
                else if (resp == 2)
                {
                    Console.WriteLine("deseja fazer a multiplicação de todos os numeros: ");
                    string resp2 = Console.ReadLine();

                    if (resp2 == "sim")
                    {
                        for (int i = 0; i < numeros.Length; i++)
                        {

                            mult = mult * numeros[i];
                        }
                        Console.WriteLine("Resultado da multiplicação de todos os valores: " + mult);
                    }
                    else
                    {


                        Console.WriteLine("Quantos números você deseja multiplicar?");
                        Console.WriteLine("OBS: MAXIMO DE 5 NUMEROS E MINIMO DE 2");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA - TENTE NOVAMENTE");

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();

                        }
                        else if (escolha == 2)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a multiplicação: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 )");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);


                            }

                            int resultadosmult = num1 * num2;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosmult);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();




                        }
                        else if (escolha == 3)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a multiplicação: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);


                            }

                            int resultadosmult = (num1 * num2) * num3;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosmult);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();


                        }
                        else if (escolha == 4)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a multiplicação: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                                num4 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[3])]);


                            }

                            int resultadosmult = ((num1 * num2) * num3) * num4;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosmult);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();


                        }
                        else if (escolha == 5)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a multiplicação: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                                num4 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[3])]);
                                num5 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[4])]);


                            }

                            int resultadosmult = (((num1 * num2) * num3) * num4) * num5;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosmult);
                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();                         

                        }


                    }
                }
                else if (resp == 3)
                {
                    if (num == 2)
                    {
                        for (int i = 0; i < numeros.Length; i++)
                        {

                            div1 = Convert.ToInt32(numeros[0]);
                            div2 = Convert.ToInt32(numeros[1]);
                            div = div1 / div2;

                        }
                        Console.WriteLine("Resultado da divisão dos valores: " + div);

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();

                    }
                    else
                    {



                        int cont = 0;

                        for (int i = 0; i < numeros.Length; i++)
                        {

                            Console.WriteLine(cont + " - " + numeros[i]);
                            cont = cont + 1;
                        }

                        Console.WriteLine("Qual dos numeros acima você deseja fazer a dvisao: ");
                        Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 )");
                        Console.WriteLine("OBS: APENAS 2 NUMEROS");
                        string[] selecionador = Console.ReadLine().Split(" ");

                        for (int i = 0; i < numeros.Length; i++)
                        {
                            num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                            num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                        }


                        int resultadosdiv = num1 / num2;
                        Console.WriteLine("Boa escolha, a divisão dos numeros seleciondaos deu em um valor de: " + resultadosdiv);

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();



                    }


                }
                else if (resp == 4)
                {
                    Console.WriteLine("Deseja fazer a subtração de todos os numeros?");
                    string resp2 = Console.ReadLine();

                    if (resp2 == "sim")
                    {
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            sub = sub - numeros[i];
                        }
                        Console.WriteLine("Resultado da soma de todos os valores: " + sub);
                    }
                    else
                    {
                        Console.WriteLine("Quantos números você deseja subtrair?");
                        Console.WriteLine("OBS: MAXIMO DE 5 NUMEROS E MINIMO DE 2");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            Console.WriteLine("OPÇÃO INVÁLIDA - TENTE NOVAMENTE");

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();

                        }
                        else if (escolha == 2)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a subtração: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 )");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);


                            }

                            int resultadosub = num1 - num2;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosub);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();




                        }
                        else if (escolha == 3)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a subtração: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);


                            }

                            int resultadosub = (num1 - num2) - num3;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosub);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();


                        }
                        else if (escolha == 4)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a subtração: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                                num4 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[3])]);


                            }

                            int resultadosub = ((num1 - num2) - num3) - num4;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosub);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();


                        }
                        else if (escolha == 5)
                        {
                            int cont = 0;

                            for (int i = 0; i < numeros.Length; i++)
                            {

                                Console.WriteLine(cont + " - " + numeros[i]);
                                cont = cont + 1;
                            }

                            Console.WriteLine("Qual dos numeros acima você deseja fazer a subtração: ");
                            Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");

                            string[] selecionador = Console.ReadLine().Split(" ");

                            for (int i = 0; i < numeros.Length; i++)
                            {
                                num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                                num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                                num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                                num4 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[3])]);
                                num5 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[4])]);


                            }

                            int resultadosub = (((num1 + num2) + num3) + num4) + num5;
                            Console.WriteLine("Boa escolha, a soma dos numeros seleciondaos deu em um valor de: " + resultadosub);

                            Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                            final = Console.ReadLine();

                        }

                    }

                }
                else if (resp == 5)
                {
                    int cont = 0;

                    for (int i = 0; i < numeros.Length; i++)
                    {

                        Console.WriteLine(cont + " - " + numeros[i]);
                        cont = cont + 1;
                    }


                    Console.WriteLine("Qual dos numeros acima você deseja fazer a Equação: ");
                    Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 1 4 2 3)");
                    Console.WriteLine("OBS: APENAS 3 NUMEROS");
                    string[] selecionador = Console.ReadLine().Split(" ");

                    for (int i = 0; i < numeros.Length; i++)
                    {
                        aDelta = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        bDelta = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                        cDelta = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[2])]);
                    }

                    if (aDelta != 0)
                    {
                        delta = (bDelta * bDelta) - (4 * aDelta * cDelta);

                        if (delta < 0)
                        {
                            Console.WriteLine("Não tem raízes reais!!");
                        }
                        else if (delta == 0)
                        {
                            raiz1 = (-bDelta) / (2 * aDelta);
                            Console.WriteLine("Possui apenas uma raiz real: " + raiz1);
                        }
                        else
                        {
                            raiz1 = (-bDelta - Math.Sqrt(delta)) / (2 * aDelta);
                            raiz2 = (-bDelta + Math.Sqrt(delta)) / (2 * aDelta);
                            Console.WriteLine("Raiz 1: " + raiz1);
                            Console.WriteLine("Raiz 2: " + raiz2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("a = 0, não é uma equação do segundo grau");

                    }

                    Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                    final = Console.ReadLine();



                } else if(resp == 6)
                {
                    int cont = 0;
                    for(int i =0; i < numeros.Length; i++)
                    {
                        Console.WriteLine(cont + " - " + numeros[i]);
                        cont = cont + 1;

                    }
                    Console.WriteLine("Qual dos numeros acima você deseja tirar a raiz quadrada: ");
                    string[] selecionador = Console.ReadLine().Split(" ");

                    num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                    double recebeRaiz, receptor2, comparador;
                    recebeRaiz = Math.Sqrt(num1);
                    receptor2 = recebeRaiz;
                    comparador = recebeRaiz - receptor2;

                    string conversao = recebeRaiz.ToString();
                    if (conversao.Contains(","))
                    {
                        Console.WriteLine("A raiz do seu número não é exata!!!");
                        Console.WriteLine("Deseja ver mesmo assim? (sim/nao)");
                        string selecionadordevisao = Console.ReadLine();
                        if(selecionadordevisao == "sim")
                        {
                            Console.WriteLine("A raiz quadrada do número " + num1 + " é: " + Math.Sqrt(num1));
                        }

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("A raiz quadrada do número " + num1 + " é: " + Math.Sqrt(num1));

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                
                    }




                }

            } while (final == "sim");
        }
    }
}
