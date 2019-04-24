using FinalProject.BusinessLogic.Dto;
using FinalProject.BusinessLogic.Extensions;
using FinalProject.DataLayer.Repositories;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Services
{
    public interface ITestService
    {
        List<TestDto> GetTestList();

        TestDto GetTestById(int Id);

        void Delete(int Id);

        void Update(Test test);

        void Add(Test test);
    }
    public class TestService : ITestService
    {
        private readonly TestRepository testRepository =
            new TestRepository();

        public void Add(Test test)
        {
            testRepository.AddTest(test);
            
        }

        public void Delete(int Id)
        {
            testRepository.DeleteTest(Id);
        }

        public TestDto GetTestById(int Id)
        {
            var test = testRepository.GetTestById(Id);

            return test.ToTestDto();
        }

        public void Update(Test test)
        {
            testRepository.UpdateTest(test);
        }

        public List<TestDto> GetTestList()
        {
            var testList = testRepository.GetListOfTest();

            return testList.Select(x => x.ToTestDto()).ToList();
        }
    }
}
