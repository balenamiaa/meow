using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel;

namespace Chatter;


public partial class ChatRoomsViewModel : ObservableObject
{


    [ICommand]
    void PopulateChatrooms()
    {
        Rooms = new List<ChatRoom>(new[]
        {
            new ChatRoom
            {
                Id = new ChatroomId(10),
                Name = "Room A",
                Description = "This is some description",
                Banner = new Uri("https://png.pngtree.com/png-vector/20210514/ourlarge/pngtree-scroll-paper-ribbon-banner-vector-design-chinese-styl-png-image_3294802.jpg")
            },
            new ChatRoom
            {
                Id = new ChatroomId(11),
                Name = "Room B",
                Description = "This is some description",
                Banner = new Uri("https://png.pngtree.com/png-vector/20210514/ourlarge/pngtree-scroll-paper-ribbon-banner-vector-design-chinese-styl-png-image_3294802.jpg")
            },
            new ChatRoom
            {
                Id = new ChatroomId(12),
                Name = "Room C",
                Description = "This is some description",
                Banner = new Uri("https://png.pngtree.com/png-vector/20210514/ourlarge/pngtree-scroll-paper-ribbon-banner-vector-design-chinese-styl-png-image_3294802.jpg")
            },
            new ChatRoom
            {
                Id = new ChatroomId(13),
                Name = "Room D",
                Description = "This is some description",
                Banner = new Uri("https://png.pngtree.com/png-vector/20210514/ourlarge/pngtree-scroll-paper-ribbon-banner-vector-design-chinese-styl-png-image_3294802.jpg")
            }
        });
    }

    public ChatRoomsViewModel(IMemoryCache cache)
    {
        Cache = cache;
        PopulateChatrooms();
    }

    [ObservableProperty]
    List<ChatRoom> rooms;
    IMemoryCache Cache { get; }
}

public partial class ChatRoomsPage : ContentPage
{

    public ChatRoomsPage(ChatRoomsViewModel chatRoomsViewModel)
    {
        InitializeComponent();
        BindingContext = chatRoomsViewModel;
    }


}

