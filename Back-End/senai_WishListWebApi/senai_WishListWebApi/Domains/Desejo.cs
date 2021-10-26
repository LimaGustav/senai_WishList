using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_WishListWebApi.Domains
{
    public partial class Desejo
    {
        public byte IdDesejo { get; set; }

        [Required(ErrorMessage ="É necessário informar a qual usuário este desejo pertence")]
        public byte? IdUsuario { get; set; }

        [Required(ErrorMessage ="É necessário informar a descrição do desejo")]
        public string Descricao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
