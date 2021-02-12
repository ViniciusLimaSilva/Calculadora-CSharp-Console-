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
                Console.WriteLine("7 - Sen, Cos ou Tang");
                Console.WriteLine("8 - Log");
                Console.WriteLine("9 - Bin, Oct pu Hex");
                Console.WriteLine("10 - Base ^ ao expoente");


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
                else if(resp == 7)
                {
                    int cont = 0;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine(cont + " - " + numeros[i]);
                        cont = cont + 1;

                    }
                    Console.WriteLine("Qual dos numeros acima você deseja Utilizar: ");
                    Console.WriteLine("OPÇÃO APENAS PARA UM ANGULO POR CALCULO!!!!");
                    string[] selecionador = Console.ReadLine().Split(" ");
                    Console.WriteLine("Deseja Fazer o calculo do sen, cos, tan ou todos?");
                    string resp4op = Console.ReadLine();

                    if(resp4op == "sen")
                    {
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("O seno do angulo de " + num1 +" é: " + Math.Sin(num1));

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }
                    else if(resp4op == "cos")
                    {
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("O cosseno do angulo de " + num1 +" é: " + Math.Cos(num1));

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }
                    else if(resp4op == "tan")
                    {
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("A Tangente do angulo " + num1 +" é: " + Math.Tan(num1));

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }
                    else if (resp4op == "todos")
                    {
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("O seno do angulo de " + num1 + " é: " + Math.Sin(num1));
                        
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("O cosseno do angulo de " + num1 + " é: " + Math.Cos(num1));

                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("A tangente do angulo de " + num1 + " é: " + Math.Tan(num1));

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("RESPOSTA NÃO ENCONTRADA!!!!!");

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }

                    
                }
                else if (resp == 8)
                {
                    Console.WriteLine("Quantos números você deseja tirar o LOG?");
                    Console.WriteLine("OBS: MAXIMO DE 3 NUMEROS");
                    int escolha = int.Parse(Console.ReadLine());
                    if(escolha == 1)
                    {
                        int cont = 0;

                        for (int i = 0; i < numeros.Length; i++)
                        {

                            Console.WriteLine(cont + " - " + numeros[i]);
                            cont = cont + 1;
                        }

                        Console.WriteLine("Qual dos numeros acima você deseja fazer o LOG: ");
                        Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 2)");
                        string[] selecionador = Console.ReadLine().Split(" ");

                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        Console.WriteLine("O log de " + num1 + "é: " + Math.Log(num1));

                    }
                    else if(escolha == 2)
                    {
                        int cont = 0;

                        for (int i = 0; i < numeros.Length; i++)
                        {

                            Console.WriteLine(cont + " - " + numeros[i]);
                            cont = cont + 1;
                        }
                        Console.WriteLine("Qual dos numeros acima você deseja fazer o LOG: ");
                        Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 2 5)");
                        string[] selecionador = Console.ReadLine().Split(" ");

                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                        Console.WriteLine("O log de " + num1 + "é: " + Math.Log(num1));
                        Console.WriteLine("O log de " + num2 + "é: " + Math.Log(num2));

                    }
                    else if(escolha == 3)
                    {
                        int cont = 0;

                        for (int i = 0; i < numeros.Length; i++)
                        {

                            Console.WriteLine(cont + " - " + numeros[i]);
                            cont = cont + 1;
                        }
                        Console.WriteLine("Qual dos numeros acima você deseja fazer o LOG: ");
                        Console.WriteLine("Digite todos os que você deseja respeitando a sequencia ordinal (EX: 2 3 4)");
                        string[] selecionador = Console.ReadLine().Split(" ");

                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[1])]);
                        Console.WriteLine("O log de " + num1 + "é: " + Math.Log(num1));
                        Console.WriteLine("O log de " + num2 + "é: " + Math.Log(num2));
                        Console.WriteLine("O log de " + num3 + "é: " + Math.Log(num3));

                    }


                }

                else if (resp == 9)
                {
                    int cont = 0;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine(cont + " - " + numeros[i]);
                        cont = cont + 1;

                    }
                    Console.WriteLine("Qual dos numeros acima você deseja Utilizar: ");
                    Console.WriteLine("OBS!!!! APENAS UM NUMERO");
                    string[] selecionador = Console.ReadLine().Split(" ");
                    Console.WriteLine("Deseja Fazer o calculo do bin, oct, hex ou todos?");
                    string resp4op = Console.ReadLine();

                    if (resp4op == "bin")
                    {

                        int resto;
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);

                        string result = string.Empty;

                        while (num1 > 0)
                        {
                            resto = num1 % 2;
                            num1 /= 2;
                            result = resto + result;
                        }
                        Console.WriteLine("O binario do numero: " + num1 + " é: " + result);

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }
                    else if (resp4op == "oct")
                    {
                        int resto;
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);

                        string result = string.Empty;

                        while (num1 > 0)
                        {
                            resto = num1 % 8;
                            num1 /= 8;
                            result = resto + result;
                        }
                        Console.WriteLine("O Octal do numero: " + num1 + " é: " + result);

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }
                
                    else if (resp4op == "hex")
                    {
                    int resto;
                    num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);

                    string result = string.Empty;

                    while (num1 > 0)
                    {
                        resto = num1 % 16;
                        num1 /= 16;
                        result = resto + result;
                    }
                    Console.WriteLine("O Hexadecimal do numero: " + num1 + " é: " + result);

                    Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                    final = Console.ReadLine();
                }
            
                    else if (resp4op == "todos")
                    {
                        int resto;
                        num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);

                        string result = string.Empty;

                        while (num1 > 0)
                        {
                            resto = num1 % 2;
                            num1 /= 2;
                            result = resto + result;
                        }
                        Console.WriteLine("O binario do numero: " + num1 + " é: " + result);

                        int resto2;
                        num2 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);

                        string result2 = string.Empty;
                        while (num2 > 0)
                        {
                            resto2 = num2 % 8;
                            num2 /= 8;
                            result2 = resto2 + result2;
                        }
                        Console.WriteLine("O octal do numero: " + num2 + " é: " + result2);

                        int resto3;
                        num3 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);
                        string result3 = string.Empty;
                        while (num3 > 0)
                        {
                            resto3 = num3 % 16;
                            num3 /= 16;
                            result3 = resto3 + result3;
                        }
                        Console.WriteLine("O hexadeciaml do numero: " + num3 + " é: " + result3);

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("RESPOSTA NÃO ENCONTRADA!!!!!");

                        Console.WriteLine("Deseja fazer outras operações? (sim/nao)");
                        final = Console.ReadLine();
                    }


                }
                else if(resp == 10)
                {

                    int cont = 0;
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        Console.WriteLine(cont + " - " + numeros[i]);
                        cont = cont + 1;

                    }
                    Console.WriteLine("Qual dos numeros acima você deseja Utilizar: ");
                    Console.WriteLine("OBS!!!! APENAS UM NUMERO");
                    string[] selecionador = Console.ReadLine().Split(" ");
                    Console.WriteLine("Qual seria o expoente do numero selecionado?");
                    int exp = Convert.ToInt32(Console.ReadLine());
                    num1 = Convert.ToInt32(numeros[Convert.ToInt32(selecionador[0])]);

                    Console.WriteLine("O numero " + num1 + ", elavado ao numero " + exp + ", é igual a: " + Math.Pow(num1, exp));






                }

            } while (final == "sim");
        }
    }
}
