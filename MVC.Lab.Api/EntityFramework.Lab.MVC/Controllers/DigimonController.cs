using EntityFramework.Lab.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EntityFramework.Lab.MVC.Controllers
{
    public class DigimonController : Controller
    {

        // GET: LoremApi
        public async Task<ActionResult> Index()
        {
            var list = await GetApiModelList();
            return View(list);
        }
        public async Task<List<DigimonView>> GetApiModelList()
        {
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://digimon-api.vercel.app/api/digimon");
            HttpResponseMessage message = await client.GetAsync(uri);
            List<DigimonView> list = null;
            if (message.IsSuccessStatusCode)
            {
                var content = await message.Content.ReadAsStringAsync();
                list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DigimonView>>(content);
            }
            return list;    
        }
    }
}