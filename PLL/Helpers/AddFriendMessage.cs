namespace SocialNetwork.PLL.Helpers;

public class AddFriendMessage
{
    public static void Show(string message)
    {
        ConsoleColor originalColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ForegroundColor = originalColor;
    }
}