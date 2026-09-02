using Diagnostyka;
// (Diagnostyka: nazwa projektu w którym są pliki);

Product p = new Product("Laptop", 1500.00f, "Electronics");
Product p2 = new Product("Smartphone", 800.00f, "Electronics");
Product p3 = new Product("Headphones", 200.00f, "Electronics");

List<Product> products = new List<Product> ();
products.Add(p);
products.Add(p2);
products.Add(p3);

foreach (Product product in products)
{
	Console.WriteLine(product.name);
}