using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace swimmingLwssons.Entities
{
    public enum KindSwim
    {
        //to fill in 
        //רגיל ,חתירה,מתקדם,...
    }
    [Table("course")]
    public class Course
    {
        //public KindSwim KindSwim { get; set; }
        [Key]
        public int CodeCourse { get; set; }//key
        public int CountLessons { get; set; }
        public double Price { get; set; }
    }
}