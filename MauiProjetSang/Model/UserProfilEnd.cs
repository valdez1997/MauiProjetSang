

namespace MauiProjetSang.Model;

public  class UserProfilEnd
{
        public string Staus { get; set; }
        public User User { get; set; }
 }
    public class User
    {
        public int id { get; set; }
        public object userable_id { get; set; }
        public object userable_type { get; set; }
        public string name { get; set; }
        public string ip { get; set; }
        public string role_id { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public DateTime email_verified_at { get; set; }
        public object last_seen { get; set; }
        public string phone_number { get; set; }
        public string birth_date { get; set; }
        public string is_active { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

