using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.App.Data
{
    public class Timesheets
    {
        public Timesheets(int id, int minutesWorked, int staffId, int clientId, int locationId)
        {
            Id = id;
            MinutesWorked = minutesWorked;
            StaffId = staffId;
            ClientId = clientId;
            LocationId = locationId;
        }

        public int Id { get; set; }
        public int MinutesWorked { set; get; }
        public int StaffId { set; get;}
        public int ClientId { set; get; }
        public int LocationId { set; get; } 

        public Client? Client { set; get; }
        public Staff? Staff { set; get; }
        public Location? Location { set; get; }
    }
}
