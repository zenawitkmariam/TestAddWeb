using AddWebTestMVC.Data;
using AddWebTestMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AddWebTestMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

       public ActionResult Index(string SearchText, int currentPageIndex)
        {
            if (currentPageIndex == 0)
            {
                currentPageIndex = 1;
            }
            var userList = GetUserList(SearchText, currentPageIndex);
            return View(userList);
        }
        private UserViewModel GetUserList(string SearchText , int currentPage)
        {
            int maxRows = 3;
            var resutList = _context.Users.Where(t => (string.IsNullOrEmpty(SearchText) ||
            t.FirstName.ToLower().Contains(SearchText.ToLower()) ||
            t.LastName.ToLower().Contains(SearchText.ToLower()) ||
            t.EmailId.ToLower().Contains(SearchText.ToLower()) ||
            t.Address.ToLower().Contains(SearchText.ToLower())
            ));
            UserViewModel userList = new UserViewModel();
            userList.UserList = resutList.Skip((currentPage -1) * maxRows)
            .Take(maxRows)
                .ToList();

            
            double pageCount = (double)((decimal)resutList.ToList().Count() / Convert.ToDecimal(maxRows));
            userList.PageCount = (int)Math.Ceiling(pageCount);

            userList.CurrentPageIndex = currentPage;

            return userList;
        }

    }
}
