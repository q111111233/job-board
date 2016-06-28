using Nancy;
using System.Collections.Generic;
using JobList.Objects;

namespace JobList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/jobs"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["jobs.cshtml", allJobs];
      };
      Get["/jobs/{id}"] = parameters => {
        Job job = Job.Find(parameters.id);
        return View["/job.cshtml", job];
      };
      Get["/jobs/new"] = _ => {
        return View["job_form.cshtml"];
      };
      Post["/jobs"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-email"], Request.Form["new-phonenum"]);
        Job newJob = new Job(Request.Form["new-title"], Request.Form["new-description"], newContact);
        List<Job> AllJobs = Job.GetAll();
        return View["jobs.cshtml", AllJobs];
      };
    }
  }
}
