using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Larich.Achiever.Web.Areas.Manage.ViewModels.Achiever
{
    public class UpdateTitleViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string TemplateName { get; set; }

        public DateTime PostExpiry { get; set; }
    }
}
