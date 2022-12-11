public interface IDatabase
{
  void ExecuteQuery(string query);
}

public class Database : IDatabase
{
  public void ExecuteQuery(string query)
  {
    // Burada, verilen sorguyu gerçek bir veritabanı üzerinde çalıştırılacak.
  }
}

public class DatabaseProxy : IDatabase
{
  private Database database;

  public void ExecuteQuery(string query)
  {
    // Eğer gerçek veritabanı nesnesi daha önce oluşturulmamışsa, oluştur.
    if (database == null)
    {
      database = new Database();
    }

    // Gerçek veritabanı nesnesine sorguyu yönlendir.
    database.ExecuteQuery(query);
  }
}