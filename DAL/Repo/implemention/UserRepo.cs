using DAL.Repo.Abstraction;
using DAL.DB;
using DAL.Entites;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repo.implemention
{
    public class UserRepo : IUserRepo
    {
        public ApplicationDBcontext DB =new ApplicationDBcontext();
        public List<user> GetAllUsers()=> DB.users.ToList();


        public user GetUserbyId(int id) => DB.users.Find(id);//handel return null
       

        public bool IsCreated(user user)//handel return false
        {

            try
            {

                DB.users.Add(user);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                
                return false;
            }


           
        }

        public bool IsDeleted(int id)//make is deleted yes
        {
            var result = DB.users.Where(n => n.id == id).FirstOrDefault();
            result.IsDeleted = true;    
            if (result != null)
            {
                DB.users.Remove(result);
                DB.SaveChanges();
                return true;
            }
            else {
                return false;
            }
            
           
        }

        public bool IsUpdated(user user)
        {
            var result = DB.users.Update(user);
            if (result != null)
            {
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;

            }
           
        }
    }
}
