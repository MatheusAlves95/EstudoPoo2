using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstudoPoo2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //estudo de POO!//Ler as medidas dos lados de dois triângulos X e Y (suponha médidas válidas). Em seguida, mostrar o valor as áreas dos dois triangulos e dizer qual dos dois possui a maior área.
            //a fórmula utilizada para caucular a área a partir das medidas de seus lados a,b,c e a seguinte formuta de heron.
            //aqui feito sem POO depois vamos fazer com POO!


            Triangulo x, y;         //declarando variavel da class que criei.
            x = new Triangulo();     // instanciando com comando new as variaveis.
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");   //dar entrada do tamanho dos lados do triangulo X!
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //aqui agora é so colocar o (.) ponto depois do x ou y para dar entrada nos valores e ele já p
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");   //dar entrada do tamanho dos lados do triangulo Y!
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;                              //descobrindo o P ( faz parte da formula)
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));                       //usando o comando math.sqrt para caucular a raiz quadrada!

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));                      //CALCULANDO OS LADOS DO TRIANGULOS!

            Console.WriteLine("Área de X =" + areaX.ToString("F4", CultureInfo.InvariantCulture));  //imrpimir na tela área X
            Console.WriteLine("Área de Y =" + areaX.ToString("F4", CultureInfo.InvariantCulture));  // ''   '' '' ÁREA Y:

            if (areaX > areaY)                                     //If Else para mostrar qual maior área se é X ou Y!
            {
                Console.WriteLine("Maior área: X ");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            //para nao modificar o programa aqui, vou fazer com class em outro projeto! part 2
        }
    }
}
