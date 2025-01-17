﻿using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace SocialNetwork;

class Program
{
    static FriendAddService friendAddService;
    static MessageService messageService;
    static UserService userService;
    public static MainView mainView;
    public static RegistrationView registrationView;
    public static AuthenticationView authenticationView;
    public static UserMenuView userMenuView;
    public static UserInfoView userInfoView;
    public static UserDataUpdateView userDataUpdateView;
    public static MessageSendingView messageSendingView;
    public static UserIncomingMessageView userIncomingMessageView;
    public static UserOutcomingMessageView userOutcomingMessageView;
    public static AddFriendsView addFriendsView;
    public static UserFriendsView userFriendsView;

    static void Main(string[] args)
    {
        friendAddService = new FriendAddService();
        userService = new UserService();
        messageService = new MessageService();
        mainView = new MainView();
        registrationView = new RegistrationView(userService);
        authenticationView = new AuthenticationView(userService);
        userMenuView = new UserMenuView(userService);
        userInfoView = new UserInfoView();
        userDataUpdateView = new UserDataUpdateView(userService);
        messageSendingView = new MessageSendingView(messageService, userService);
        userIncomingMessageView = new UserIncomingMessageView();
        userOutcomingMessageView = new UserOutcomingMessageView();
        addFriendsView = new AddFriendsView(friendAddService);
        userFriendsView = new UserFriendsView();

        while (true)
        {
            mainView.Show();
        }
    }
}