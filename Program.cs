decimal salario, FGTS, salLiq;
Console.WriteLine("\n+-----------------+");
Console.WriteLine("| CALCULADORA FGTS |");
Console.WriteLine("+-----------------+\n");

Console.Write("\nSalário (R$): ");
salario = Convert.ToDecimal(Console.ReadLine());

FGTS = salario * 8/100;

salLiq = salario - FGTS;

Console.WriteLine($"\nFGTS: R$ {FGTS:C2}");


Console.Write("Salário liquido: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine($"{salLiq:C2}\n");

Console.ResetColor();
