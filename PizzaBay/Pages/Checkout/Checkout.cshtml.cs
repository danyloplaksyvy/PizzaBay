using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaBay.Data;
using PizzaBay.Models;

namespace PizzaBay.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext _dbContext;
        public CheckoutModel(ApplicationDBContext context)
        {
            _dbContext = context;
        }
        
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Оригінальна";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "custom";
            }

            PizzaOrderModel orderModel = new PizzaOrderModel();
            orderModel.PizzaName = PizzaName;
            orderModel.BasePrice = PizzaPrice;

            _dbContext.PizzaOrderModels.Add(orderModel);
            _dbContext.SaveChanges();
        }
    }
}
