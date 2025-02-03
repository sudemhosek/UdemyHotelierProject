using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelierProject.DataAccessLayer.Migrations
{
    public partial class AddMessageCategoryIDToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { // Eğer daha önce eklenmişse, foreign key'i kaldırmaya gerek yok
          // Eğer kolon yoksa, oluşturulacak
            migrationBuilder.AddColumn<int>(
                name: "MessageCategoryID",
                table: "contacts",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropIndex(
                name: "IX_contacts_MessageCategoryID",
                table: "contacts");

            migrationBuilder.DropColumn(
                name: "MessageCategoryID",
                table: "contacts");
        }
    }
}
