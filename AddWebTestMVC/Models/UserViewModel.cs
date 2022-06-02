using System.Collections.Generic;

namespace AddWebTestMVC.Models
{
    public class UserViewModel
    {
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
        public List<User> UserList { get; set; }
    }
}
