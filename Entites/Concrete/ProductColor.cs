using Entites.Abstract;

namespace Entites.Concrete
{
    public class ProductColor : BaseEntity
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }
    }
}
