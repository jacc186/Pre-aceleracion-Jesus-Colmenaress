using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLModels
{
    public class Movie : IModels
    {
        private string img;
        private string name;
        private DateTime date;
        private int score;
        ICollection<Character> charactersInvolved;

        public Movie(string img, string name, DateTime date, int score)
        {
            this.img = img;
            this.name = name;
            this.date = date;
            this.score = score;
        }

        public int Id { get; set; }
        public string Img { get => img; set => img = value; }
        [MaxLength(40)]
        [Required]
        public string Name { get => name; set => name = value; }
        [Required]
        public DateTime Date { get => date; set => date = value; }
        [MaxLength(1)]
        [Required]
        public int Score { get => score; set => score = value; }
        public ICollection<Character> CharactersInvolved { get => charactersInvolved; set => charactersInvolved = value; }
    }
}
