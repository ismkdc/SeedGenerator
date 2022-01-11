var generator = new SeedGenerator.Generator();

Console.WriteLine($"firstname -> {generator.Firstname()}");
Console.WriteLine($"lastname -> {generator.Lastname()}");
Console.WriteLine($"email -> {generator.Email()}");
Console.WriteLine($"date -> {generator.Date()}");
Console.WriteLine($"company -> {generator.Company()}");
Console.WriteLine($"integer -> {generator.Integer(50)}");
Console.WriteLine($"imageUrl -> {generator.ImageUrl()}");
Console.WriteLine($"text -> {generator.Text(50)}");