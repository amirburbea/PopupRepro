using System.Reflection;
using System.Runtime.Versioning;

namespace PopupRepro;

partial class MainWindow
{
    public MainWindow()
    {
        this.Title = Assembly.GetEntryAssembly()!.GetCustomAttribute<TargetFrameworkAttribute>()!.FrameworkName;
        InitializeComponent();
    }
}