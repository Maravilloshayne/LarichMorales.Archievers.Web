using Larich.Achiever.Web.Infrastructures.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Larich.Achiever.Web.Infrastructures.Data.Models
{
    public class Achiever : BaseModel
    {
        public string Title { get; set; }

        public Guid? UserId { get; set; }

        public string Content { get; set; }

        public string TemplateName { get; set; }

        public DateTime PostExpiry { get; set; }

        public bool IsPublished { get; set; }

    }
}
