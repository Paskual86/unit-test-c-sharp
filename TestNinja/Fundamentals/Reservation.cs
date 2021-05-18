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
            return ((user != null) && ((user.IsAdmin) || (user == MadeBy)));
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}