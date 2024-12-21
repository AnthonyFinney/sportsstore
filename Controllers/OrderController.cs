using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers;

public class OrderController : Controller {
    private IOrderRepository repository;
    private Cart cart;

    public OrderController(IOrderRepository repo, Cart cartService) {
        repository = repo;
        cart = cartService;
    }

    public ViewResult Checkout() {
        return View(new Order());
    }

    [HttpPost]
    public IActionResult Checkout(Order order) {
        if (cart.Lines.Count == 0) {
            ModelState.AddModelError("", "Sorry, Your Cart Is Empty!");
        }

        if (ModelState.IsValid) {
            order.Lines = cart.Lines.ToArray();
            repository.SaveOrder(order);
            cart.Clear();

            return RedirectToPage("/Completed", new { orderId = order.OrderID });
        } else {
            return View();
        }
    }
}