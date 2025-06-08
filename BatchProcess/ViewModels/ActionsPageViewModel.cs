using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class ActionsPageViewModel: PageViewModel
{
    public string Test { get; set; } = "Process";

    public ActionsPageViewModel()
    {
        PageNames = ApplicationPageNames.Actions;
    }
}