﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2F.Modelos.Entidades
{
   public class Cliente
    {
        public int Id { get; set; }
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
