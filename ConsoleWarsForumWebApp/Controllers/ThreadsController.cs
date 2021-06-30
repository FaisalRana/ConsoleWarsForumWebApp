using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsoleWarsForumWebApp.Models;
using System.Linq;

namespace ConsoleWarsForumWebApp.Models
{
  public class ThreadsController : Controller
  {
    public IActionResult Index()
    {
      var allThreads = Thread.GetThreads();
      return View(allThreads);
    }

    public ActionResult Details(int id)
    {
      Thread thisThread = Thread.GetDetails(id);
      ViewBag.threadPosts = Thread.GetThreadPosts(id);
      return View(thisThread);
    }
    // [HttpPost]
    // public async Task<ActionResult<Thread> Post(Thread thread)
    // {
    //   _db.Threads.Add(thread);
    //   await _db.SaveChangesAsync();
    //   return CreatedAtAction(nameof(GetThread), new  {id = thread.ThreadId }, thread);
    // }

  }
}


