using Avalonia.Svg.Skia;
using BatchProcess.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcess.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private const string ButtonActiveClass = "active";
    
    [ObservableProperty] private bool _sideMenuExpanded = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ProcessPageIsActive))]
    private ViewModelBase _currentPage;

    public bool HomePageIsActive => CurrentPage == _homePage;
    public bool ProcessPageIsActive => CurrentPage == _processPage;

    private readonly HomePageViewModel _homePage = new HomePageViewModel();
    private readonly ProcessPageViewModel _processPage = new ProcessPageViewModel();

    public MainViewModel()
    {
        CurrentPage = _homePage;
    }

    [RelayCommand]
    private void SideMenuResize()
    {
        this.SideMenuExpanded = !this.SideMenuExpanded;
    }

    [RelayCommand]
    private void GoToHome()
    {
        CurrentPage = _homePage;
    }

    [RelayCommand]
    private void GoToProcess()
    {
        CurrentPage = _processPage;
    }
}