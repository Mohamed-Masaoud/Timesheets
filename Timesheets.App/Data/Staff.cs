using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.App.Data
{
    public class Staff
    {
        public Staff()
        {
        }

        public Staff(string surName, int id, string foreName, string email)
        {
            SurName = surName;
            Id = id;
            ForeName = foreName;
            Email = email;
        }

        public string SurName { get; set; } = null!;
        public int Id { get; set; }
        public string ForeName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public List<Timesheets>? Timesheets { get; set; }
    }
}
