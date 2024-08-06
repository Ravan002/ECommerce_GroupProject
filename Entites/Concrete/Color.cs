using Entites.Abstract;

namespace Entites.Concrete
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductColor>? ProductColors { get; set; }
    }
}
