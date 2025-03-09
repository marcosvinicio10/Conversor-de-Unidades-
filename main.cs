using System;
using System.Globalization;

class Program {
    static void Main() {
        while (true) {
            Console.Clear();
            Console.WriteLine("=== Conversor de Unidades ===");
            Console.WriteLine("Escolha o tipo de conversão:");
            Console.WriteLine("1 - Temperatura (Celsius ↔ Fahrenheit)");
            Console.WriteLine("2 - Moeda (BRL ↔ USD)");
            Console.WriteLine("3 - Medidas (Metros ↔ Quilômetros)");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "0") break;

            switch (opcao) {
                case "1":
                    ConverterTemperatura();
                    break;
                case "2":
                    ConverterMoeda();
                    break;
                case "3":
                    ConverterMedidas();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void ConverterTemperatura() {
        Console.Clear();
        Console.WriteLine("=== Conversão de Temperatura ===");
        Console.WriteLine("Escolha a unidade de entrada:");
        Console.WriteLine("1 - Celsius");
        Console.WriteLine("2 - Fahrenheit");
        Console.Write("Opção: ");
        string opcaoEntrada = Console.ReadLine();

        Console.Write("Informe o valor: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = 0;
        string unidadeSaida = "";

        if (opcaoEntrada == "1") {  // Celsius para Fahrenheit
            resultado = (valor * 9 / 5) + 32;
            unidadeSaida = "Fahrenheit";
        } else if (opcaoEntrada == "2") {  // Fahrenheit para Celsius
            resultado = (valor - 32) * 5 / 9;
            unidadeSaida = "Celsius";
        } else {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.WriteLine($"Resultado: {resultado.ToString("F2", CultureInfo.InvariantCulture)} {unidadeSaida}");
    }

    static void ConverterMoeda() {
        Console.Clear();
        Console.WriteLine("=== Conversão de Moeda ===");
        Console.WriteLine("Escolha a unidade de entrada:");
        Console.WriteLine("1 - BRL (Real)");
        Console.WriteLine("2 - USD (Dólar)");
        Console.Write("Opção: ");
        string opcaoEntrada = Console.ReadLine();

        Console.Write("Informe o valor: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Taxa de câmbio fictícia
        double taxaCambio = 5.0;  // 1 USD = 5 BRL

        double resultado = 0;
        string unidadeSaida = "";

        if (opcaoEntrada == "1") {  // BRL para USD
            resultado = valor / taxaCambio;
            unidadeSaida = "USD";
        } else if (opcaoEntrada == "2") {  // USD para BRL
            resultado = valor * taxaCambio;
            unidadeSaida = "BRL";
        } else {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.WriteLine($"Resultado: {resultado.ToString("F2", CultureInfo.InvariantCulture)} {unidadeSaida}");
    }

    static void ConverterMedidas() {
        Console.Clear();
        Console.WriteLine("=== Conversão de Medidas ===");
        Console.WriteLine("Escolha a unidade de entrada:");
        Console.WriteLine("1 - Metros");
        Console.WriteLine("2 - Quilômetros");
        Console.Write("Opção: ");
        string opcaoEntrada = Console.ReadLine();

        Console.Write("Informe o valor: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = 0;
        string unidadeSaida = "";

        if (opcaoEntrada == "1") {  // Metros para Quilômetros
            resultado = valor / 1000;
            unidadeSaida = "Quilômetros";
        } else if (opcaoEntrada == "2") {  // Quilômetros para Metros
            resultado = valor * 1000;
            unidadeSaida = "Metros";
        } else {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.WriteLine($"Resultado: {resultado.ToString("F2", CultureInfo.InvariantCulture)} {unidadeSaida}");
    }
}
