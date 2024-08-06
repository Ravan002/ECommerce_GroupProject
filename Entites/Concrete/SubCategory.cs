using Entites.Abstract;

namespace Entites.Concrete
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductSubCategory>? ProductSubCategories { get; set; }

    }
}
