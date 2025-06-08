using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class MacrosPageViewModel: PageViewModel
{
    public string Test { get; set; } = "Process";
    
    public MacrosPageViewModel()
    {
        PageNames = ApplicationPageNames.Macros;
    }
}