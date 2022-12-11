// Bir dizi oluşturun
using VisitorDesignPattern_ChatGPT;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Diziyi tutan nesne oluşturun
Numbers numbersObject = new Numbers(numbers);

// Toplama ziyaretçisi oluşturun
SumVisitor sumVisitor = new SumVisitor();

// Diziyi toplama ziyaretçisi ile ziyaret edin
numbersObject.Accept(sumVisitor);

// Toplamı gösterin
Console.WriteLine(sumVisitor.GetSum());

// Ortalama ziyaret
AverageVisitor averageVisitor = new AverageVisitor();
numbersObject.Accept(averageVisitor);



Console.WriteLine(averageVisitor.GetAverage());


Console.ReadKey();