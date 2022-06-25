using ShopManagement.Domain.Base;

namespace ShopManagement.Domain.ProductCategoryAgg;

public class ProductCategory : EntityBase<long>
{
    // Ctor
    protected ProductCategory()
    {
    }

    public ProductCategory(string name, string description, string picture, string pictureAlt, string pictureTitle)
    {
        Name = name;
        Description = description;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        IsDeleted = false;
    }

    // Properties
    // **************************
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string Picture { get; private set; }
    public string PictureAlt { get; private set; }
    public string PictureTitle { get; private set; }
    public bool IsDeleted { get; private set; }
    public string Keywords { get; private set; }
    public string MetaDescription { get; private set; }

    public string Slug { get; private set; }
    // **************************

    // Methods
    public void Update(string name, string description, string picture, string pictureAlt, string pictureTitle)
    {
        Name = name;
        Description = description;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        LastUpdate = DateTime.Now;
    }

    /// <summary>
    ///     Change Status Of Product Category (remove =  1 , Add = 0 )
    /// </summary>
    /// <param name="status">For Remove Boolean : 1 , For Add  : 0</param>
    public void ChangeStatus(bool status)
    {
        IsDeleted = status;
    }
}