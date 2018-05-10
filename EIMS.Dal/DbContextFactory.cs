using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
namespace EIMS.Dal
{
    class DbContextFactory
    {
        public static DbContext GetDbContext()
        {
            DbContext context = CallContext.GetData("Dbcontext") as EIMS_DATA;
            if (context == null)
            {
                context = new EIMS_DATA();
                CallContext.SetData("Dbcontext", context);
            }
            return context;
        }
    }
}
