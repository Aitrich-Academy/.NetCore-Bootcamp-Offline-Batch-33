namespace JOB_PORTAL_SYSTEM.Api.ADMIN.RequestObjects
{
    public class CompanyProfileRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid IndustryId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
