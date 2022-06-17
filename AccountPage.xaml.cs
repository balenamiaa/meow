using CommunityToolkit.Mvvm.ComponentModel;

namespace Chatter;


public partial class AccountPageViewModel : ObservableObject
{
    [ObservableProperty]
    bool applyButtonAllowed;

    public AccountPageViewModel()
    {
        applyButtonAllowed = false;
    }
}
public partial class AccountPage : ContentPage
{
    AccountPageViewModel ViewModel { get; }
    public AccountPage(AccountPageViewModel viewModel)
    {
        InitializeComponent();
        ViewModel = viewModel;
        BindingContext = ViewModel;

        ApplyButton.Clicked += ApplyButton_Clicked;
    }

    private void ApplyButton_Clicked(object sender, EventArgs e)
    {
        //TODO: change name and other account properties

        //TODO: Get rid of this hack.
        Task.Run(() => ViewModel.ApplyButtonAllowed = false);
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        ViewModel.ApplyButtonAllowed = true;
    }
}