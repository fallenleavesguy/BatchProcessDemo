using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using BatchProcess.ViewModels;
using BatchProcess.Views;

namespace BatchProcess;

public class ViewLocator: IDataTemplate
{
    public Control? Build(object? data)
    {
        if (data is null) return null;
        
        Debug.WriteLine(data.GetType().FullName);

        var viewName = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.InvariantCulture);
        var type = Type.GetType(viewName);

        if (type is null) return null;

        var control = (Control)Activator.CreateInstance(type)!;
        control.DataContext = data;

        return control;
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}