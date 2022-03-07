namespace DesafioCapgemini2
{
    public class GarantirListaTamanhoImpar
    {
        /**O metodo apenas verifica o resultado do resto da divisão e retorna
         * verdadeiro ou falso, dependo do valor informado pelo usuário*/
        public bool VerificarNumeroImpar(int numeroDeVerificacao)
        {
            if (numeroDeVerificacao%2 != 0)
                return true;
            return false;
        }
    }
}
