using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string acao = "";
        string caminho = "usuario.txt";
        string nome = "", email = "", telefone = "", rg = "";


        Console.WriteLine("### R - Calcular as propriedadas de um retângulo ###");
        Console.WriteLine("####### C - Comparar área 2 triângulos #############");
        Console.WriteLine("####### G - Gravar #################################");
        Console.WriteLine("####### L - Ler  ###################################");
        Console.WriteLine("####### S - Sair ###################################");
        Console.WriteLine("####################################################");
        Console.Write("Digite uma operação: ");
        acao = Console.ReadLine().ToUpper();
        Console.WriteLine();

        while (acao != "S")
        {

            if (acao == "G")
            {
                Console.Write("Informe seu nome: ");
                nome = Console.ReadLine();

                Console.Write("Informe seu e-mail: ");
                email = Console.ReadLine();

                Console.Write("Informe seu Telefone: ");
                telefone = Console.ReadLine();

                Console.Write("Informe seu RG: ");
                rg = Console.ReadLine();

                StreamWriter sw = new StreamWriter(caminho, true);

                sw.WriteLine("Nome: " + nome);
                sw.WriteLine("E-mail: " + email);
                sw.WriteLine("Telefone: " + telefone);
                sw.WriteLine("RG: " + rg);
                sw.WriteLine("--------------------------------------------------");

                sw.Close();
            }
            else if (acao == "L")
            {
                StreamReader sr = new StreamReader(caminho);

                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                sr.Close();
            }
            else if (acao == "C")
            {
                Triangulo x, y;
                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Entre com as medidas do triangulo X:");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com as medidas do triangulo Y:");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                double areaX = x.Area();
                double areaY = y.Area();

                Console.WriteLine("Area de X = " + areaX.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Area de Y = " + areaY.ToString("F2", CultureInfo.InvariantCulture));

                if (areaX > areaY)
                {
                    Console.WriteLine("Maior area: X");
                }
                else
                {
                    Console.WriteLine("Maior area: Y");
                }

                //Console.Write("Informe seu RG: ");
                //rg = Console.ReadLine();

                StreamWriter sw = new StreamWriter(caminho, true);

                sw.WriteLine("Area do maior triângulo : " + areaX.ToString("F2", CultureInfo.InvariantCulture));
                sw.WriteLine("--------------------------------------------------");

                sw.Close();
            }


            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("### R - Calcular as propriedadas de um retângulo ###");
            Console.WriteLine("####### C - Comparar área 2 triângulos #############");
            Console.WriteLine("####### G - Gravar #################################");
            Console.WriteLine("####### L - Ler  ###################################");
            Console.WriteLine("####### S - Sair ###################################");
            Console.WriteLine("####################################################");
            Console.Write("Digite uma operação: ");

            acao = Console.ReadLine().ToUpper();
            Console.WriteLine();
        }
    }
}
