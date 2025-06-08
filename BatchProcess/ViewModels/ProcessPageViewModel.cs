using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class ProcessPageViewModel: PageViewModel
{
    public string Test { get; set; } = "Process";
    
    public ProcessPageViewModel()
    {
        PageNames = ApplicationPageNames.Process;
    }
}