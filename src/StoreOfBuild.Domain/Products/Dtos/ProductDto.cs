namespace StoreOfBuild.Domain.Products.Dtos
{
    public class ProductsDto
    {
        public int Id {get; private set;}     
        public string Name {get; private set;}
        public Category Category {get; private set;}
        public decimal Price {get; private set;}
        public int StockQuantity {get; private set;}
    }
}