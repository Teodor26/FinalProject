using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class TestExtension
    {
        public static TestDto ToTestDto(this Test test)
        {
            if (test == null)
                return null;

            var testDto = new TestDto
            {
                Id = test.Id,
                ModulesList = test.Modules.Select(x => x.ToModuleDto()).ToList(),
                QuestionsList = test.Questions.Select(x => x.ToQuestionDto()).ToList(),
                TestPassingsList = test.TestPassings.Select(x => x.ToTestPassingDto()).ToList()
            };

            return testDto;
        }
    }
}
