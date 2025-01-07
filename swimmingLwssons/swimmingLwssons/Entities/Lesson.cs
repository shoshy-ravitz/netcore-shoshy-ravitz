namespace swimmingLwssons.Entities
{
    public class Lesson
    {
        public int CodeLesson{ get; set; }
        public int NumLesson { get; set; }
        public int CodeGroup { get; set; }
        public DateOnly DateLesson { get; set; }
        public DateTime TimeStartLesson { get; set; }
        public DateTime TimeEndLesson { get;set; }
        public bool FreeSwimming { get; set; }
        public string LearntInLesson { get; set; }
    }
}
