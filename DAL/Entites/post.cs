namespace DAL.Entites
{
    public class post
    {

        public int id { get; set; }

        public bool isDeleted { get; set; }


        public string content { get; set; }

        //List<comment>? coments { get; set; }

        //List<like>? likes { get; set; }
        

        //public int userId { get; set; }
        public user user { get; set; }

    }
}
