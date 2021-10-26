using System;
using System.Collections.Generic;

#nullable disable

namespace senai_WishListWebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Desejos = new HashSet<Desejo>();
        }

        public byte IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Desejo> Desejos { get; set; }
    }
}
