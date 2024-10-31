using System;
using Privet.ViewModels;
using Privet.Views;

namespace Privet;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
        
    /// <summary>
    /// Application Entry for Privet
    /// </summary>
    public App()
    {
        var view = new MainView
        {
            DataContext = Activator.CreateInstance<MainViewModel>()
        };
            
        view.Show();
    }
        
}