using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.App.Data
{
    public class Location
    {
        public Location()
        {
        }

        public Location(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;

        public List<Timesheets>? Timesheets { get; set; }

    }
}
