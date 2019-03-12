using Larich.Achiever.Web.Infrastructures.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Larich.Achiever.Web.Areas.Manage.ViewModels.Achiever
{
    public class IndexViewModel
    {
        public Page<Larich.Achiever.Web.Infrastructures.Data.Models.Achiever> Achievers { get; set; }
    }
}
