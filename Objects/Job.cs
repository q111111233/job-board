using System.Collections.Generic;

namespace JobList.Objects
{
  public class Job
  {
    private string _title;
    private string _description;
    private Contact _contact;
    private int _id;
    private static List<Job> _jobs = new List<Job> {};

    public Job (string title, string description, Contact contact)
    {
      _title = title;
      _description = description;
      _contact = contact;
      _jobs.Add(this);
      _id = _jobs.Count;
    }
    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public Contact GetContact()
    {
      return _contact;
    }
    public void SetContact(Contact newContact)
    {
      _contact = newContact;
    }
    public int GetId()
    {
      return _id;
    }
    public static void ClearAll()
    {
      _jobs.Clear();
    }
    public static List<Job> GetAll()
    {
      return _jobs;
    }
    public static Job Find(int searchId)
    {
      return _jobs[searchId-1];
    }

  }
}
