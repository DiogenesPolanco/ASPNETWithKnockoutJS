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
    public class PostProflie : Profile
    {
        public PostProflie()
        {
            CreateMap<Post, PostViewModel>()
                 .ForMember(viewmodel => viewmodel.Number, m => m.MapFrom(entity => entity.PostId))
                 .ForMember(viewmodel => viewmodel.DateShort, m => m.MapFrom(entity => entity.Date.ToShortDateString()));
        }
    }
}
