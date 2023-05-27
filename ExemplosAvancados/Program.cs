// See https://aka.ms/new-console-template for more information


Transformer t = Square;              // Criação de um tipo delegate
int result = t(3);                   // Invocação do delegate
Console.WriteLine(result);           // 9

int Square (int x) => x * x;

delegate int Transformer(int x); 
