using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");
            Console.WriteLine("Por favor, insira o seu peso em quilogramas:");
            double peso = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Agora, insira a sua altura em metros:");
            double altura = Double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua idade:");
            int idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, insira o seu sexo (M para masculino, F para feminino):");
            char sexo = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            double imc = peso / (altura * altura);
            
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            string estadoNutricional = ObterEstadoNutricional(imc, sexo);
            
            Console.WriteLine($"Seu estado nutricional é: {estadoNutricional}");
        }

        static string ObterEstadoNutricional(double imc, char sexo)
        {
            if (sexo == 'M' || sexo == 'F')
            {
                if (imc < 16)
                    return "Magreza grau III";
                else if (imc >= 16 && imc < 17)
                    return "Magreza grau II";
                else if (imc >= 17 && imc < 18.5)
                    return "Magreza grau I";
                else if (imc >= 18.5 && imc < 25)
                    return "Eutrofia";
                else if (imc >= 25 && imc < 30)
                    return "Sobrepeso";
                else if (imc >= 30 && imc < 35)
                    return "Obesidade Grau I";
                else if (imc >= 35 && imc < 40)
                    return "Obesidade Grau II";
                else
                    return "Obesidade Grau III";
            }
            else
            {
                return "Sexo inválido.";
            }
        }
    }
}


