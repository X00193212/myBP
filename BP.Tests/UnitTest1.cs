using Xunit;
using BPCalculator;
namespace BP.Tests;


public class UnitTest1
{
    BloodPressure obj = new BloodPressure();
    [Fact]
    public void verifyLowBP() 
    {
        
        obj.Systolic = 90;
        obj.Diastolic = 60;
        Assert.Equal(BPCategory.Low,obj.Category);
    }

    [Fact]
    public void verifyIdealBP(){
      
        obj.Systolic = 110;
        obj.Diastolic = 75;
        Assert.Equal(BPCategory.Ideal,obj.Category);
         
    }
    [Fact]
    public void verifyPreHighBP()
    {
       
        obj.Systolic = 130;
        obj.Diastolic = 85;
        Assert.Equal(BPCategory.PreHigh,obj.Category);
    }
    [Fact]
    public void verifyHighBP(){
       
        obj.Systolic = 150;
        obj.Diastolic = 95;
        Assert.Equal(BPCategory.High,obj.Category);
    }
}