namespace Common.DTO
{
    public class ContractorDTO
    {

        public int? ContractorId { get; set; }
        public string? ContractorIdentity { get; set; }

        public string? ContractorName { get; set; }

        public string? ManagementName { get; set; }

        public int? ManagementId { get; set; }

        public string? Address { get; set; }

        public string? CertificateConsortium { get; set; }

        public string? _50form { get; set; }

        //public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
