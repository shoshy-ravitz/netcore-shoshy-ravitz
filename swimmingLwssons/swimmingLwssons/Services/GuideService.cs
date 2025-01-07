using swimmingLwssons.Entities;

namespace swimmingLwssons.Services
{
    public class GuideService
    {
        private DataContext dataContext = new DataContext();

        public List<Guide> GetGuides()
        {
            return DataContext.Guides;
        }
        public Guide GetGuideByCode(int guideId)
        {

            return DataContext.Guides.FirstOrDefault((g) => g.Id == guideId);
               
        }
        public bool AddGuide(Guide guide)
        {
            //---------cheking tz ,-------------//
            //-------add in guide for course---------//
            DataContext.Guides.Add(guide);
            return false;
        }
        public bool UpdateGuide(int guideId, Guide guide)
        {
            //-------add in guide for course---------//
            foreach(Guide g in DataContext.Guides)
            {
                if(g.Id == guideId)
                {
                    g.Seniority = guide.Seniority;
                    g.DateBirth = guide.DateBirth;
                    g.Salary = guide.Salary;
                    g.Name = guide.Name;
                    g.Tz= guide.Tz;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteGuide(int guideId)
        {
           return DataContext.Guides.Remove(DataContext.Guides.FirstOrDefault((g)=>g.Id== guideId));
        }
    }
}
