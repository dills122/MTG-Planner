using BusinessObjects.StatelessObjects.Interfaces;
using Orleans;
using System;
using System.Threading.Tasks;

namespace BusinessObjects.StatelessObjects.Grains
{
    public class AppGrain : Grain, IApp
    {
        public Task<object> GetAppInfo()
        {
            throw new NotImplementedException();
        }
    }
}
