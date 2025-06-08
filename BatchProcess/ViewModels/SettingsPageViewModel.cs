using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class SettingsPageViewModel: PageViewModel
{
    public string Test { get; set; } = "Process";
    
    public SettingsPageViewModel()
    {
        PageNames = ApplicationPageNames.Settings;
    }
}