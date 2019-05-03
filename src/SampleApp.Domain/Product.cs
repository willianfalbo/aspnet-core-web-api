namespace SampleApp.Domain
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public Category Category { get; private set; }
        public int CategoryId { get; private set; }
        public string Description { get; private set; }

        public Product(string name, decimal price, int stockQuantity, int categoryId, string description)
        {
            DomainException.When(string.IsNullOrWhiteSpace(name), $"{nameof(Name)} is requerid.");
            DomainException.When((price <= 0), $"{nameof(Price)} is requerid.");
            DomainException.When((stockQuantity < 0), $"{nameof(StockQuantity)} is requerid.");
            DomainException.When((categoryId <= 0), $"{nameof(Category)} is requerid.");

            this.Name = name;
            this.Price = price;
            this.StockQuantity = stockQuantity;
            this.CategoryId = categoryId;
            this.Description = description;
        }
    }
}