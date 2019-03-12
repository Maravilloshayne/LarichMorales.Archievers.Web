using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Larich.Achiever.Web.Areas.Manage.ViewModels.Achiever
{
    public class AttachImageViewModel
    {
        public Guid? AchieverId { get; set; }
        public IFormFile Image { get; set; }
    }
}
