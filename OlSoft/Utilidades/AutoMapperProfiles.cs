using AutoMapper;
using OlSoft.DTOs;
using OLSofwareDos.Models;

namespace OlSoft.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PruebaSeleccion, PruebasDTO >();
            CreateMap<PruebasDTO, PruebaSeleccion>();
            CreateMap<Aspirante, AspiranteDTO>();
            CreateMap<AspiranteDTO, Aspirante>();

        }

    }
}
