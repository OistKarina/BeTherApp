using BeTherApp.ViewModels;

namespace BeTherApp.View;
public partial class LoginPage : ContentPage
{
    public LoginPage(ConnectToAppViewModle i_LoginLogic)
    {
        InitializeComponent();
        BindingContext = i_LoginLogic;
    }
}
