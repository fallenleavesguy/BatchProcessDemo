using Avalonia.Svg.Skia;
using BatchProcess.Data;
using BatchProcess.Factories;
using BatchProcess.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace BatchProcess.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private PageFactory _pageFactory;
    private const string ButtonActiveClass = "active";
    
    [ObservableProperty] private bool _sideMenuExpanded = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ProcessPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ActionsPageIsActive))]
    [NotifyPropertyChangedFor(nameof(MacrosPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ReporterPageIsActive))]
    [NotifyPropertyChangedFor(nameof(HistoryPageIsActive))]
    [NotifyPropertyChangedFor(nameof(SettingsPageIsActive))]
    private PageViewModel _currentPage;

    public bool HomePageIsActive => CurrentPage.PageNames == ApplicationPageNames.Home;
    public bool ProcessPageIsActive => CurrentPage.PageNames == ApplicationPageNames.Process;
    public bool ActionsPageIsActive => CurrentPage.PageNames == ApplicationPageNames.Actions;
    public bool MacrosPageIsActive => CurrentPage.PageNames == ApplicationPageNames.Macros;
    public bool ReporterPageIsActive => CurrentPage.PageNames == ApplicationPageNames.Reporter;
    public bool HistoryPageIsActive => CurrentPage.PageNames == ApplicationPageNames.History;
    public bool SettingsPageIsActive => CurrentPage.PageNames == ApplicationPageNames.Settings;

    public MainViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory;
        GoToHome();
    }

    [RelayCommand]
    private void SideMenuResize()
    {
        this.SideMenuExpanded = !this.SideMenuExpanded;
    }

    [RelayCommand]
    private void GoToHome()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Home);
    }

    [RelayCommand]
    private void GoToProcess()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Process);
    }
    
    [RelayCommand]
    private void GoToActions()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Actions);
    }
    
    [RelayCommand]
    private void GoToMacros()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Macros);
    }
    
    [RelayCommand]
    private void GoToReporter()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Reporter);
    }
    
    [RelayCommand]
    private void GoToHistory()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.History);
    }
    
    [RelayCommand]
    private void GoToSettings()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Settings);
    }
}