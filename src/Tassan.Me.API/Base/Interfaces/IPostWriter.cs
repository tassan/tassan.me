using System.Threading.Tasks;
using Tassan.Me.API.Base.Entities.Blog;

namespace Tassan.Me.API.Base.Interfaces
{
    public interface IPostWriter
    {
        Task WritePost(Post post);
    }
}