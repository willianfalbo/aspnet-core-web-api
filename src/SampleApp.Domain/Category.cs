namespace SampleApp.Domain
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Category(string name, string description)
        {
            DomainException.When(string.IsNullOrWhiteSpace(name), $"{nameof(name)} is requerid.");

            this.Name = name;
            this.Description = description;
        }
    }
}