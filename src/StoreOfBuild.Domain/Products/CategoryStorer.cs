using StoreOfBuild.Domain.Products.Dtos;

namespace StoreOfBuild.Domain.Products
{
    public class CategoryStorer
    {
        private readonly IRepository<Category> _categoRepository;

        public CategoryStorer(IRepository<Category> categoryReRepository)
        {
            _categoRepository = categoryReRepository;
        }

        public void Store(CategoryDto dto)
        {
            var category = _categoRepository.GetById(dto.Id);

            if(category == null)
            {
                category = new Category(dto.Name);
                _categoRepository.Save(category);

            }
            else{
                category.Update(dto.Name);
            }

        }
        
    }
}