


// Ürün oluşturun
using DecoratorDesignPatternChatGPTOrnek;

Product product = new Product("Ürün 1", 100);

// Ürünün fiyatını gösterin
Console.WriteLine(product.GetPrice());

// KDV sınıfını kullanarak ürünü süsleyin
product = new KdvDecorator(product);

// Süslenmiş ürünün fiyatını gösterin
Console.WriteLine(product.GetPrice());

// İndirim sın

Console.ReadKey();

