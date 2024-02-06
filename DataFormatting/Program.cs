string GetFormattedLetter(Customer c, Product newProduct)
{
    string announcement = c.GetProductOffer(),
           currentStatus = c.GetStatus(),
           expectation = newProduct.GetExpectation(),
           productComparison = Product.GetProductComparison(c.CurrentProduct, newProduct);

    return $"{announcement}{currentStatus}{expectation}{productComparison}";
}

Product currentProduct = new("Magic Yield", 0.1275m, 55000000.0m);
Product newProduct = new("Glorious Future", 0.13125m, 63000000.0m);
Customer currentCustomer = new("Ms. Barros", 2975000, currentProduct);

var formattedLetter = GetFormattedLetter(currentCustomer, newProduct);

Console.WriteLine(formattedLetter);


