using System.ComponentModel.DataAnnotations;

namespace TourManagement.Model
{
    public class Destination
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
