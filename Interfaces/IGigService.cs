using System.Collections.Generic;
using System.Threading.Tasks;
using NinneHomePage.Models;

namespace NinneHomePage.Interfaces
{
    public interface IGigService
    {
        Task<IList<Gig>> getGigs(int limit);
    }
}