using TechTalk.SpecFlow;
using BPCalculator;
using Xunit;
namespace UnitTestsBDD.Steps
{
    [Binding]
    public sealed class BPStepDefinitions{
         BloodPressure obj = new BloodPressure();

          private readonly ScenarioContext _scenarioContext;

       public BPStepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;
       }
       
       [Given(@"Set the systolic pressure as (.*)")]
       public void GivenSetTheSystolicPressureAs(int number){
            obj.Systolic = number;
       } 
       
       
       [When (@"Set dystolic pressure as (.*)")]
       public void GivenSetTheDiatolicPressureAs(int number){
            obj.Diastolic = number;
       }

       [Then (@"verify the category is low")]
       public void VerifyCategoryIsLow(){
            Assert.Equal(BPCategory.Low,obj.Category);
       } 

        [Then (@"verify the category is ideal")]
       public void VerifyCategoryIsIdeal(){
            Assert.Equal(BPCategory.Ideal,obj.Category);
       }

        [Then (@"verify the category is preHigh")]
       public void VerifyCategoryIsPreHigh(){
            Assert.Equal(BPCategory.PreHigh,obj.Category);
       }
        [Then (@"verify the category is High")]
       public void VerifyCategoryIsHigh(){
            Assert.Equal(BPCategory.High,obj.Category);
       }
    } 
}