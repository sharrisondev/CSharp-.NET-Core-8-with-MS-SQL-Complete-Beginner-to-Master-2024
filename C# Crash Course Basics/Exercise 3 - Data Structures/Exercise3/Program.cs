Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
itemPrices.Add("cheese", 5.99M);
itemPrices.Add("carrots", 2.99M);

Console.WriteLine(itemPrices["cheese"].GetType());
Console.WriteLine(itemPrices["cheese"]);
Console.WriteLine(itemPrices["carrots"]);