using AvivaZero.TechTest.Model;
using System.Threading.Tasks;

namespace AvivaZero.TechTest.Services
{
    public interface IFsaClient
    {
        Task<FsaAuthorityList> GetAuthorities();
    }
}