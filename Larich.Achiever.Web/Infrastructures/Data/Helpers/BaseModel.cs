using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Larich.Achiever.Web.Infrastructures.Data.Helpers
{
    public class BaseModel
    {
        public Guid? Id { get; set; }

        public DateTime Timestamp { get; set; }

        public BaseModel()
        {
            this.Timestamp = DateTime.UtcNow;
        }
    }
}
