using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_DBTryout.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAllData _allData;

        public List<Shop> Shops { get; set; } = new();
        public List<Shul> Shuls { get; set; } = new();

        public IndexModel(IAllData allData)
        {
            _allData = allData;
        }

        public async Task OnGet()
        {
            Shops = await _allData.Shops();
            Shuls = await _allData.Shuls();
        }
    }
}