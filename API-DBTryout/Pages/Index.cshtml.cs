using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_DBTryout.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataProvider _dataProvider;

        public List<Shop> Shops { get; set; } = new();
        public List<Shul> Shuls { get; set; } = new();

        public IndexModel(DataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public async Task OnGet()
        {
            Shops = _dataProvider.Shops.ListAll();
            Shuls = _dataProvider.Shuls.ListAll();
        }

        public async Task OnPost()
        {
            var shop = new Shop();
            _dataProvider.Shops.Add(shop);
        }
    }
}