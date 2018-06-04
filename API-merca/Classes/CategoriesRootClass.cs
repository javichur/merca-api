using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_merca.Classes
{
    public class CategoriesRootClass
    {
        public string next { get; set; }
        public int count { get; set; }
        public List<CategoryClass> results { get; set; }
    }
}
