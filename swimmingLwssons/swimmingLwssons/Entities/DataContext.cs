using System.Text.Json;

namespace swimmingLwssons.Entities
{
    public class DataContext:IDataContext
    {
        public static List<Course> Courses { get; set; }=new List<Course>() { new Course() { CodeCourse=2,CountLessons=3,Price=100} };
        public static List<Student> Students { get; set; } = new List<Student>();
        public static List<Guide> Guides { get; set; } = new List<Guide>();
        public static List<Lesson> Lessons { get; set; } = new List<Lesson>();
        public static List<Group> Groups { get; set; } = new List<Group>();
        public List<Course> Load()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");


            string jsonString = File.ReadAllText(path);
            var AllDonrs = JsonSerializer.Deserialize<Course>(jsonString);

            return AllDonrs.db;



        }

    }
}
