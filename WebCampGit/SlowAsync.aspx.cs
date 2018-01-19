using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MAWSHOL
{
    public partial class SlowAsync : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterAsyncTask(new PageAsyncTask(LoadSomeData));
        }

        public async Task LoadSomeData()
        {

            HttpClient Client = new HttpClient();

            var clientcontacts = Client.GetStringAsync("http://www.microsoft.com");
            var clienttemperature = Client.GetStringAsync("http://www.msn.com");
            var clientlocation = Client.GetStringAsync("http://www.yahoo.com");

            await Task.WhenAll(clientcontacts, clienttemperature, clientlocation);
        }
    }
}