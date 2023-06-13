using System.ComponentModel.DataAnnotations;

namespace BE_City_Asessment.Models
{
    public class ProductModel
    {
        public string ProductId;
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Original Price")]
        public double UnitPrice { get; set; }
        [Display(Name = "Price")]
        public string MarkupPrice
        {
            get
            {
                return (UnitPrice * 1.2).ToString("C2"); ;                
            }            
        }
        public int? MaximumQuantity { get; set; }
    }
}
