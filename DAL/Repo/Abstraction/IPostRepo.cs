using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entites;

namespace DAL.Repo.Abstraction
{
    public interface IPostRepo
    {
        public List<post> GetAllposts();

        public post GetpostbyId(int id);

        public bool IsCreated(post post);

        public bool IsDeleted(int id);

        public bool IsUpdated(post post);
    }
}
