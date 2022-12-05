
namespace MauiLoginApp.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    [ObservableProperty]
    private string _userName;
    [ObservableProperty]
    private string _password;

    [ICommand]
    public async void Login()
    {
         
    }
}
