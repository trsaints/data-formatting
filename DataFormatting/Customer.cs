class Customer
{
    string name;
    int shares;
    Product currentProduct;

    public string Name => name;
    public int Shares => shares;
    public Product CurrentProduct => currentProduct;

    public string GetProductOffer() =>
        $"Dear {name}\n As a customer of our {currentProduct.Name} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n";

    public string GetStatus() => 
        $"\r\nCurrently, you own {shares:N} shares at a return of {currentProduct.Returns:P2}.\r\n";

    public string GetCurrentProjection() =>
        currentProduct.GetProjection();

    public Customer(string name, int shares, Product p)
    {
        this.name = name;
        this.shares = shares;
        this.currentProduct = p;
    }
}
