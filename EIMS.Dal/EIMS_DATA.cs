namespace EIMS.Dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using EIMS.Model;
    public class EIMS_DATA : DbContext
    {

        public EIMS_DATA()
            : base("name=EIMS_DATA")
        {
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
