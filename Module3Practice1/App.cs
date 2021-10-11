using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Practice1
{
  public class App
  {
    private readonly IPhonebook<IContacts> _phoneBook;

    public App(IPhonebook<IContacts> phoneBook)
    {
      _phoneBook = phoneBook;
    }

    public void Run()
    {
      _phoneBook.Add(new Contacts() { Name = "Igor", LastName = "Serduik" });
      _phoneBook.Add(new Contacts() { Name = "Igor", LastName = "Bobro" });
      _phoneBook.Add(new Contacts() { Name = "Ilya", LastName = "Добродушный" });
      _phoneBook.Add(new Contacts() { Name = "Евгений", LastName = "Понасенков" });
      _phoneBook.Add(new Contacts() { Name = "Duncan", LastName = "Idaho" });
      _phoneBook.Add(new Contacts() { Name = "Euegene", LastName = "Socalled" });
      _phoneBook.Add(new Contacts() { Name = "Simon", LastName = "Pegg" });
      _phoneBook.Add(new Contacts() { Name = "133Dennis", LastName = "Shardonnay" });
      _phoneBook.Add(new Contacts() { Name = "Claudia", LastName = "Schiffer" });
      _phoneBook.Add(new Contacts() { Name = "448Василий", LastName = "Сантехник" });
      _phoneBook.Add(new Contacts() { Name = "+34585500", LastName = "забыл" });
      _phoneBook.Add(new Contacts() { Name = "afff112222" });
      _phoneBook.Add(new Contacts() { Name = "*121#" });

      var x = _phoneBook["Ig"];

      DisplayCollection();
    }

    public void DisplayCollection()
    {
      foreach (var contact in _phoneBook)
      {
        Console.WriteLine(contact.Name);
      }
    }
  }
}
