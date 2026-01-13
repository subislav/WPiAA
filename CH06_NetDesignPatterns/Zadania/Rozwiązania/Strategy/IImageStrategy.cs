using System.Collections.Generic;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IImageStrategy
    {
        Task<List<string>> SearchPhotosAsync(string query);
    }
}