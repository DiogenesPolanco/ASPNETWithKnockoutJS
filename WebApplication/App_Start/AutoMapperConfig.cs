using AutoMapper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utils;
using ViewModel;

namespace WebApplication.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => { 
                cfg.AddProfile<BlogProflie>();
                cfg.AddProfile<PostProflie>();
            });
              
        }
    }
}