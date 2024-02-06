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

