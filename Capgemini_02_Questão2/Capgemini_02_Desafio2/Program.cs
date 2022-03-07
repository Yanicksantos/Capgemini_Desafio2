using Capgemini_02_Desafio2;

ParesDiferencas paresDiferencas = new ParesDiferencas();
Console.Write("Digite o tamanho do vetor: ");
int n = int.Parse(Console.ReadLine());
int[] vetor = new int[n];

Console.Write("Entre com o valor x pra informarmamos a quantidade de diferenças pares " +
    "que se igualam a esse numero: ");
int x = int.Parse(Console.ReadLine());

Console.Write($"Agora pfv preencha seu vetor de {n} elementos: ");

for(int i = 0; i < n; i++)
{
    vetor[i] = int.Parse(Console.ReadLine());
}

/*Chamado o metodo ContandoAsDiferencasPossiveis do objeto paresDiferencas para fazer a 
 *contagem desses pares, caso existam. retorna esse valor e imprimimos na tela para 
 *informar ao usuário*/

int quantidade = paresDiferencas.ContandoAsDiferencasPossiveis(vetor, x);
Console.WriteLine("\n\n"+quantidade);