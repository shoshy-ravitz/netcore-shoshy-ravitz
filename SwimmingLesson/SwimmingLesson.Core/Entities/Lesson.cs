using System.ComponentModel.DataAnnotations;

namespace swimmingLwssons.Entities
{
    public class Lesson
    {
        [Key]
        public int CodeLesson{ get; set; }
        public int NumLesson { get; set; }
        public int CodeGroup { get; set; }
        public DateTime DateLesson { get; set; }
        public DateTime TimeStartLesson { get; set; }
        public DateTime TimeEndLesson { get;set; }
        public bool FreeSwimming { get; set; }
        public string LearntInLesson { get; set; }
    }
}
