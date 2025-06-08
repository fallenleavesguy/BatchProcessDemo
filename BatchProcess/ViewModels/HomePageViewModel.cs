using BatchProcess.Data;

namespace BatchProcess.ViewModels;

public partial class HomePageViewModel: PageViewModel
{
   public string Test { get; set; } = "Home";
   
   public HomePageViewModel()
   {
      PageNames = ApplicationPageNames.Home;
   }
}