using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Module1;

namespace Module2 {
  public class Module2Thing {
    public void ShowYouAreDependOnModule1() {
      Modul1Thing thing1 = new Modul1Thing();
      Console.WriteLine(thing1.GetType().Assembly);
    }

    public void ShowWhoYouAre() {
      Console.WriteLine(GetType().Assembly);
    }
  }
}
