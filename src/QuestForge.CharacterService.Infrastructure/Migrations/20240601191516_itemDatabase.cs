using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestForge.CharacterService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class itemDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerItemDataModel_ItemDataModel_ItemId",
                table: "PlayerItemDataModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemDataModel",
                table: "ItemDataModel");

            migrationBuilder.RenameTable(
                name: "ItemDataModel",
                newName: "Items");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItemDataModel_Items_ItemId",
                table: "PlayerItemDataModel",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerItemDataModel_Items_ItemId",
                table: "PlayerItemDataModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "ItemDataModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemDataModel",
                table: "ItemDataModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerItemDataModel_ItemDataModel_ItemId",
                table: "PlayerItemDataModel",
                column: "ItemId",
                principalTable: "ItemDataModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
