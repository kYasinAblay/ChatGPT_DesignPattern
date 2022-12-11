public class Flyweight
{
  private string intrinsicState;

  public Flyweight(string intrinsicState)
  {
    this.intrinsicState = intrinsicState;
  }

  public void Operation(string extrinsicState)
  {
    // Burada, verilen ekstrinsik durum ve nesnenin içsel durumu kullanılarak işlem yapılacak.
  }
}

public class FlyweightFactory
{
  private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

  public Flyweight GetFlyweight(string key)
  {
    // Eğer istenen nesne daha önce oluşturulmamışsa, oluştur.
    if (!flyweights.ContainsKey(key))
    {
      flyweights[key] = new Flyweight(key);
    }

    // Oluşturulmuş nesneyi döndür.
    return flyweights[key];
  }
}