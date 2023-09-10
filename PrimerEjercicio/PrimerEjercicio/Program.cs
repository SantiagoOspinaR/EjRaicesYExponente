/* Realizar un algoritmo que me pida 3 números por pantalla. Con el primero hallar la raíz
con el segundo la raíz cuadrada y con el tercero la raíz cubica*/

public class PrimerAlgortimo
{
    static void Main(string[] args)
    {
        // Primero, declarar las variables
        double num1, num2, num3, potencia, raizcuadrada, raizcubica;

        // Segundo, Asingnarle valor a las primeras variables
        Console.WriteLine("Ingrese su Primer número:");

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su Segundo número:");

        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese su Tercer número:");

        num3 = Convert.ToInt32(Console.ReadLine());

        potencia = num1 * num1;

        raizcuadrada = Math.Sqrt(num2);

        raizcubica = Math.Cbrt(num3);

        Console.Write("El cuadrado de su primer número es:" + potencia);
        Console.WriteLine("\n");
        Console.WriteLine("La raíz cuadrada de su segundo número es:" + raizcuadrada);
        Console.WriteLine("\n");
        Console.WriteLine("La raíz cubicavde su tercer número es:" + raizcubica);


    }




}
    


    