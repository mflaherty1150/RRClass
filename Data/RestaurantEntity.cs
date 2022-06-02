using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterMVC.Data
{
    public class RestaurantEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Location { get; set; }
        public double Score
        {
            get
            {
                return Ratings.Count > 0 ? Ratings.Select(r => r.Score).Sum() / Ratings.Count : 0;
            }
        }
        public virtual List<RatingEntity> Ratings { get; set; } = new List<RatingEntity>();
    }
}