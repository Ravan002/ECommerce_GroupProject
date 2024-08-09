using Entites.Abstract;

namespace Entites.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? BrandId { get; set; }

    }
}
