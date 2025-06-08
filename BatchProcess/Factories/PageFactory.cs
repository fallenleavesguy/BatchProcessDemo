using System;
using BatchProcess.Data;
using BatchProcess.ViewModels;

namespace BatchProcess.Factories;

public class PageFactory(Func<ApplicationPageNames, PageViewModel> factory)
{
    public PageViewModel GetPageViewModel(ApplicationPageNames pageName) => factory.Invoke(pageName);
}