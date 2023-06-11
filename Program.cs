void reset(){
    Console.ResetColor();
}


void fundo(){
    Console.BackgroundColor = ConsoleColor.White;
}


fundo();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("--- Etanol ou Gasolina? ---");
reset();
fundo();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Digite o preço do etanol (R$).....:");
reset();
fundo();

decimal etanol = Convert.ToDecimal (Console.ReadLine()!.Trim());

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Digite o preço da gasolina (R$).....:");
reset();
fundo();

decimal gasolina = Convert.ToDecimal (Console.ReadLine()!.Trim());



decimal resultado = etanol / gasolina * 100;


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"O preço do etanol corresponde a {resultado:n1}%  do preço da gasolina.");
reset();
fundo();

string recomendacao;

if (resultado >= 73 ){
    recomendacao = "Gasolina";
}
else{
    recomendacao = "Etanol";
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Recomendação: Abasteça com {recomendacao}.");

reset();