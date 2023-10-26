using Microsoft.AspNetCore.Http;

namespace TestChatWithSignalR.Web.Helpers
{
    public interface IFileValidator
    {
        bool IsValid(IFormFile file);
    }
}
