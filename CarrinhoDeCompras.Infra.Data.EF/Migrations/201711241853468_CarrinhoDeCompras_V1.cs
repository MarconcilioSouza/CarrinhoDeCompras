namespace CarrinhoDeCompras.Infra.Data.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarrinhoDeCompras_V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        Description = c.String(storeType: "ntext"),
                        Picture = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        Title = c.String(maxLength: 30),
                        TitleOfCourtesy = c.String(maxLength: 25),
                        BirthDate = c.DateTime(),
                        HireDate = c.DateTime(),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        HomePhone = c.String(maxLength: 24),
                        Extension = c.String(maxLength: 4),
                        Photo = c.Binary(storeType: "image"),
                        Notes = c.String(storeType: "ntext"),
                        ReportsTo = c.Int(),
                        PhotoPath = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID });
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        Customer = c.String(nullable: false, maxLength: 5, fixedLength: true),
                        EmployeeID = c.Int(),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ShipVia = c.Int(nullable: false),
                        Freight = c.Decimal(precision: 18, scale: 2),
                        ShipName = c.String(maxLength: 40, unicode: false),
                        ShipAddress = c.String(maxLength: 60, unicode: false),
                        ShipCity = c.String(maxLength: 15, unicode: false),
                        ShipRegion = c.String(maxLength: 15, unicode: false),
                        ShipPostalCode = c.String(maxLength: 10, unicode: false),
                        ShipCountry = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        SupplierID = c.Int(),
                        CategoryID = c.Int(),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(precision: 18, scale: 2),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.CustomerDemographics",
                c => new
                    {
                        CustomerTypeID = c.Int(nullable: false, identity: true),
                        CustomerDesc = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.CustomerTypeID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.String(nullable: false, maxLength: 5),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactTitle = c.String(maxLength: 30),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        RegionID = c.Int(nullable: false, identity: true),
                        RegionDescription = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.RegionID);
            
            CreateTable(
                "dbo.Shippers",
                c => new
                    {
                        ShipperID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40, unicode: false),
                        Phone = c.String(maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.ShipperID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40, unicode: false),
                        ContactName = c.String(maxLength: 30, unicode: false),
                        ContactTitle = c.String(maxLength: 30, unicode: false),
                        Address = c.String(maxLength: 60, unicode: false),
                        City = c.String(maxLength: 15, unicode: false),
                        Region = c.String(maxLength: 15, unicode: false),
                        PostalCode = c.String(maxLength: 100, unicode: false),
                        Country = c.String(maxLength: 15, unicode: false),
                        Phone = c.String(maxLength: 24, unicode: false),
                        Fax = c.String(maxLength: 24, unicode: false),
                        HomePage = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.Territories",
                c => new
                    {
                        TerritoryID = c.Int(nullable: false, identity: true),
                        TerritoryDescription = c.String(nullable: false, maxLength: 50, unicode: false),
                        RegionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TerritoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Territories");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Shippers");
            DropTable("dbo.Region");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerDemographics");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.Categories");
        }
    }
}
