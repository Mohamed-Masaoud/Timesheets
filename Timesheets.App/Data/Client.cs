using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timesheets.App.Data
{
    public class Client
    {
        public Client()
        {
        }

        public Client(int id, string companyName, string billingAddress, string contactName, long contactTelephone, string contactEmail)
        {
            Id = id;
            CompanyName = companyName;
            BillingAddress = billingAddress;
            ContactName = contactName;
            ContactTelephone = contactTelephone;
            ContactEmail = contactEmail;
        }

        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string BillingAddress { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public long ContactTelephone { get; set; }
        public string ContactEmail { get; set; } = null!;

        public List<Timesheets>? Timesheets { get; set; }
    }
}
