using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using XAF1.Module.BusinessObjects.Marketing;

namespace  XAF1.Module.BusinessObjects {
	public class XAF1DbContext : DbContext {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }
        public XAF1DbContext(String connectionString)
			: base(connectionString) {
		}
		public XAF1DbContext(DbConnection connection)
			: base(connection, false) {
		}
		public XAF1DbContext()
			: base("name=ConnectionString") {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	}
}