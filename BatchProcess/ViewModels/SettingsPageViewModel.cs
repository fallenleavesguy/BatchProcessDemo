using System.Collections.Generic;
using BatchProcess.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcess.ViewModels;

public partial class SettingsPageViewModel: PageViewModel
{
    [ObservableProperty]
    private List<string> _locationPaths;
    
    public SettingsPageViewModel()
    {
        PageNames = ApplicationPageNames.Settings;
        
        // TEMP: Remove
        LocationPaths =
        [
            @"c:\temp\batchprocess\",
            @"c:\temp\batchprocess\logs\",
            @"c:\temp\batchprocess\reports\",
            @"c:\temp\batchprocess\actions\",
            @"c:\temp\batchprocess\macros\",
        ];
    }
};