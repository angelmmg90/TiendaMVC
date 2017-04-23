using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiendaMVC.CORE;
using TiendaMVC.Web.Models;

namespace TiendaMVC.Web.App_Start
{
    /// <summary>
    /// Clase para configurar el Automapper
    /// </summary>
    public class AutomapperConfig
    {
        /// <summary>
        /// Configurar automapper
        /// </summary>
        public static void Configure() 
        {
            //Convierte del CategoryViewModel a Category
            Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Category, CategoryViewModel>();
                    cfg.CreateMap<CategoryViewModel, Category>();

                    cfg.CreateMap<Category, CategoryListViewModel>()
                        .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => src.Parent.Name));
                }
            );
                
        }
    }
}