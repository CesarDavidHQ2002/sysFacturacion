using sysFacturacion.EL;
using Microsoft.EntityFrameworkCore;

namespace sysFacturacion.DAL
{
    public class ProductDAL
    {
        private readonly bDTiketContext contex;
        public int Add(product product)
        {
            // Regla: si guarda 1 y si no 0
            // != significa DIFERENTE
            if (product != null)
            {
                contex.Add(product);
                return contex.SaveChanges();
            }
            return 0;
        }

        public int Update(product product)
        {
            if (product != null)
            {
                contex.Update(product);
                return contex.SaveChanges();
            }
            return 0;
        }
        public int Delete(product product)
        {
            if (product != null)
            {
                contex.Remove(product);
                return contex.SaveChanges();
            }
            return 0;
        }
        public List<product> FindAll()
        {
            return contex.Products.ToList();
        }
    }
}
