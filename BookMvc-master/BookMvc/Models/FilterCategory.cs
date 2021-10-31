using Microsoft.AspNetCore.Mvc.Rendering;
namespace BookMvc.Models

{
    public class FilterCategory
    {

        public List<Books> ListBook { get; set; }
        public SelectList ListCategory { get; set; }
        public string SelectCategory { get; set; }
        public string SearchString { get; set; }
    }
}
