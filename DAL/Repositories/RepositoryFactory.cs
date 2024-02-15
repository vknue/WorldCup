using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RepositoryFactory
    {
        public static IRepository GetRepository() => Settings.load()
            .dataAccessMode == DataAccessMode.API 
            ? APIRepository.Instance 
            : FileRepository.Instance;
        
    }

}

