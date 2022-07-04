using Microsoft.AspNetCore.Mvc.RazorPages;

namespace API_DBTryout.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository<Shul> _shulRepository;
        private readonly IRepository<Shop> _shopRepository;

        public List<Shop> Shops { get; set; } = new();
        public List<Shul> Shuls { get; set; } = new();

        public IndexModel(IRepository<Shul> shulRepository, IRepository<Shop> shopRepository)
        {
            _shulRepository = shulRepository;
            _shopRepository = shopRepository;
        }

        public void OnGet()
        {
            Shops = _shopRepository.ListAll();
            Shuls = _shulRepository.ListAll();
        }

        public void OnPost()
        {
            var shop = new Shop();
            _shopRepository.Add(shop);
        }
    }
}