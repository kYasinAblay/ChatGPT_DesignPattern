using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern_ChatGPT
{
  public class MyCollection
  {
    private List<int> items = new List<int>() { 1, 2, 3, 4, 5 };

    public Iterator<int> CreateIterator()
    {
      return new CollectionIterator(this);
    }

    private class CollectionIterator : Iterator<int>
    {
      private MyCollection collection;
      private int currentIndex = 0;

      public CollectionIterator(MyCollection collection)
      {
        this.collection = collection;
      }

      public bool HasNext()
      {
        return currentIndex < collection.items.Count;
      }

      public int Next()
      {
        return collection.items[currentIndex++];
      }
    }
  }

}
