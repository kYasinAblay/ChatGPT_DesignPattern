using IteratorDesignPattern_ChatGPT;

MyCollection collection = new MyCollection();
Iterator<int> iterator = collection.CreateIterator();

while (iterator.HasNext())
{
  int item = iterator.Next();
  Console.WriteLine(item);
}