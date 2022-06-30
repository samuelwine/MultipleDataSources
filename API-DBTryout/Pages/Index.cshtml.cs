using API_DBTryout.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_DBTryout.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly MyClient _myClient;

        public List<Shop> Shops { get; set; } = new();
        public List<Shul> Shuls { get; set; } = new();

        public IndexModel(ApplicationDbContext context, MyClient myClient)
        {
            _context = context;
            _myClient = myClient;
        }

        public async Task OnGet()
        {
            Shops = _context.Shops.ToList();
            Shuls = await _myClient.GetShuls("https://run.mocky.io/v3/767f5b9b-b065-4d9f-ba6e-64bf7182f1d1");
        }
    }
}