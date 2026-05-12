namespace JOB_PORTAL_SYSTEM.Api.Job_Provider.RequestObjects
{
    public class UpdateCompanyProfileRequest
    {
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public Guid IndustryId { get; set; }
        public Guid LocationId { get; set; }
    }
}
