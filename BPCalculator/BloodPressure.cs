using System;
using System.ComponentModel.DataAnnotations;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name="Low Blood Pressure")] Low,
        [Display(Name="Ideal Blood Pressure")]  Ideal,
        [Display(Name="Pre-High Blood Pressure")] PreHigh,
        [Display(Name ="High Blood Pressure")]  High,
          [Display(Name ="Not defined Blood Pressure")]  NotDefined
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        // calculate BP category
        public BPCategory Category
        {
           get
            {
                //implement as part of project
               if((Systolic >= SystolicMin && Systolic <= 90) && (Diastolic >= DiastolicMin && Diastolic <=60)){
                   return BPCategory.Low;
                }
                //ideal
                else if((Systolic<=120 && Systolic >=91)  && (Diastolic >60 && Diastolic<=80)){
                    return BPCategory.Ideal;
                }
                //pre-high
                else if((Systolic<=140 && Systolic >=120 ) && (Diastolic >80 && Diastolic<=90)){
                    return BPCategory.PreHigh;
                }
                //high
                 else if((Systolic<=190 && Systolic >=141 ) && (Diastolic >90 && Diastolic<=100)){
                    return BPCategory.High;
                }
                else{
                    return BPCategory.NotDefined; 
                }
                     
            }
        }
    }
}
