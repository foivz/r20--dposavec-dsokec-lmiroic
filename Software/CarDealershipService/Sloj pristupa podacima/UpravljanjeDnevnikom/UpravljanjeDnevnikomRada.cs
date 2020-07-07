using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloj_pristupa_podacima.UpravljanjeDnevnikom
{
    public class UpravljanjeDnevnikomRada
    {
        public static void DodajNoviZapis(Dnevnik_rada dnevnik)
        {
			try
			{
                using (var db = new CarDealershipandServiceEntities())
                {
                    db.Dnevnik_rada.Add(dnevnik);
                    db.SaveChanges();
                }
            }
			catch (Exception ex)
			{
                
			}
        }
    }
}
