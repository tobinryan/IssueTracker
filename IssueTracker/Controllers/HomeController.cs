﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IssueTracker.Models;
using Microsoft.AspNetCore.Authorization;
using IssueTracker.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace IssueTracker.Controllers;

[Authorize]
public class HomeController : Controller
{
    private IssueTrackerIdentityDbContext application;
    private UserManager<ApplicationUser> userManager;

    public HomeController(IssueTrackerIdentityDbContext app, UserManager<ApplicationUser> userManager)
    {
        application = app;
        this.userManager = userManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Projects()
    {
        return View();
    }

    public IActionResult CreateProject()
    {
        return View();
    }

    public IActionResult ProjectDetails()
    {
        return View();
    }

    public IActionResult EditProject()
    {
        return View();
    }

    public IActionResult Tickets()
    {
        return View();
    }

    public IActionResult CreateTicket()
    {
        return View();
    }

    public IActionResult EditTicket()
    {
        return View();
    }

    public IActionResult TicketDetails()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }


    public IActionResult ManageRoles()
    {
        var users = application.Users.ToList();
        return View(users);
    }

    public IActionResult ManageUsers()
    {
        var users = application.Users.ToList();
        //var currentUser = userManager.GetUserAsync(HttpContext.User);
        //var roles = userManager.GetRolesAsync(currentUser);
        return View(users);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

