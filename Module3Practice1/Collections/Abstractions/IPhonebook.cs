using System.Collections.Generic;
using System.Globalization;

namespace Module3Practice1
{
  public interface IPhonebook<T> : IEnumerable<T>
  where T : IContacts
  {
    public void Add(T contact);
    IReadOnlyCollection<T> this[string key] { get; }
  }
}