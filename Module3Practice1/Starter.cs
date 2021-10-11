using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3Practice1
{
  public class Starter
  {
      public void StartApplication()
      {
        var serviceProvider = new ServiceCollection()
            .AddTransient<ICultureResolver, CultureResolver>()
            .AddTransient<IPhonebook<IContacts>, PhoneBook<IContacts>>()
            .AddTransient<App>()
            .BuildServiceProvider();

        var app = serviceProvider.GetService<App>();
        app.Run();
      }
    }
  }
