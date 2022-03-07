namespace Capgemini_02_Desafio2
{
    public class ParesDiferencas
    {
        /**O método recebe o vetor e o valor de x para verificação dos pares
         * onde a diferença é igual a x.
         * A extrutura de repetição verifica todas as possibilidades de diferenca
         * no vetor
         */
        public int ContandoAsDiferencasPossiveis(int[] vetor, int x)
        {
            int cont =0;
            for(int i = 0; i < vetor.Length; i++)
            {
                for(int j = i+1; j < vetor.Length; j++)
                {
                    int diferenca = vetor[i] - vetor[j];
                    if(diferenca <0) /* garantindo que toda diferença seja considerada como 
                                      * resultado positivo*/
                        diferenca *= -1;
                    if(diferenca == x)
                        cont++;
                }
            }
            return cont; // retornando a quantidade pares possiveis 
        }
    }
}
