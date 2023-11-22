using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaBay.Models;

namespace PizzaBay.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> pizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "barbekyu",
                PizzaName = "Барбекю",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Mushrooms = true,
                Onion = true,
                Chicken = true,
                FinalPrice = 200,
                Weight = 560
            },
            new PizzasModel()
            {
                ImageTitle = "bavarskaya",
                PizzaName = "Баварська",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Salami = true,
                FinalPrice = 170,
                Weight = 460
            },
            new PizzasModel()
            {
                ImageTitle = "drakon",
                PizzaName = "Дракон",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Mushrooms = true,
                Pepper = true,
                Salami = true,
                FinalPrice = 230,
                Weight = 600
            },
            new PizzasModel()
            {
                ImageTitle = "gavayskaya",
                PizzaName = "Гавайська",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Pineapple = true,
                Chicken = true,
                FinalPrice = 205,
                Weight = 520
            },
            new PizzasModel()
            {
                ImageTitle = "kvatro-di-karne",
                PizzaName = "Кватро-ді-Карне",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Mushrooms = true,
                Chicken = true,
                Salami = true,
                FinalPrice = 235,
                Weight = 480
            },
            new PizzasModel()
            {
                ImageTitle = "margarita",
                PizzaName = "Маргарита",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                FinalPrice = 145,
                Weight = 440
            },
            new PizzasModel()
            {
                ImageTitle = "pikante",
                PizzaName = "Пікантна",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Chicken = true,
                FinalPrice = 180,
                Weight = 480
            },
            new PizzasModel()
            {
                ImageTitle = "pitstsa-amerikano",
                PizzaName = "Американо",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Salami = true,
                Peperoni = true,
                FinalPrice = 205,
                Weight = 520
            },
            new PizzasModel()
            {
                ImageTitle = "pitstsa-chetyre-sezona",
                PizzaName = "Чотири сезони",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Mushrooms = true,
                Pepper = true,
                Chicken = true,
                Salami = true,
                FinalPrice = 265,
                Weight = 620
            },
            new PizzasModel()
            {
                ImageTitle = "semeynaya",
                PizzaName = "Сімейна",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Mushrooms = true,
                Salami = true,
                Peperoni = true,
                FinalPrice = 245,
                Weight = 700
            },
            new PizzasModel()
            {
                ImageTitle = "teriyaki",
                PizzaName = "Теріякі",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Mushrooms = true,
                Chicken = true,
                FinalPrice = 210,
                Weight = 520
            },
            new PizzasModel()
            {
                ImageTitle = "vegetarianskaya",
                PizzaName = "Вегетаріанська",
                BasePrice = 100,
                TomatoSauce = true,
                Cheese = true,
                Onion = true,
                Mushrooms = true,
                FinalPrice = 175,
                Weight = 480
            },
        };
        public void OnGet()
        {
        }
    }
}