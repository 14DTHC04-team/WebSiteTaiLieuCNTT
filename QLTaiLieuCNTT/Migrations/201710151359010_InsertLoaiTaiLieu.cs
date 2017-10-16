namespace QLTaiLieuCNTT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertLoaiTaiLieu : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO LoaiTaiLieux (ID, Loai) VALUES (1, 'Java')");
            Sql("INSERT INTO LoaiTaiLieux (ID, Loai) VALUES (2, 'C#')");
            Sql("INSERT INTO LoaiTaiLieux (ID, Loai) VALUES (3, 'JavaScript')");
            Sql("INSERT INTO LoaiTaiLieux (ID, Loai) VALUES (4, 'SQL Server')");
        }
        
        public override void Down()
        {

        }
    }
}
