using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObjects.StatelessObjects.Grains;
using BusinessObjects.StatelessObjects.Interfaces;
using ClientApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Orleans;
using RetrievalService.Cards;

namespace ClientApp.Server.Controllers
{
    [Route("api/[controller]")]
    public class OrleansTestController : Controller
    {
        private IClusterClient _client;

        public OrleansTestController(IClusterClient client)
        {
            _client = client;
        }

        [HttpGet("[action]")]
        public async Task<CardViewModel> AppInfo()
        {
            if (!_client.IsInitialized)
            {
                return null;
            }

            var grain = _client.GetGrain<IApp>(0);

            var app = new AppInfo("MTG", Guid.NewGuid());

            await grain.SetAppInfo(app);

            var appInfo = await grain.GetAppInfo();

            var vm = new AppInfoView
            {
                AppId = appInfo.AppId,
                AppName = appInfo.AppName
            };

            SearchCards search = new SearchCards();
            var result = search.SearchByName("Adanto Vanguard");

            if(result.IsSuccess)
            {
                var card = result.Value.First();
                return new CardViewModel
                {
                    Colors = card.Colors.ToList(),
                    ManaCost = card.ManaCost,
                    ImgUrl = card.ImageUrl.ToString(),
                    Name = card.Name
                };
            }

            return null;
        }

        
    }
}