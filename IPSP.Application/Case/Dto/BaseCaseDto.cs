using Abp.Application.Services.Dto;
using IPSP.Client.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Case.Dto
{
    [DataContract]
    public class BaseCaseDto : EntityDto
    {
        [DataMember]
        public new int Id { get; set; }

        [DataMember]
        public int n_ClientID { get; set; }

        [DataMember]
        public string s_CaseName { get; set; }

        [DataMember, Required(ErrorMessageResourceName = "CaseSerialRequire")]
        public string s_CaseSerial { get; set; }

        [DataMember]
        public ClientDto TheClient { get; set; }
    }

}
