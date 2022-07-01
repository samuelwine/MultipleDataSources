using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_DBTryout.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataHandler _dataHandler;

        public List<Shop> Shops { get; set; } = new();
        public List<Shul> Shuls { get; set; } = new();

        public IndexModel(DataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public async Task OnGet()
        {
            Shops = _dataHandler.Shops.ListAll();
            Shuls = _dataHandler.Shuls.ListAll();
        }

        public async Task OnPost()
        {
            var shop = new Shop();
            _dataHandler.Shops.Add(shop);
        }
    }
}