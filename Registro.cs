using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUsuarios
{
            public class Registro
        {
            public int Id { get; set; }
            public int IdUsuario { get; set; }
            public DateTime Data { get; set; }
            public string Categoria { get; set; } = "";
            public decimal Valor { get; set; }
            public string Descricao { get; set; } = "";
        }
}
