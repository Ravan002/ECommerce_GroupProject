using Entites.Abstract;

namespace Entites.Concrete
{
    public class ProductSubCategory : BaseEntity
    {
        public int ProductId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
