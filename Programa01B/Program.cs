
using Programa01B;

Console.WriteLine("******SISTEMA LOJA BAKE");
Console.WriteLine();

//INSTANCIANDO
Bikec bike = new Bikec( );

Console.WriteLine("Modelo");
bike.Modelo = Console.ReadLine ();

Console.WriteLine("Bateria");
bike.Bateria = double.Parse(Console.ReadLine());

Console.WriteLine("Peso da Bateria");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade estimada de recargas");
bike.RecargaMes = int.Parse(Console.ReadLine());

//
Console.WriteLine("\n---RELATORIO DE DESEMPENHO");
Console.WriteLine($"Bake: {bike.Modelo.ToUpper()}:");
Console.WriteLine($"Autonomia Estimada: {bike.CalcularAutonomia():F1}por carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMensal():F2}NK");
Console.WriteLine($"A Bake é Economica: {bike.BikeEconomica()}");