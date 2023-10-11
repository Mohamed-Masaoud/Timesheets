using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheets.App.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    BillingAddress = table.Column<string>(type: "TEXT", nullable: false),
                    ContactName = table.Column<string>(type: "TEXT", nullable: false),
                    ContactTelephone = table.Column<long>(type: "INTEGER", nullable: false),
                    ContactEmail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurName = table.Column<string>(type: "TEXT", nullable: false),
                    ForeName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timesheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MinutesWorked = table.Column<int>(type: "INTEGER", nullable: false),
                    StaffId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timesheets_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Timesheets_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Timesheets_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone" },
                values: new object[] { 1, "123 Main St, Cityville", "ABC Inc.", "john.doe@abcinc.com", "John Doe", 5555555555L });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone" },
                values: new object[] { 2, "456 Oak Ave, Townsville", "XYZ Corporation", "jane.smith@xyzcorp.com", "Jane Smith", 5555555556L });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone" },
                values: new object[] { 3, "789 Elm Rd, Villagetown", "123 Industries", "bob.johnson@123ind.com", "Bob Johnson", 5555555557L });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone" },
                values: new object[] { 4, "101 Pine Ln, Hamletville", "LMN Ltd.", "sarah.williams@lmnltd.com", "Sarah Williams", 5555555558L });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BillingAddress", "CompanyName", "ContactEmail", "ContactName", "ContactTelephone" },
                values: new object[] { 5, "202 Cedar Dr, Burgville", "PQR Enterprises", "michael.davis@pqrent.com", "Michael Davis", 5555555559L });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 1, "123 Main St, Cityville", "Main Office" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 2, "456 Oak Ave, Townsville", "Branch A" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 3, "789 Elm Rd, Villagetown", "Factory" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 4, "101 Pine Ln, Hamletville", "Warehouse" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { 5, "202 Cedar Dr, Burgville", "Retail Store" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "ForeName", "SurName" },
                values: new object[] { 1, "john.doe@example.com", "John", "Doe" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "ForeName", "SurName" },
                values: new object[] { 2, "jane.smith@example.com", "Jane", "Smith" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "ForeName", "SurName" },
                values: new object[] { 3, "bob.johnson@example.com", "Bob", "Johnson" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "ForeName", "SurName" },
                values: new object[] { 4, "sarah.williams@example.com", "Sarah", "Williams" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Email", "ForeName", "SurName" },
                values: new object[] { 5, "michael.davis@example.com", "Michael", "Davis" });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 1, 3, 2, 480, 4 });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 2, 5, 1, 520, 2 });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 3, 2, 4, 420, 1 });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 4, 4, 3, 450, 5 });

            migrationBuilder.InsertData(
                table: "Timesheets",
                columns: new[] { "Id", "ClientId", "LocationId", "MinutesWorked", "StaffId" },
                values: new object[] { 5, 1, 5, 490, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_ClientId",
                table: "Timesheets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_LocationId",
                table: "Timesheets",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheets_StaffId",
                table: "Timesheets",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timesheets");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
