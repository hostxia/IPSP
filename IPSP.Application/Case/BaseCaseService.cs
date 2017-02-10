using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Localization;
using AutoMapper;
using IPSP.Case.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Case
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class BaseCaseService : IPSPAppServiceBase, IBaseCaseService
    {

        private readonly IRepository<BaseCase> _repositoryBaseCase;

        public BaseCaseService(IRepository<BaseCase> repositoryBaseCase)
        {
            _repositoryBaseCase = repositoryBaseCase;
        }

        //[UnitOfWork(isTransactional: false)]
        public List<BaseCaseDto> GetBaseCaseByClient(int nClientId)
        {
            //Logger.InfoFormat(L("SearchClient") + "{0}", nClientId);
            var listBaseCase = _repositoryBaseCase.GetAll().Where(c => c.TheClient.Id == nClientId).ToList();
            var client = listBaseCase[0].TheClient;
            var listBaseCaseDto = Mapper.Map<List<BaseCaseDto>>(listBaseCase);
            return listBaseCaseDto;
        }
    }

}
