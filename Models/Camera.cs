using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Narcosis101.Models
{
    public class Camera
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}