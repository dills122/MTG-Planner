using BusinessObjects.StatelessObjects.Interfaces;
using Orleans;
using System;
using System.Threading.Tasks;

namespace BusinessObjects.StatelessObjects.Grains
{
    public class AppGrain : Grain, IApp
    {
        private AppInfo _appInfo;

        public override Task OnActivateAsync()
        {
            //_appInfo = new AppInfo("Mtg App", Guid.NewGuid());

            return base.OnActivateAsync();
        }

        public Task<AppInfo> GetAppInfo()
        {
            return Task.FromResult(_appInfo);
        }

        public Task SetAppInfo(AppInfo info)
        {
            if(info != null)
            {
                _appInfo = info;
            }
            return Task.CompletedTask;
        }
    }

    public class AppInfo
    {
        public Guid AppId { get; private set; }
        public string AppName { get; private set; }

        public AppInfo(string appName, Guid appId)
        {
            this.AppId = appId;
            this.AppName = appName;
        }
    }
}
