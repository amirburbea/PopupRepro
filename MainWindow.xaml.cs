using System.Reflection;
using System.Runtime.Versioning;
using System.Windows;

namespace PopupRepro;

partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Title = Assembly.GetEntryAssembly()!.GetCustomAttribute<TargetFrameworkAttribute>()!.FrameworkName;
    }
}