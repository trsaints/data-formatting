string getFormattedLetter(Customer c, Product newProduct)
{
    string customerGreeting = $"Dear {c.Name}\n",
        announcement = $"As a customer of our {c.CurrentProduct.Name} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n";

    string currentStatus = $"\r\nCurrently, you own {c.Shares:N} shares at a return of {c.CurrentProduct.Returns:P2}.\r\n",
           expectation = $"\r\nOur new product, {newProduct.Name} offers a return of {newProduct.Returns:P2}.  Given your current volume, your potential profit would be {newProduct.Profits:C}.\r\n";

    string currentProductProjection = c.CurrentProduct.GetProjection(),
        newProductProjection = newProduct.GetProjection(),
        productComparison = $"\r\nHere's a quick comparison: \r\n {currentProductProjection} {newProductProjection}";

    return $"{customerGreeting}{announcement}{currentStatus}{expectation}{productComparison}";
}

Product currentProduct = new("Magic Yield", 0.1275m, 55000000.0m);
Customer currentCustomer = new("Ms. Barros", 2975000, currentProduct);
Product newProduct = new("Glorious Future", 0.13125m, 63000000.0m);

var formattedLetter = getFormattedLetter(currentCustomer, newProduct);

Console.WriteLine(formattedLetter);

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

class Product
{
    string name;
    decimal returns, profits;

    public string GetProjection()
    {
       return $"{name.PadRight(20)} {returns:P2}\t {profits:C}\r\n";
    }

    public string Name => name;
    public decimal Returns => returns;
    public decimal Profits => profits;

    public Product(string name, decimal returns, decimal profits)
    {
        this.name = name;
        this.returns = returns;
        this.profits = profits;
    }
}

