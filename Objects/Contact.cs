using System.Collections.Generic;

namespace JobList.Objects
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phonenum;

    public Contact (string name, string email, string phonenum)
    {
      _name = name;
      _email = email;
      _phonenum = phonenum;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public string GetPhonenum()
    {
      return _phonenum;
    }
    public void SetPhonenum(string newPhonenum)
    {
      _phonenum = newPhonenum;
    }
  }
}
