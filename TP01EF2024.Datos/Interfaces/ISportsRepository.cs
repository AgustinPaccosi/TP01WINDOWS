﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Datos.Interfaces
{
    public interface ISportsRepository
    {
        void Agregar(Sport sport);
        void Editar(Sport sport);
        void Eliminar(Sport sport);
        bool EstaRelacionado(Sport sport);
        bool Existe(Sport sport);
        Sport? GetSportPorId(int id);
        List<Sport> GetSports();
        int GetCantidad();
        List<Sport>? GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);
        List<Shoe>? GetShoes(Sport? sport);
    }
}
