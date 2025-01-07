namespace swimmingLwssons.Entities
{
    public enum KindSwim
    {
        //to fill in 
        //רגיל ,חתירה,מתקדם,...
    }
    public class Course
    {
        public KindSwim KindSwim { get; set; }
        public int CodeCourse { get; set; }//key
        public int CountLessons { get; set; }
        public double Price { get; set; }
    }
}