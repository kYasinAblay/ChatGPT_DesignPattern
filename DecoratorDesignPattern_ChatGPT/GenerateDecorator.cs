using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternChatGPTOrnek
{

  // Ürün sınıfı
  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
      Name = name;
      Price = price;
    }

    public virtual decimal GetPrice()
    {
      return Price;
    }
  }

  // KDV sınıfı (ürünü süsler)
  public class KdvDecorator : Product
  {
    private Product product;

    public KdvDecorator(Product product) : base(product.Name, product.Price)
    {
      this.product = product;
    }

    public override decimal GetPrice()
    {
      // Ürün fiyatına KDV ekleyin
      return product.GetPrice() * 1.18m;
    }
  }

  // İndirim sınıfı (ürünü süsler)
  public class DiscountDecorator : Product
  {
    private Product product;
    private decimal discount;

    public DiscountDecorator(Product product, decimal discount) : base(product.Name, product.Price)
    {
      this.product = product;
      this.discount = discount;
    }

    public override decimal GetPrice()
    {
      // Ürün fiyatından indirim uygulayın
      return product.GetPrice() * (1 - discount);
    }

  }
}
