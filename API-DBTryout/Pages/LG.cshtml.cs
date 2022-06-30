using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_DBTryout.Pages
{
    public class LGModel : PageModel
    {
        private readonly IAllData _allData;

        public List<Shop> Shops { get; set; } = new();
        public List<Shul> Shuls { get; set; } = new();

        public LGModel(IAllData allData)
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