using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarRentalSystemApp.Models;
using CarRentalSystemApp.DTO;

namespace CarRentalSystem.Helpers.Mapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Araclar, AraclarDTO>();
            CreateMap<KiralikBilgi, KiralikBilgiDTO>();
            CreateMap<Sirket, SirketDTO>();
            CreateMap<Musteriler, MusterilerDTO>();
            CreateMap<Calisanlar, CalisanlarDTO>();
            CreateMap<RezervasyonBilgi, RezervasyonBilgiDTO>();

        }
    }
}
