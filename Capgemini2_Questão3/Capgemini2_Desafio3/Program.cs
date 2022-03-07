
using Capgemini2_Desafio3;

Console.WriteLine("Olá, Seja bem vindo!");
Console.Write("Digite a string (texto) que deseja encriptar: ");

string? s = Console.ReadLine();
Console.WriteLine(s);
string semEspacos = s.Replace(" ",""); // Apagar todos os espaços

/*Todo Encripação do texto é feita na class Ecriptação atraves do método Encriptar*/
Encriptacao encriptacao = new Encriptacao(); 
encriptacao.Encriptar(semEspacos);