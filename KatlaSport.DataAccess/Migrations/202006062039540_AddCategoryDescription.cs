using System.Data.Entity.Migrations;

namespace KatlaSport.DataAccess.Migrations
{
    public partial class AddCategoryDescription : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.catalogue_products", "product_description");
            DropColumn("dbo.catalogue_products", "product_manufacturer_code");
            DropColumn("dbo.catalogue_products", "product_price");
        }

        public override void Down()
        {
            AddColumn("dbo.catalogue_products", "product_price", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.catalogue_products", "product_manufacturer_code", c => c.String(maxLength: 10));
            AddColumn("dbo.catalogue_products", "product_description", c => c.String(maxLength: 300));
        }
    }
}
