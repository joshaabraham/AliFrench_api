using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAliFrench.Models
{
    public class ProductFeaturesSection
    {
         public string general { get; set; } 
         public List<Feature> general_features { get;set;}

        public string dimension { get; set; }
        public List<Feature> dimension_features { get; set; }


    }
}
