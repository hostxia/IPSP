using Abp.Application.Services.Dto;
using IPSP.Case.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Client.Dto
{
    [DataContract]
    public class ClientDto : EntityDto
    {
        [DataMember]
        public new int Id { get; set; }

        [DataMember]
        public string s_Name { get; set; }

        [DataMember]
        public ICollection<BaseCaseDto> BaseCases { get; set; }
    }
}
