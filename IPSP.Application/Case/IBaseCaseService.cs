using Abp.Application.Services;
using IPSP.Case.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Case
{
    [ServiceContract]
    public interface IBaseCaseService : IApplicationService
    {
        [OperationContract]
        List<BaseCaseDto> GetBaseCaseByClient(int nClientId);
    }
}
