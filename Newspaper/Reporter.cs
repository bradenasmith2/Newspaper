using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class Reporter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public List<Article> Articles { get; set; }
    }
}
