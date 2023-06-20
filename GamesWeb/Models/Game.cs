using System.ComponentModel.DataAnnotations;

namespace GamesWeb.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [DataType(DataType.Date)] //User doesnt have to enter time info and only date is displayed, no time
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public string? Developer { get; set; }
    }
}
