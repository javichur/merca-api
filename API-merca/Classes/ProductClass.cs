using System.Collections.Generic;

namespace API_merca.Classes
{
    public class ProductClass
    {
        public string id { get; set; } // no puede ser int; hay productos con id que no es int.
        public int limit { get; set; }
        public BadgesClass badges { get; set; }
        public string packaging { get; set; }
        public string thumbnail { get; set; }
        public string display_name { get; set; }
        public bool bunch_selector { get; set; }
        public PriceInstructionsClass price_instructions { get; set; }

        // params only in /product details API:
        public string ean { get; set; }
        public string brand { get; set; }
        public string origin { get; set; }
        public List<PhotoClass> photos { get; set; }
        public DetailsProductClass details { get; set; }

        public CategoriesLevelsClass categories { get; set; }

        public List<string> extra_info { get; set; }

        public string usage_instructions { get; set; } // duplicado en DetailsProductClass
        public string storage_instructions { get; set; } // duplicado en DetailsProductClass
        public NutritionInformationClass nutrition_information { get; set;}
    }
}