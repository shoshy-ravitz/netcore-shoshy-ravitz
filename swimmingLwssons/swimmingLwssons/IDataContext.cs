using swimmingLwssons.Entities;

namespace swimmingLwssons
{
    public interface IDataContext
    {
        public List<Course> Load();
        public bool Save(List<Course> courses);


    }
}
