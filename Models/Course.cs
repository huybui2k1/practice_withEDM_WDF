using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course
    {
        public Course() { 
        this.Students = new HashSet<Student>();

        }
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Credit { get; set; }
        public string Description { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get;set; }
    }
}
