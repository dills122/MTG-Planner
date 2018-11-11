using BusinessObjects.StatelessObjects.Grains;
using System.Threading.Tasks;
using Orleans;

namespace BusinessObjects.StatelessObjects.Interfaces
{
    public interface IApp : IGrainWithIntegerKey
    {
        Task<AppInfo> GetAppInfo();

        Task SetAppInfo(AppInfo info);
    }
}
