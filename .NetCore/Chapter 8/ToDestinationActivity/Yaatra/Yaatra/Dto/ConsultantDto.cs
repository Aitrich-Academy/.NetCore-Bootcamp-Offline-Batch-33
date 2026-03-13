namespace Yaatra.Dto
{
    public class ConsultantDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public int AssignedTours { get; set; }
        public int Bookings { get; set; }

        public DateTime? JoiningDate { get; set; }

    }
}
