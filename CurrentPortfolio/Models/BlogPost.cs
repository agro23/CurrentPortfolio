using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CurrentPortfolio.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        public virtual User User { get; set; }
        public virtual Comment Comment { get; set; }
    }
}

/*
 [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public override bool Equals(System.Object otherProduct)
        {
            if (!(otherProduct is Product))
            {
                return false;
            }
            else
            {
                Product newProduct = (Product)otherProduct;
                return this.ProductId.Equals(newProduct.ProductId);
            }
        }

        public override int GetHashCode()
        {
            return this.ProductId.GetHashCode();
        }

        public int GetAvgRate(Product product)
        {
            if (product.Reviews.Count > 0)
            {
                List<int> ratings = new List<int>();
                foreach (var rev in product.Reviews)
                {
                    ratings.Add(rev.rating);
                }
                int avgRate = (int)Math.Round(ratings.Average());
                return avgRate;
            } else {
                return 0;
            }
        }
    }
 
     */
