using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCapgemini2
{
    public class OrdenarLista
    {
        /**Estrutura de código um pouco mais robusta mas funciona perfeitamente. 
         *Toda vez que o elemento posterior da lista for menor que o atual 
         *é feita a troca, com ajuda de uma variavel auxiliar*/
        public List<int> OrdenandoALista(List<int> lista)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                for(int j = i+1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[i])
                    {
                        int aux = lista[j];
                        lista[j] = lista[i];
                        lista[i] = aux;
                    }
                }
            }
            return lista.ToList(); // retornando a lista após a sua ordenação
        }
    }
}
