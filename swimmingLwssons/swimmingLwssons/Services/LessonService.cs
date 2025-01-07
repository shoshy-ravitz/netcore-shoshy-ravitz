using swimmingLwssons.Entities;

namespace swimmingLwssons.Services
{
    public class LessonService
    {
        private DataContext dataContext = new DataContext();

        public List<Lesson> GetLessons()
        {
            return DataContext.Lessons;
        }
        public Lesson GetLessonByCode(int CodeLesson)
        {
            return DataContext.Lessons.FirstOrDefault((l) => l.CodeLesson == CodeLesson);
        }
        public bool AddLesson(Lesson lesson)
        {
            //---------cheking tz-------------//
            DataContext.Lessons.Add(lesson);
            return true;
        }
        public bool UpdateLesson(int lessonId, Lesson lesson)
        {
            foreach (Lesson l in DataContext.Lessons)
            {
                if (l.CodeLesson == lessonId)
                {
                    l.LearntInLesson = lesson.LearntInLesson;
                    l.NumLesson = lesson.NumLesson;
                    l.DateLesson = lesson.DateLesson;
                    l.TimeEndLesson = lesson.TimeEndLesson;
                    l.CodeGroup = lesson.CodeGroup;
                    l.FreeSwimming = lesson.FreeSwimming;
                    l.TimeEndLesson= lesson.TimeEndLesson;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteLesson(int CodeLesson)
        {
            return DataContext.Lessons.Remove(DataContext.Lessons.FirstOrDefault((l) => l.CodeLesson == CodeLesson));
        }


    }
}
