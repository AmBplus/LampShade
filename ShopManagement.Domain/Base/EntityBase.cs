namespace ShopManagement.Domain.Base;

public class EntityBase<T>
{
    public long Id { get; set; }
    public DateTime CreationDate { get; }
    public DateTime LastUpdate { get; set; }

    protected EntityBase()
    {
        LastUpdate = CreationDate = DateTime.Now;
    }
}