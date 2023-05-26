int glicemia;
string diagnostico; 
ConsoleColor corExibicao;

Console.WriteLine(" -Diabetes Gestacional- \n ");

Console.Write("Glicemia (em mg/dL...:)");

glicemia = Convert.ToInt32(Console.ReadLine());

if (glicemia > 126)
{
    diagnostico = "Diabetes na gravidez";
    corExibicao = ConsoleColor.DarkMagenta;
}
else
{
    if (glicemia >= 92)
    {
        diagnostico = "Compatível com Diabetes Gestacional";
        corExibicao = ConsoleColor.Blue;
    }
    else
    {
        diagnostico = "Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose";
        corExibicao = ConsoleColor.Green;
    }
}

Console.ForegroundColor = corExibicao;

Console.WriteLine();
Console.WriteLine(diagnostico);

Console.ResetColor();