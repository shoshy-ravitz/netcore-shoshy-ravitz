using swimmingLwssons.Entities;
using System.Linq;
using swimmingLwssons.Entities;

namespace swimmingLwssons.Services
{
    public class GroupService
    {
        private DataContext dataContext = new DataContext();

        public List<Group> GetGroups()
        {
            return DataContext.Groups;
        }
        public Group GetGroupByCode(int CodeGroup)
        {
            return DataContext.Groups.FirstOrDefault((g) => g.CodeGroup == CodeGroup);
        }
        public bool AddGroup(Group group)
        {
            //---------cheking tz-------------//
            DataContext.Groups.Add(group);
            return true;
        }
        public bool UpdateGroup(int groupId, Group group)
        {
            foreach (Group g in DataContext.Groups)
            {
                if (g.CodeGroup == groupId)
                {
                    g.CodeGuide=group.CodeGuide;
                    g.CodeCourse=group.CodeCourse;
                    g.CountStudent=group.CountStudent;
                    g.MaxStudent=group.MaxStudent;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteGroup(int CodeGroup)
        {
            return DataContext.Groups.Remove(DataContext.Groups.FirstOrDefault((g) => g.CodeGroup == CodeGroup));
        }


    }
}
