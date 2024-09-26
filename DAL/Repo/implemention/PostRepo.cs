using DAL.DB;
using DAL.Entites;
using DAL.Repo.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.implemention
{
    public class PostRepo : IPostRepo
    {
        public ApplicationDBcontext DB = new ApplicationDBcontext();
        public List<post> GetAllposts()=> DB.posts.Where(n=>n.isDeleted==false).ToList();
       

        public post GetpostbyId(int id)=> DB.posts.Find(id);


        public bool IsCreated(post post)
        {
            var result = DB.posts.Add(post);
            if(result!=null)
            {
                DB.SaveChanges();
                return true;
            }
            else
            {
                    return false;
              
            }
           
        }

        public bool IsDeleted(int id)
        {
            var result = DB.posts.Where(n => n.id == id).FirstOrDefault();

            if (result != null)
            {
                result.isDeleted = true;
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

           
        }

        public bool IsUpdated(post post)
        {
            var result = DB.posts.Update(post);
            DB.SaveChanges();
            return true;
        }
    }
}
