namespace InfoUASD.Models.Models
{
    using System.Data.Entity;

    public class InfoUASDDataModel : DbContext
    {
        public InfoUASDDataModel() : base("name=InfoUASDDataModel"){ }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Info> Info { get; set; }
    }
}