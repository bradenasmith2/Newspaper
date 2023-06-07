using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Article> Articles { get; set; }
    }
}
