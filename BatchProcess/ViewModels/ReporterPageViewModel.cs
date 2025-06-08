using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class ReporterPageViewModel: PageViewModel
{
    public string Test { get; set; } = "Process";
    
    public ReporterPageViewModel()
    {
        PageNames = ApplicationPageNames.Reporter;
    }
}