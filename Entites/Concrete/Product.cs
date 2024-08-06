using Entites.Abstract;

namespace Entites.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Brand? Brand { get; set; }
        public ICollection<ProductColor>? ProductColors { get; set; }
        public ICollection<ProductSubCategory>? ProductSubCategories { get; set; }

    }
}
