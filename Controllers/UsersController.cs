using JJConsulting.Models;
using JJConsulting.Services;
using Microsoft.AspNetCore.Mvc;


namespace JJConsulting.ProvaTecnica.Controllers;


public class UsersController : Controller
{
    private readonly IUserService _userService;


    public UsersController(IUserService userService)
    {
        _userService = userService;
    }


    public async Task<IActionResult> Index()
    {
        var users = await _userService.GetAllAsync();
        return View(users);
    }


    public async Task<IActionResult> Details(int id)
    {
        var user = await _userService.GetByIdAsync(id);
        if (user == null) return NotFound();
        return View(user);
    }
}