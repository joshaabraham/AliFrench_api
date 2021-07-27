using System.Collections.Generic;

namespace ApiAliFrench.Models
{

    public class Category
    {
        public int id { get; set; }
        public enum Type { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string path { get; set; }
        public string image { get; set; }
        public int items { get; set; }
        public CustomFields customFields { get; set; }
        public List<Category> parents { get; set; }
        public List<Category> children {get;set;}
    }

    public enum  Categorie
    {
        Special_Offers, Latest_News, New_Arrivals

    }
    public enum Type
    {
       shop,blog

    }
}