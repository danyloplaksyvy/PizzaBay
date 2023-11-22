using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaBay.Models;

namespace PizzaBay.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 10;
            if (Pizza.Cheese) PizzaPrice += 25;
            if (Pizza.Onion) PizzaPrice += 10;
            if (Pizza.Mushrooms) PizzaPrice += 30;
            if (Pizza.Pepper) PizzaPrice += 20;
            if (Pizza.Pineapple) PizzaPrice += 25;
            if (Pizza.Chicken) PizzaPrice += 35;
            if (Pizza.Salami) PizzaPrice += 35;
            if (Pizza.Peperoni) PizzaPrice += 35;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
