using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Readings.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Novel> Novels { get; set; }
    }
}