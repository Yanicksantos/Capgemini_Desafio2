using DesafioCapgemini2;
GarantirListaTamanhoImpar tamanhoImpar = new GarantirListaTamanhoImpar();
OrdenarLista ordenarLista = new OrdenarLista();
Mediana mediana = new Mediana();
List<int> lista = new List<int>();
List<int> listaOrdenada = new List<int>();

Console.Write("Olá, Informe quantos numeros deseja ter na sua lita pfv(necessario ser impar): ");
int tamanhoLista = int.Parse(Console.ReadLine());

/**Escolhi realizar algumas tarefas simples atraves de class e método simples
 * o método VerificarNumeroImpar é chamado apenas para confirmar se o numero 
 * é impar ou par
 */
bool confirmar = tamanhoImpar.VerificarNumeroImpar(tamanhoLista);

if (confirmar)
{
    Console.WriteLine("pfv preencha o a lista: ");
    for (int i = 0; i < tamanhoLista; i++)
    {
        int numero = int.Parse(Console.ReadLine()); // preenchendo a lista
        lista.Add(numero);
    }
   listaOrdenada.AddRange(ordenarLista.OrdenandoALista(lista)); /*Solicitando a ordenação dela*/
    Console.Write("Sua lista Ordenada: ");
    foreach(int i in listaOrdenada) // Serve apaenas para mostrar na tela a lista ordenada
        Console.Write(i+" ");
    int posicaoMediana = mediana.AcharMediana(tamanhoLista); /*chamada do método que sera responsavel
                                                              por encontrar a mediana*/
    Console.WriteLine();
    Console.WriteLine(listaOrdenada[posicaoMediana]); // Apresentando a mediana para o usuário
}
else
    Console.WriteLine("Voce digitou um numero par\n" +
        "Pfv, na proxima digite um tamanho impar para o seu vetor");


