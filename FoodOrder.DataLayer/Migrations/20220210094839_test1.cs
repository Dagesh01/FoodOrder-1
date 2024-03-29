﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodOrder.DataLayer.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahsulotlar_Users_UserId",
                table: "Mahsulotlar");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Mahsulotlar",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahsulotlar_Users_UserId",
                table: "Mahsulotlar",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahsulotlar_Users_UserId",
                table: "Mahsulotlar");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Mahsulotlar",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mahsulotlar_Users_UserId",
                table: "Mahsulotlar",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
