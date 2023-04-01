namespace ID.Data.Entities.BaseEntities;

public class AuditEntity : BaseEntity
{
    public string CreatedBy { get; set; }
    
    public string CreatedDate { get; set; }
    
    public string ModefiedBy { get; set; }
    
    public DateTime ModefiedDate { get; set; }
}