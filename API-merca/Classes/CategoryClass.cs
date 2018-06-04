using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_merca.Classes
{
    public class CategoryClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public int layout { get; set; }
        public List<CategoryClass> categories { get; set; }
        public List<ProductClass> products { get; set; }
    }
}
