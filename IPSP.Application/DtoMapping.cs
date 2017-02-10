using AutoMapper;
using IPSP.Case;
using IPSP.Case.Dto;
using IPSP.Client.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSP
{
    static class DtoMapping
    {
        public static void Map()
        {
            Mapper.CreateMap<BaseCase, BaseCaseDto>();
            Mapper.CreateMap<Contact.Client.Client, ClientDto>().ForMember(d => d.BaseCases, s => s.Ignore());
        }
    }
}
