
using CatTask;
using System.Net.Http.Headers;

Cat Garfield = new Cat("Garfield", Gender.Male);
Cat Garfield1 = new Cat("Garfield1", Gender.Male);

Console.WriteLine(Garfield.Energy);
Console.WriteLine(Garfield1.Energy);
Console.WriteLine("------------------");
Garfield.Jump();
Console.WriteLine(Garfield.Energy);
Console.WriteLine(Garfield1.Energy);
Garfield.Sleep();
Garfield.Jump();
Garfield.Jump();
Garfield.Jump();
Garfield.Jump();
Garfield.Jump();
Garfield.Jump();
Garfield.Jump();
Console.WriteLine(Garfield.Energy);




