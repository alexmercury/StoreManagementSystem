using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
  public sealed class Admin : User
  {

    public Admin()
    {

    }

    private Admin(int ID, int UID)
    {
      this.ID = 0;
      this.UID = 0;
    }

  }

}