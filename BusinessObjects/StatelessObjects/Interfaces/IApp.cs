using System.Threading.Tasks;

namespace BusinessObjects.StatelessObjects.Interfaces
{
    public interface IApp
    {
        Task<object> GetAppInfo();
    }
}
