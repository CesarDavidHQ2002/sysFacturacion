
using sysFacturacion.EL;
using Microsoft.EntityFrameworkCore;

namespace sysFacturacion.DAL
{
    public class CategoryDAL
    {
        private readonly bDTiketContext contex;

        public int Add(categori categori)
        {
            // Regla: si guarda 1 y si no 0
            // != significa DIFERENTE
            if (categori != null)
            {
                contex.Add(categori);
                return contex.SaveChanges();
            }
            return 0;
        }

        public int Update(categori categori)
        {
            if (categori != null)
            {
                contex.Update(categori);
                return contex.SaveChanges();
            }
            return 0;
        }
        public int Delete(categori categori)
        {
            if (categori != null)
            {
                contex.Remove(categori);
                return contex.SaveChanges();
            }
            return 0;
        }

        public List<categori> FindAll()
        {
            return contex.Categoris.ToList();
        }
    }
}
