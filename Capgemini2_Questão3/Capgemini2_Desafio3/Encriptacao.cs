namespace Capgemini2_Desafio3
{
    public class Encriptacao
    {
        public void Encriptar(string s)
        {
            bool testarNuloOuVazio = String.IsNullOrEmpty(s);
            if (testarNuloOuVazio)
                throw new Exception("Sem conteudo para Ecriptamento\n");

            /*Variavel numero vai receber o resultado da raíz quadrada do tamanho da string*/
            int numero = (int)Math.Ceiling(Math.Sqrt(s.Length)); // Arrendondado para cima

            /*A estrutura de repetição tem a função de imprimir cada carater na tela 
             *Após ter conhecimento do valor de numero, eu decide imprimir cada caracter 
             *com intervalo equivalente a quantidade de numero (previamente calculado)
             *Ex: considerando numero =2, apos digitar na tela o primeiro caracter, a proxima letra 
             *será aquela cuja a sua distancia da letra já digitada, seja igual 2.
             */
            for (int i = 0; i < numero; i++) /*Esse processo considera as primeiras letras no 
                                               intervalo 0 a numero*/
            {
                Console.Write(s[i]);
                for (int j = i + numero; j < s.Length; j += numero)
                {
                    Console.Write(s[j]);
                }
                Console.Write(" ");
            }
        }
    }
}
