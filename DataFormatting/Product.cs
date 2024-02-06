class Product
{
    string name;
    decimal returns, profits;

    public string GetExpectation() =>
        $"\r\nOur new product, {name} offers a return of {returns:P2}.  Given your current volume, your potential profit would be {profits:C}.\r\n";

    public string GetProjection() =>
        $"{name.PadRight(20)} {returns:P2}\t {profits:C}\r\n";

    public static string GetProductComparison(Product p1, Product p2) =>
        $"\r\nHere's a quick comparison: \r\n {p1.GetProjection()} {p2.GetProjection()}";

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

