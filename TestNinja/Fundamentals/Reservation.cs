namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public Reservation()
        {
            
        }

        public bool CanBeCancelledBy(User user)
        {
            if (user == MadeBy) return true;

            if ((user!=null) && (user.IsAdmin)) return true;

            return false;
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}