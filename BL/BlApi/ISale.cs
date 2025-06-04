using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ISale
    {
        int Create(Sale sale);
        Sale? Read(int id);
        Sale? Read(Func<Sale, bool>? filter);
        List<Sale> ReadAll(Func<Sale, bool>? filter = null);
        void Update(Sale sale);
        void Delete(int id);
    }
}
