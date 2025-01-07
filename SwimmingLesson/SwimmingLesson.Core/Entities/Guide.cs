using System.ComponentModel.DataAnnotations;

namespace swimmingLwssons.Entities
{
    public class Guide
    {
        [Key]
        public int Id { get; set; }//key
        public string Name { get; set; }
        public string Tz { get; set; }

        public DateTime DateBirth { get; set; }
        public int Seniority { get; set; }//ותק        
        public double Salary { get; set; }

    }
}
