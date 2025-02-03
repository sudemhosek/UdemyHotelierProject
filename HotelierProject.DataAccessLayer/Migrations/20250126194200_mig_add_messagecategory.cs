using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelierProject.DataAccessLayer.Migrations
{
    public partial class mig_add_messagecategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "messageCategories",
                columns: table => new
                {
                    MessageCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messageCategories", x => x.MessageCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contacts_MessageCategoryID",
                table: "contacts",
                column: "MessageCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_contacts_messageCategories_MessageCategoryID",
                table: "contacts",
                column: "MessageCategoryID",
                principalTable: "messageCategories",
                principalColumn: "MessageCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contacts_messageCategories_MessageCategoryID",
                table: "contacts");

            migrationBuilder.DropTable(
                name: "messageCategories");

            migrationBuilder.DropIndex(
                name: "IX_contacts_MessageCategoryID",
                table: "contacts");
        }
    }
}
