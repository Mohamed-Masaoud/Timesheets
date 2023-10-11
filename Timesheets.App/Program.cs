// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Timesheets.App.Data;

var db = new TimesheetsDbContext();
IQueryable<Staff> allStaff = db.Staff;
foreach (var staff in allStaff)
{
    Console.WriteLine(staff.SurName);
}
Staff first = db.Staff.First();
Console.WriteLine(first.SurName);
Console.WriteLine("\n\n");
IQueryable<Location> includeH = db.Locations
                                .Where(h => h.Name.Contains("h"))
                                .OrderByDescending(h => h.Id);
foreach (var location in includeH)
{ Console.WriteLine($"{location.Name} {location.Id}"); }
Console.WriteLine("\n\n");

// Use select to fetch related entities
var time = db.Timesheets
                .Select(m => new
                {
                    m.Id,
                    m.LocationId,
                    LocationName = m.Location.Name,
                    cleintName = m.Client.ContactName
                })
                .First();
Console.WriteLine($"{time.Id} {time.LocationName} {time.cleintName}");

// use include to load related entities
var time2 =  db.Timesheets.Include(m => m.Staff).Skip(4).First();
Staff stf = time2.Staff;
Console.WriteLine(stf.SurName);

// Update properties
var updateStaff = db.Staff
                    .Where(s => s.Id == 1)
                    .FirstOrDefault();

updateStaff.SurName = "Mohamed";
updateStaff.ForeName = "Masaoud";
updateStaff.Email = "MM@gmail.com";
db.SaveChanges();
