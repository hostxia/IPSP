using Abp.Domain.Repositories;
using Abp.Modules;
using Abp.TestBase;
using IPSP;
using IPSP.Case;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Collections;

namespace IPSPApplicationService.MockTest
{
    [TestClass]
    public class BaseCaseServiceTest : AbpIntegratedTestBase
    {
        private readonly IBaseCaseService _baseCaseService;

        public BaseCaseServiceTest()
        {
            var client = new IPSP.Contact.Client.Client { Id = 1 };
            var listBaseCase = new List<BaseCase>()
            {
                new BaseCase {s_CaseName = "1111", TheClient = client},
                new BaseCase {s_CaseName = "2222" , TheClient = client}
            };
            var personRepository = Substitute.For<IRepository<BaseCase>>();
            personRepository.GetAll().Returns(listBaseCase.AsQueryable());
            _baseCaseService = new BaseCaseService(personRepository);
        }

        protected override void AddModules(ITypeList<AbpModule> modules)
        {
            modules.Add<IPSPDataModule>();
            modules.Add<IPSPApplicationModule>();
            base.AddModules(modules);
        }

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(_baseCaseService.GetBaseCaseByClient(1).Count, 2);
        }
    }
}
