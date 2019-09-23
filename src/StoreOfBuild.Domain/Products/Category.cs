namespace StoreOfBuild.Domain.Products
{
    public class Category
    {
        public int Id { get; private set; }

        public string Name { get; private set; }
    
    public Category(string name)
    {
     ValidateNameAndSetNme(name);
    }
    public void Update(string name)
    {
        ValidateNameAndSetNme(name);
    }

    public void ValidateNameAndSetNme(string name)
    {
     DomainException.When(string.IsNullOrEmpty(name), "Nme is reuired");    
     Name = name;
    }

    }    
}