class Customer
{
    string name;
    int shares;
    Product currentProduct;

    public string Name => name;
    public int Shares => shares;
    public Product CurrentProduct => currentProduct;

    public Customer(string name, int shares, Product p)
    {
        this.name = name;
        this.shares = shares;
        this.currentProduct = p;
    }
}
