using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VisitorDesignPattern_ChatGPT
{

  // Sayıları tutan sınıf
  public class Numbers
  {
    public List<int> List { get; set; }

    public Numbers(List<int> list)
    {
      List = list;
    }

    public void Accept(IVisitor visitor)
    {
      foreach (int number in List)
      {
        visitor.Visit(number);
      }
    }
  }

  // Ziyaretçi arabirimi
  public interface IVisitor
  {
    void Visit(int number);
  }

  // Toplama ziyaretçisi
  public class SumVisitor : IVisitor
  {
    private int sum = 0;

    public void Visit(int number)
    {
      // Sayıyı toplamaya ekleyin
      sum += number;
    }

    public int GetSum()
    {
      return sum;
    }
  }

  // Ortalama ziyaretçisi
  public class AverageVisitor : IVisitor
  {
    private int sum = 0;
    private int count = 0;

    public void Visit(int number)
    {
      // Sayıyı toplamaya ekleyin
      sum += number;
      // Sayı sayısını artırın
      count++;
    }

    public double GetAverage()
    {
      return (double)sum / count;
    }
  }
}

   
