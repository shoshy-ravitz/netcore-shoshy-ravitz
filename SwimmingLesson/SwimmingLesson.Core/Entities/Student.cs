using System.ComponentModel.DataAnnotations;

namespace swimmingLwssons.Entities
{
    public enum HealthFund
    {
        MACABI, CLALIT, MEHUCHEDET, LEHUMIT
    }
    public class Student
    {
        [Key]
        public int CodeStudent { get; set; }//key
        public string Name { get; set; }
        public string Tz { get; set; }
        public DateTime DateBirth { get; set; }
        public HealthFund HealthFund { get; set; }
        public int CodeCourse { get; set; }//key in Guide
        public double Price { get; set; }
        public int ProofPayment { get; set; }
        public int CodeGroup { get; set; }//key
        public double Mark { get; set; }

    }
}
