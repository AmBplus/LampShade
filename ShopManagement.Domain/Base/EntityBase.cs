namespace ShopManagement.Domain.Base;

public class EntityBase<T>
{
    public long Id { get; set; }
    public DateTime CreationDate { get; set; }
}