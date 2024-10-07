string fraseDigitada, fraseComDislalia;
Console.Clear();
Console.Write("Digite uma frase:");
fraseDigitada = Console.ReadLine()!;
fraseComDislalia = fraseDigitada
    .Replace("r", "l")
    .Replace("R", "L");
Console.WriteLine(fraseComDislalia);