namespace ConsumoElectrico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CargoFijoes",
                c => new
                    {
                        CFId = c.Int(nullable: false, identity: true),
                        CFDesc = c.String(maxLength: 50),
                        CFDesde = c.Int(nullable: false),
                        CFHasta = c.Int(nullable: false),
                        CFSinSubs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CFConSubs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaActivo = c.DateTime(nullable: false),
                        FechaLimite = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CFId);
            
            CreateTable(
                "dbo.LecturaDistribs",
                c => new
                    {
                        LDId = c.Int(nullable: false, identity: true),
                        LDFecha = c.DateTime(nullable: false),
                        LDLectura = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.LDId);
            
            CreateTable(
                "dbo.LecturaPropias",
                c => new
                    {
                        LPId = c.Int(nullable: false, identity: true),
                        LPFecha = c.DateTime(nullable: false),
                        LPLectura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LPSubsidio = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LPId);
            
            CreateTable(
                "dbo.PrecioEnergias",
                c => new
                    {
                        PEId = c.Int(nullable: false, identity: true),
                        PEDesc = c.String(maxLength: 50),
                        PEDesde = c.Int(nullable: false),
                        PEhasta = c.Int(nullable: false),
                        PESinSubs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PEConsubs = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaActivo = c.DateTime(nullable: false),
                        FechaLimite = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PEId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PrecioEnergias");
            DropTable("dbo.LecturaPropias");
            DropTable("dbo.LecturaDistribs");
            DropTable("dbo.CargoFijoes");
        }
    }
}
