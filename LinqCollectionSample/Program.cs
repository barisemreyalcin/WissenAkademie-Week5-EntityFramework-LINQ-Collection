// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region LINQ SORT
#region OrderBy 
//using LinqCollectionSample;

//Student student = new Student();
//var students = student.GetStudentList();

//// Query Syntax
////var result = from _student in students
////             orderby _student.FirstName, _student.Age descending
////             select _student;

//// Methodd Syntax
//var result = students.OrderBy(student => student.FirstName).ThenByDescending(student => student.Age);

//foreach (var item in result)
//{
//    Console.WriteLine($"Firstname: {item.FirstName} - LastName: {item.LastName} - Age: {item.Age}");
//}
#endregion

#region ThenBy
// Method syntax
//string[] cities = new string[] { "Ankara", "İzmir", "Bursa", "Mardin", "Hatay", "Edirne" }; // collection

//var result = cities.OrderBy(city => city.Length).ThenBy(city => city);

//foreach (var city in result)
//{
//    Console.WriteLine(city);
//}

// Query syntax
//string[] cities = new string[] { "Ankara", "İzmir", "Bursa", "Mardin", "Hatay", "Edirne" }; // collection

//var result = from city in cities
//             orderby city.Length, city
//             select city;
//foreach (var city in result)
//{
//    Console.WriteLine(city);
//}
#endregion

#region OrderByDescending
//int[] numbers = new int[] { 1, 5, 9, 4, 25, 7 };

// Method syntax
//var result = numbers.OrderByDescending(x => x);
//foreach (var x in result)
//{
//    Console.WriteLine(x);
//}

// Query syntax
//int[] numbers = new int[] { 1, 5, 9, 4, 25, 7 };

//var result = from x in numbers
//              orderby x descending
//              select x;

//foreach (var x in result)
//{
//    Console.WriteLine(x);
//}
#endregion

#region ThenByDescending
//string[] cities = new string[] {"İstanbul", "Ankara", "İzmir", "Bursa", "Mardin", "Hatay", "Edirne" }; // collection

// Method syntax
//var results = cities.OrderBy(city => city.Length).ThenByDescending(city => city);

//foreach (var city in results)
//{
//    Console.WriteLine(city);
//}

// Query syntax
//string[] cities = new string[] { "İstanbul", "Ankara", "İzmir", "Bursa", "Mardin", "Hatay", "Edirne" }; // collection

//var result = from city in cities
//             orderby city.Length, city descending
//             select city;

//foreach (var city in result)
//{
//    Console.WriteLine(city);
//}
#endregion

#region Reverse
// Method syntax
//int[] numbers = new int[] { 1, 5, 9, 4, 25, 7 };
//var result = numbers.Reverse(); // type tahmin edebiliyorsak collection tipini kullan
//foreach (var x in result)
//{
//    Console.WriteLine(x);
//}
#endregion
#endregion

#region LINQ QUENTIFIERS

#region Contains
//int[] numbers = new int[] { 1, 5, 2, 9, 12, 7, 10 };

//var result1 = numbers.Contains(1);
//var result2 = numbers.Contains(11);

//Console.WriteLine(result1);
//Console.WriteLine(result2);

#endregion

#region Any
//int[] numbers = new int[] { 1, 5, 2, 9, 12, 7, 10 };

//var result1 = numbers.Any();
//var result2 = numbers.Any(x => x == 9);
//var result3 = numbers.Any(x => x == 9 || x == 7);
//var result4 = numbers.Any(x => x > 8);
//var result5 = numbers.Any(x => x < 0);

//Console.WriteLine(result1);
//Console.WriteLine(result2);
//Console.WriteLine(result3);
//Console.WriteLine(result4);
//Console.WriteLine(result5);

#endregion

#region All
//string[] languages = new string[] { "Turkish", "English", "Russian", "Chinese" };

//// Tüm elemanların sağlaması gerekir
//var result1 = languages.All(x => x == "Turkish");
//var result2 = languages.All(x => x.StartsWith("T"));
//var result3 = languages.All(x => x.Contains("i"));

//Console.WriteLine(result1);
//Console.WriteLine(result2);
//Console.WriteLine(result3);
#endregion
#endregion

#region LINQ AGGREGATIONS

#region Count (returns int => int32) | LongCount (returns bigInt or long => int64)
//var monthList = new List<string>
//{
//    "January", "February", "March", "April", "May", "June", "July", "August", "September","October", "November", "December"
//};

//var result1 = monthList.Count();
//var result2 = monthList.LongCount();

//Console.WriteLine($"{result1}, {result1.GetType()}");
//Console.WriteLine($"{result2}, {result2.GetType()}");
#endregion

#region Sum
//int[] numbers = new int[] { 1, 4, 44 };
//var result1 = numbers.Sum();
//var result2 = numbers.Sum(x => x);
//Console.WriteLine(result1);
//Console.WriteLine(result2);

//using LinqCollectionSample;

//Student student = new Student();
//var students = student.GetStudentList();
//var result1 = students.Where(st => st.FirstName == "Tony").Sum(st => st.Age);
//var result2 = students.Sum(st => st.Age);
//Console.WriteLine(result1);
//Console.WriteLine(result2);
#endregion

#region Max - Min - Average
//int[] numbers = { 2, 3, 33, 22, 11 };

//var result1 = numbers.Max();
//var result2 = numbers.Min();
//var result3 = numbers.Average();

//var result4 = numbers.Where(x => x > 22).Max();
//var result5 = numbers.Where(x => x < 22).Min();

//Console.WriteLine(result1);
//Console.WriteLine(result2);
//Console.WriteLine(result3);
//Console.WriteLine(result4);
//Console.WriteLine(result5);
#endregion

#endregion

#region LINQ FILTERS

#region Where
//using LinqCollectionSample;

//Product product = new Product();
//var products = product.GetProductList();

// Query Syntax
//var result = from _product in products
//             where _product.CategoryName == "Fruit"
//             select _product;
//foreach (var fruit in result)
//{
//    Console.WriteLine($"Fruit name: {fruit.ProductName} - Fruit price: {fruit.Price}");
//}

//var result = from _product in products
//             where _product.CategoryName == "Fruit" && _product.Price > 50
//             select _product;
//foreach (var fruit in result)
//{
//    Console.WriteLine($"Fruit name: {fruit.ProductName} - Fruit price: {fruit.Price}");
//}

// Method Syntax
//var result = products.Where(prd => prd.CategoryName == "Fruit");
//foreach (var fruit in result)
//{
//    Console.WriteLine($"Fruit name: {fruit.ProductName} - Fruit price: {fruit.Price}");
//}

//var result = products.Where(prd => prd.CategoryName == "Fruit" && prd.Price > 50);
//foreach (var fruit in result)
//{
//    Console.WriteLine($"Fruit name: {fruit.ProductName} - Fruit price: {fruit.Price}");
//}
#endregion

#region OfType
//object[] values = { "Ankara", "Bursa", 5, 7, "Çankırı", 4.80, true, 2, false, DateTime.Now };

//var resultInt = values.OfType<int>();
//foreach (var integer in resultInt)
//{
//    Console.WriteLine($"{integer} - {integer.GetType()}");
//}

//Console.WriteLine(new string('*', 50));

//var resultStrng = values.OfType<string>();
//foreach (var str in resultStrng)
//{
//    Console.WriteLine($"{str} - {str.GetType()}");
//}

//Console.WriteLine(new string('*', 50));

//var resultBool = values.OfType<bool>();
//foreach (var bln in resultBool)
//{
//    Console.WriteLine($"{bln} - {bln.GetType()}");
//}

//Console.WriteLine(new string('*', 50));

//var resultDbl = values.OfType<double>();
//foreach (var dbl in resultDbl)
//{
//    Console.WriteLine($"{dbl} - {dbl.GetType()}");
//}

//Console.WriteLine(new string('*', 50));

//var resultDate = values.OfType<DateTime>();
//foreach (var date in resultDate)
//{
//    Console.WriteLine($"{date} - {date.GetType()}");
//}
#endregion
#endregion

#region LINQ GROUPING

#region GroupBy
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var nums = numbers.GroupBy(x => x % 2 == 0);
//foreach (var num in nums)
//{
//    Console.WriteLine(string.Join('-', num));
//}
#endregion

#region ToLookup
//var monthList = new List<string>{ "January", "February", "March", "April", "May", "June", "July", "August", "September","October", "November", "December"
//};
//var result = monthList.ToLookup(month => month.Length);

//foreach (var month in result)
//{
//    Console.WriteLine(string.Join('-', month));
//}
#endregion

#endregion

#region LINQ GET ELEMENTS

#region First & Last & ElementAt
//string[] goats = { "Bryant", "Jordan", "James", "Iverson", "Jabbar", "Duncan" };
//var resultFirst = goats.First(); // Collection boşsa hata verir
//var resultLast = goats.Last(); // Collection boşsa hata verir
//var result1 = goats.ElementAt(1);

//Console.WriteLine(resultFirst);
//Console.WriteLine(resultLast);
//Console.WriteLine(result1);
#endregion

#region FirstOrDefault | LastOrDefault
//string[] countries = { "Turkey", "Germany", "Italy", "France" };
//string[] emptyColl = { };
//var res1 = countries.FirstOrDefault();
//var res2 = countries.LastOrDefault();
//var res3 = emptyColl.LastOrDefault(); // Boş da olsa bir şey döner ve hata vermez.
//var res4 = emptyColl.LastOrDefault(); // Boş da olsa bir şey döner ve hata vermez.

//Console.WriteLine(res1);
//Console.WriteLine(res2);
//Console.WriteLine(res3); // Boş da olsa bir şey döner ve hata vermez.
//Console.WriteLine(res4); // Boş da olsa bir şey döner ve hata vermez.
#endregion

#region Single | SingleOrDefault
//// 2 method da tek değer dönmelidir
//int[] numbers = { 6, 8, 6, 11, 24 };
////var result1 = numbers.Single(x => x == 6); // İki adet 6 var. Hata verir
////var result2 = numbers.SingleOrDefault(x => x == 6); // İki adet 6 var. Hata verir

//var result1 = numbers.Single(x => x == 30); // Değer yok. Hata verir
//var result2 = numbers.SingleOrDefault(x => x == 30); // Değer yok. Hata vermez

#endregion

#endregion

#region LINQ SUBSETS

#region Select
//int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
////var results = numbers.Select(x => x * 5);
//var results = numbers.Select(x => x > 5);

//foreach (var num in results)
//{
//    Console.WriteLine(num);
//}
#endregion

#region SelectMany
//string[] countries = { "Turkey", "Italy", "Spain" };
//int[] indexes = { 1, 2, 3 };

//var result = countries.SelectMany(x => indexes, (x, i) => new { country = x, index = i });
//foreach (var item in result)
//{
//    Console.WriteLine($"Country: {item.country} - Index: {item.index}");
//}
#endregion

#endregion

#region LINQ SETS

#region Distinct
//string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Tuesday", "Friday", "Saturday", "Wednesday", "Tuesday", "Sunday" };
//var result1 = days.Distinct();

//foreach (var day in result1)
//{
//    Console.WriteLine(day);
//}
#endregion

#region Union
//string[] days1 = { "Monday", "Thursday", "Saturday", "Monday" };
//string[] days2 = { "Tuesday", "Wednesday", "Monday", "Friday", "Sunday", "Sunday" };

//var res1 = days1.Union(days2);

//foreach (var day in res1)
//{
//    Console.WriteLine(day);
//}
#endregion

#region Intersect
//string[] days1 = { "Monday", "Thursday", "Saturday", "Monday" };
//string[] days2 = { "Tuesday", "Wednesday", "Monday", "Friday", "Sunday", "Sunday" };

//var res1 = days1.Intersect(days2);

//foreach (var day in res1)
//{
//    Console.WriteLine(day);
//}
#endregion

#region Except
//string[] letters1 = { "a", "b", "c", "d" };
//string[] letters2 = { "c", "d", "e", "f" };

//var res1 = letters1.Except(letters2);

//foreach (var letter in res1)
//{
//    Console.WriteLine(letter);
//}
#endregion
#endregion

#region LINQ PARTITIONING

#region Take |TakeWhile | TakeLast
int[] numbers1 = { 5, 25, 12, 66, 75, 1, 22, 24 };
var res = numbers1.Take(3);
foreach (var num in res)
{
    Console.WriteLine(num);
}

Console.WriteLine("--------");

int[] numbers2 = { 1, 2, 3, 4, -1, -2 };
var res1 = numbers2.TakeWhile(x => x <= 3); // uymayan bir değer gördüğünde bitiriyor
foreach (var num in res1)
{
    Console.WriteLine(num);
}

Console.WriteLine("--------");

var res2 = numbers2.TakeLast(3); // uymayan bir değer gördüğünde bitiriyor
foreach (var num in res2)
{
    Console.WriteLine(num);
}

Console.WriteLine("--------");

var res3 = numbers2.Where(x => x <= 3);
foreach (var num in res3)
{
    Console.WriteLine(num);
}
#endregion

#endregion