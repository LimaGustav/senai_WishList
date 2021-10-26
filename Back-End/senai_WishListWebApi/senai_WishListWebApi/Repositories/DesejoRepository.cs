using senai_WishListWebApi.Context;
using senai_WishListWebApi.Domains;
using senai_WishListWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_WishListWebApi.Repositories
{
    public class DesejoRepository : IDesejoRepository
    {
        WishListContext ctx = new WishListContext();

        public bool Cadastrar(Desejo novoDesejo)
        {
            ctx.Desejos.Add(novoDesejo);

            ctx.SaveChanges();

            return true;
        }

        public List<Desejo> ListarTodos()
        {
            return ctx.Desejos.
                Select(d => new Desejo() 
                {
                    IdDesejo = d.IdDesejo,
                    IdUsuario = d.IdUsuario,
                    Descricao = d.Descricao,
                    IdUsuarioNavigation = (new Usuario() 
                    {
                        IdUsuario = d.IdUsuarioNavigation.IdUsuario,
                        Email = d.IdUsuarioNavigation.Email,
                    })
                }).
                ToList();
        }
    }
}
