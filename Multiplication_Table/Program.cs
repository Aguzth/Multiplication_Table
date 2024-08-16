/*
Multiplication Table:
Create a program that asks the user for a number and displays its multiplication table from 1 to 10.
*/

using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Multiplication_Table
{
    class Multiplication
    {
        static void Main(String[] args)
        {
            int userAnswer = 0;
            string aux;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                aux = Console.ReadLine();
                Product(userAnswer = NumVerification(aux));

                Console.Write("\nDesea continuar?\nEscriba 1 para Sí o pulse cualquier tecla para salir: ");
                aux = Console.ReadLine();
                userAnswer = NumVerification(aux);

                if(userAnswer != 1)
                    break;
                Console.Clear();
            } while (userAnswer == 1);
        }
        static void Product(int num)
        {
            int resultMultiplication = 0;
            for (int i = 1; i <= 10; i++)
            {
                resultMultiplication = num * i;
                Console.WriteLine($"{num} x {i}\t = {num * i}.") ;
            } 
        }
        static int NumVerification(string Input)
        {
            string input = Input;
            bool isInteger = int.TryParse(input, out int resultInt);

            while (!isInteger)
            {
                Console.WriteLine("La entrada no es un entero o un número.\n");
                Console.WriteLine("Ingrese un número: ");
                input = Console.ReadLine();
                isInteger = int.TryParse(input, out resultInt);                
            }
            return resultInt;
        }
    }
}