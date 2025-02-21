﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TP01EF2024.Datos;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Datos.Repositorios;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Servicios.Servicios;

namespace TP01EF2024.InversionOfControl
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var servicios = new ServiceCollection();

            //REPOSITORIOS

            servicios.AddScoped<IGenresRepository, GenresRepository>();

            servicios.AddScoped<IBrandsRepository, BrandsRepository>();

            servicios.AddScoped<IColoursRepository, ColoursRepository>();

            servicios.AddScoped<ISportsRepository, SportsRepository>();

            servicios.AddScoped<IShoesRepository, ShoesRepository>();

            servicios.AddScoped<ISizesRepository, SizesRepository>();


            //SERVICIOS

            servicios.AddScoped<IGenresService, GenresService>();

            servicios.AddScoped<IBrandsService, BrandsService>();

            servicios.AddScoped<IColoursService, ColoursService>();

            servicios.AddScoped<ISportsService, SportsService>();

            servicios.AddScoped<IShoesService, ShoesService>();

            servicios.AddScoped<ISizesService, SizesServices>();

            //UNIT

            servicios.AddScoped<IUnitOfWork, UnitOfWork>();

            servicios.AddDbContext<TPDbContext>(optiones =>
            {
                optiones.UseSqlServer(@"Data Source =.;
                            Initial Catalog = TP01EF2024;
                            Trusted_Connection = true;
                            TrustServerCertificate = true;");
            });

            return servicios.BuildServiceProvider();
        }

    }
}
