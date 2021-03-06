﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyBus.Models
{
    public struct Localizacion
    {
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Estacion { get; set; }

        public override string ToString()
        {
            return $"{Estacion} - {Ciudad}, { Estado}, {Pais}";
        }
    }
}
