using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee
{
  /// <summary>
  /// Класс описывающий работника предприятия,
  /// <para>а также пользователя программы.</para>
  /// </summary>
  public class User
  {
    protected int ID;
    protected int UID;
    public string Surname;
    public string Name;
    public string Patronymic;
    public string ImageURL;

    public User()
    {
      this.UID = 0;
    }

    protected void Validate()
    {
     
    }

    protected void AddOrChangeImage()
    {
     
    }

  }

}