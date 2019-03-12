using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Larich.Achiever.Web.Areas.Manage.ViewModels.Achiever
{
    public class UpdateContentViewModel
    {
        public Guid? AchieverId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}