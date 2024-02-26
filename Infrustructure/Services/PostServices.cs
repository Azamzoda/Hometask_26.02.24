using Domain.Models;

namespace Infrustructure.Services;

public class PostService
{
    
    List<Post> posts =  new List<Post>();
    public List<Post> GetPosts()
    {
        return posts;
    }
    public void AddPosts(Post post)
    {
        posts.Add(post);
    }
    public void UpdatePosts(Post post)
    {
        foreach (var item in posts)
        {
            item.Title = post.Title;
            item.Description = post.Description;
            item.VoteAmount = post.VoteAmount;
            item.CreatedAt = post.CreatedAt;
            break;
        }
    }
    public void Delete(int Id)
    {
        foreach (var item in posts)
        {
            if (item.Id == Id)
            {
                posts.Remove(item);
                break;
            }
        }
    }
}
