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
        Job newJob = new Job(Request.Form["new-title"], Request.Form["new-description"], Request.Form["new-contact"]);
        List<Job> AllJobs = Job.GetAll();
        return View["jobs.cshtml", AllJobs];
      };
    }
  }
}
