using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLModels
{
    public class Genre : IModels
    {
        private string name;
        private string img;
        private ICollection<Movie> movies;
        
        public int Id { get; set; }
        [MaxLength(40)]
        [Required]
        public string Name { get => name; set => name = value; }
        [Required]
        public string Img { get => img; set => img = value; }
        public ICollection<Movie> Movies { get => movies; set => movies = value; }
    }
}
