﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enum;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IGenresService
    {
        void Guardar(Genre genre);
        void Eliminar(Genre genre);
        bool Existe(Genre genre);
        bool EstaRelacionado(Genre genre);
        Genre? GetGenrePorId(int id);
        List<Genre> GetGenres();
        int GetCantidad();
        List<Genre>? GetListaPaginadaOrdenada(int page, int pageSize, Orden? orden = null);
        List<Shoe>? GetShoes(Genre? genre);

    }
}

