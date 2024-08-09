using Entites.Abstract;

namespace Entites.Concrete
{
    public class SubCategory : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }

    }
}
