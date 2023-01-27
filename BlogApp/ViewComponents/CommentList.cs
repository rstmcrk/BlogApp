using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogApp.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName="Rüstem"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Anıl"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Melike"
                }
            };
            return View(commentValues);
        }
    }
}
