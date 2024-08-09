using Business.Abstract;
using DataAccess.Abstract;
using Entites.Concrete;

namespace Business.Concrete
{
    public class ProductManager(IProductDal productDal) : IProductService
    {
        private readonly IProductDal _productDal = productDal;
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetByName(string productName)
        {
            return _productDal.Get(p => p.Name == productName);
        }

        public List<Product> GetAll()
        {
            var products = _productDal.GetAll();
            return products;
        }


        public Product GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

    }
}
