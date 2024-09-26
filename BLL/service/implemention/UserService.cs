using BLL.service.Abstraction;
using DAL.DB;
using DAL.Entites;
using DAL.Repo.implemention;


namespace BLL.service.implemention
{
    public class UserService:IUserService
    {
        public UserRepo service = new UserRepo();
        public List<user> GetAllUsers() => service.GetAllUsers();


        public user GetUserbyId(int id) => service.GetUserbyId(id);//handel return null


        public bool IsCreated(user user)//handel return false
        {

            if (service.IsCreated(user))
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

        public bool IsUpdated(user user)
        {
           
            if (IsUpdated(user))
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
