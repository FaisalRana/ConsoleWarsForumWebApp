using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ConsoleWarsForumWebApp.Models
{
  public class Thread
  {
    public int ThreadId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime DateAndTimeStamp { get; set; }

    public static List<Thread> GetThreads()
    {
      var apiCallTask = ApiHelper.GetAllThreads();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Thread> threadList = JsonConvert.DeserializeObject<List<Thread>>(jsonResponse.ToString());

      return threadList;
    }
    public static Thread GetDetails(int id)
    {
      var apiCallTask = ApiHelper.GetThread(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Thread thread = JsonConvert.DeserializeObject<Thread>(jsonResponse.ToString());

      return thread;
    }

    public static List<Post> GetThreadPosts(int id)
    {
      var apiCallTask = ApiHelper.GetThreadPosts(id);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Post> postList = JsonConvert.DeserializeObject<List<Post>>(jsonResponse.ToString());

      return postList;
    }
  }
}

