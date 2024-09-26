using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entites;

namespace DAL.Repo.Abstraction
{
    public interface IUserRepo
    {
        public List<user> GetAllUsers();

        public user GetUserbyId(int id);

        public bool IsCreated( user user);

        public bool IsDeleted(int id);

        public bool IsUpdated(  user user);

    }
}
