using StoreOfBuild.Domain.Products.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class ProductStorer
    {

        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductStorer(IRepository<Product> productRepository, IRepository<Category> categoryRepository){
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        
        public void Store(ProductsDto dto)
        {
            var category = _categoryRepository.GetById(dto.Category.Id);
            var product = _productRepository.GetById(dto.Id);
            if (product == null)
            {
                product = new Product(dto.Name, category, dto.Price, dto.StockQuantity);
                _productRepository.Save(product);
            }
            else
            {
                product.Update(dto.Name, category, dto.Price, dto.StockQuantity);
            }
        }
    }
}