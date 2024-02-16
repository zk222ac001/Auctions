using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionsApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Bid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bid_AspNetUsers_IdentityUserId",
                table: "Bid");

            migrationBuilder.DropForeignKey(
                name: "FK_Bid_Listings_ListingId",
                table: "Bid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bid",
                table: "Bid");

            migrationBuilder.RenameTable(
                name: "Bid",
                newName: "Bids");

            migrationBuilder.RenameIndex(
                name: "IX_Bid_ListingId",
                table: "Bids",
                newName: "IX_Bids_ListingId");

            migrationBuilder.RenameIndex(
                name: "IX_Bid_IdentityUserId",
                table: "Bids",
                newName: "IX_Bids_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bids",
                table: "Bids",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_AspNetUsers_IdentityUserId",
                table: "Bids",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Listings_ListingId",
                table: "Bids",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_AspNetUsers_IdentityUserId",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Listings_ListingId",
                table: "Bids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bids",
                table: "Bids");

            migrationBuilder.RenameTable(
                name: "Bids",
                newName: "Bid");

            migrationBuilder.RenameIndex(
                name: "IX_Bids_ListingId",
                table: "Bid",
                newName: "IX_Bid_ListingId");

            migrationBuilder.RenameIndex(
                name: "IX_Bids_IdentityUserId",
                table: "Bid",
                newName: "IX_Bid_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bid",
                table: "Bid",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bid_AspNetUsers_IdentityUserId",
                table: "Bid",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bid_Listings_ListingId",
                table: "Bid",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id");
        }
    }
}
