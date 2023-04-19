namespace TecNM.Ecommerce.Core.Entities;

public class EntityBase
{
    public int Id { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }

}

public class Test1 : EntityBase
{
    
}