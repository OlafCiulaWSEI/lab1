using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{

    private IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    // Lista kontaktów
    public IActionResult Index()
    {
        return View(_contactService.GetAll());
    }
    

    [HttpPost]
    public ActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        _contactService.Add(model);

        return View(model);
    }

    public ActionResult Delete(int id)
    {
        _contactService.Delete(id);
        return View("Index");
    }

    public ActionResult Edit(int id)
    {
        return View(_contactService.GetById(id));
    }

    [HttpPost]
    public ActionResult Edit(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        _contactService.Update(model);
        return RedirectToAction(nameof(System.Index));
    }
    
    public ActionResult Details(int id)
    {
        return View(_contactService.GetById(id));
    }
}