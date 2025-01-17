using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views;

public class UserFriendsView
{
    public void Show(IEnumerable<User> friends)
    {
        Console.WriteLine("Друзья:");

        if (friends.Count() == 0)
        {
            Console.WriteLine("Друзей нет");
            return;
        }

        friends.ToList().ForEach(friend =>
        {
            Console.WriteLine(friend.FirstName, friend.LastName, friend.Email);
        });
    }
}