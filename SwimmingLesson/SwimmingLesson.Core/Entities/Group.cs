using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace swimmingLwssons.Entities
{
    [Table("group")]
    public class Group
    {
        [Key]
        public int CodeGroup { get; set; }//key
        public int CodeGuide { get; set; }
        public int MaxStudent { get; set; }
        public int CountStudent { get; set; }
        public int CodeCourse { get; set; }//Key
    }
}
