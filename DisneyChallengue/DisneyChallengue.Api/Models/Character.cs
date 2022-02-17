using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLModels
{
    public class Character : IModels
    {
        private string img;
        private string name;
        private int age;
        private float weight;
        private string history;
        ICollection<Movie> movies;

        public Character(string img, string name, int age, float weight, string history)
        {
            this.img = img;
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.history = history;
        }

        public int Id { get; set; }
        public string Img { get => img; set => img = value; }
        [MaxLength(40)]
        [Required]
        public string Name { get => name; set => name = value; }
        [MaxLength(3)]
        [Required]
        public int Age { get => age; set => age = value; }
        [Required]
        public float Weight { get => weight; set => weight = value; }
        [MaxLength(400)]
        [Required]
        public string History { get => history; set => history = value; }
        public ICollection<Movie> Movies { get => movies; set => movies = value; }
    }
}
