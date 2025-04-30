using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using QLKho_NCKH.Authorization.Roles;
using QLKho_NCKH.Authorization.Users;
using QLKho_NCKH.MultiTenancy;

namespace QLKho_NCKH.EntityFrameworkCore
{
    public class QLKho_NCKHDbContext : AbpZeroDbContext<Tenant, Role, User, QLKho_NCKHDbContext>
    {
		/* Define a DbSet for each entity of the application */
		//public DbSet<netcore.Models.ApplicationUser> ApplicationUser { get; set; }

		public DbSet<netcore.Models.Invent.Branch> Branch { get; set; }

		public DbSet<netcore.Models.Invent.Warehouse> Warehouse { get; set; }

		public DbSet<netcore.Models.Invent.Product> Product { get; set; }

		public DbSet<netcore.Models.Invent.Vendor> Vendor { get; set; }

		public DbSet<netcore.Models.Invent.VendorLine> VendorLine { get; set; }

		public DbSet<netcore.Models.Invent.PurchaseOrder> PurchaseOrder { get; set; }

		public DbSet<netcore.Models.Invent.PurchaseOrderLine> PurchaseOrderLine { get; set; }

		public DbSet<netcore.Models.Invent.Customer> Customer { get; set; }

		public DbSet<netcore.Models.Invent.CustomerLine> CustomerLine { get; set; }

		public DbSet<netcore.Models.Invent.SalesOrder> SalesOrder { get; set; }

		public DbSet<netcore.Models.Invent.SalesOrderLine> SalesOrderLine { get; set; }

		public DbSet<netcore.Models.Invent.Shipment> Shipment { get; set; }

		public DbSet<netcore.Models.Invent.ShipmentLine> ShipmentLine { get; set; }

		public DbSet<netcore.Models.Invent.Receiving> Receiving { get; set; }

		public DbSet<netcore.Models.Invent.ReceivingLine> ReceivingLine { get; set; }

		public DbSet<netcore.Models.Invent.TransferOrder> TransferOrder { get; set; }

		public DbSet<netcore.Models.Invent.TransferOrderLine> TransferOrderLine { get; set; }

		public DbSet<netcore.Models.Invent.TransferOut> TransferOut { get; set; }

		public DbSet<netcore.Models.Invent.TransferOutLine> TransferOutLine { get; set; }

		public DbSet<netcore.Models.Invent.TransferIn> TransferIn { get; set; }

		public DbSet<netcore.Models.Invent.TransferInLine> TransferInLine { get; set; }
		public QLKho_NCKHDbContext(DbContextOptions<QLKho_NCKHDbContext> options)
            : base(options)
        {
        }
    }
}
