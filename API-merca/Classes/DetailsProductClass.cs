using System.Collections.Generic;

namespace API_merca.Classes
{
    public class DetailsProductClass
    {
        public string brand { get; set; }
        public string origin { get; set; }
        public List<SuppliersClass> suppliers { get; set; }
        public string legal_name { get; set; }
        public string description { get; set; }
        public string counter_info { get; set; }
        public string danger_mentions { get; set; }
        public string alcohol_by_volume { get; set; }
        public string mandatory_mentions { get; set; }
        public string production_variant { get; set; }
        public string usage_instructions { get; set; }
        public string storage_instructions { get; set; }
    }
}