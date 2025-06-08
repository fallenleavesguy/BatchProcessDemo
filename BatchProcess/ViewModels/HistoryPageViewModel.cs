using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class HistoryPageViewModel: PageViewModel
{
    public string Test { get; set; } = "Process";
    
    public HistoryPageViewModel()
    {
        PageNames = ApplicationPageNames.History;
    }
}