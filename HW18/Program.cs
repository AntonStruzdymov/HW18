using System.Linq;
using System.Linq.Expressions;
using HW18Library;

string a = "Женя скоро будет свободен, а у вас все только начинается";
var a2 = a.Split(' ').SingleOrDefault(x => x.EndsWith("б"));


int[] arrB = { 5, 8, 0, -1, 6, 4, -1, -3 };
var cntB = arrB.Where(x => x > 0).Count();
var avgB = arrB.Where(x => x > 0).Average();



string c = "Женя скоро будет свободен, а у вас все только начинается";
var resC = c.Where(x => x != 'о');

Car[] cars =
{
    new Car("Шевроле", "Белый"),
    new Car("Киа", "Голубой"),
    new Car("Рено", "Красный"),
    new Car("Мерседес","Черный")
};
Person[] persons =
{
    new Person("Андрей", "Шевроле"),
    new Person("Алексей", "Киа"),
    new Person("Артем", "Рено"),
    new Person("Петр", "Мерседес")
};

var resD = persons.Join(cars, p => p.CarName, c => c.Name, (p, c) => new { Name = p.Name, CarName = p.CarName, CarColor = c.Color });
var resDnext = resD.Where(x => x.Name.StartsWith("А")).Skip(1).Take(2).Select(y => y.Name == "Артем");

Console.ReadLine();
