using BLL.service.Abstraction;
using DAL.Entites;
using DAL.Repo.implemention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.service.implemention
{
    public class PostService:IPostService
    {
        public PostRepo service = new PostRepo();
        public List<post> GetAllposts() => service.GetAllposts();


        public post GetpostbyId(int id) => service.GetpostbyId(id);//handel return null


        public bool IsCreated(post post)//handel return false
        {

            if (service.IsCreated(post))
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsDeleted(int id)//make is deleted yes
        {

            if (service.IsDeleted(id))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsUpdated(post post)
        {

            if (IsUpdated(post))
            {

                return true;
            }
            else
            {
                return false;

            }

        }
    }
}
