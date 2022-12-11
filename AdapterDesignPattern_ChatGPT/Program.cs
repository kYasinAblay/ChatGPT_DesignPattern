public interface ITarget
{
  void Request();
}

public class Adapter : ITarget
{
  private Adaptee _adaptee;

  public Adapter(Adaptee adaptee)
  {
    _adaptee = adaptee;
  }

  public void Request()
  {
    // Delegate the call to the adaptee's method
    _adaptee.SpecificRequest();
  }
}

public class Adaptee
{
  public void SpecificRequest()
  {
    // Do something specific
  }
}

public class Client
{
  static void Main(string[] args)
  {
    Adaptee adaptee = new Adaptee();
    ITarget target = new Adapter(adaptee);

    target.Request();
  }
}