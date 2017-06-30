using AutoMapper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Utils
{
    public class BlogProflie : Profile
    {
        public BlogProflie()
        {
            CreateMap<Blog, BlogViewModel>()
              .ForMember(viewmodel => viewmodel.Number, m => m.MapFrom(entity => entity.BlogId));
        }
    }
}
