namespace QLTaiLieuCNTT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableTaiLieu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiTaiLieux",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Loai = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaiLieux",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(nullable: false, maxLength: 128),
                        Link = c.String(nullable: false, maxLength: 500),
                        DateTime = c.DateTime(nullable: false),
                        LoaiTaiLieu_Id = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerId, cascadeDelete: true)
                .ForeignKey("dbo.LoaiTaiLieux", t => t.LoaiTaiLieu_Id)
                .Index(t => t.LecturerId)
                .Index(t => t.LoaiTaiLieu_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TaiLieux", "LoaiTaiLieu_Id", "dbo.LoaiTaiLieux");
            DropForeignKey("dbo.TaiLieux", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.TaiLieux", new[] { "LoaiTaiLieu_Id" });
            DropIndex("dbo.TaiLieux", new[] { "LecturerId" });
            DropTable("dbo.TaiLieux");
            DropTable("dbo.LoaiTaiLieux");
        }
    }
}
