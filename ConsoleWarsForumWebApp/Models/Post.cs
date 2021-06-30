using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleWarsForumWebApp.Models
{
  public class Post
  {
    public int PostId { get; set; }
    public int ThreadId { get; set; }
    public string Text { get; set; }
    public DateTime DateAndTimeStamp { get; set; }
    public string Username { get; set; }
    public static List<Post> GetPosts() // let us get posts connected to a thread
    {
      var apiCallTask = ApiHelper.GetAllPosts();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Post> postList = JsonConvert.DeserializeObject<List<Post>>(jsonResponse.ToString());

      return postList;
    }
  }
}