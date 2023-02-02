namespace JwtWebAPI.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "jadeashish", EmailAddress = "jadeashish@email.com", Password = "password123", GivenName = "Ashish", Surname = "Jade", Role = "Administrator" },
            new UserModel() { Username = "jademeer", EmailAddress = "jademeer@email.com", Password = "password321", GivenName = "Meer", Surname = "Jade", Role = "Seller" },
        };
    }
}
