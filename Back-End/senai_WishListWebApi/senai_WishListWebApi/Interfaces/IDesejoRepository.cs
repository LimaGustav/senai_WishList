using senai_WishListWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_WishListWebApi.Interfaces
{
    interface IDesejoRepository
    {
        /// <summary>
        /// Lista todos os desejos cadastrados
        /// </summary>
        /// <returns></returns>
        List<Desejo> ListarTodos();

        /// <summary>
        /// Cadastra um novo desejo
        /// </summary>
        /// <param name="novoDesejo">Objeto Desejo a ser cadastrado</param>
        /// <returns></returns>
        bool Cadastrar(Desejo novoDesejo);
    }
}
