# .NET 6.0 WPF Repro

.NET 6.0 seems to have introduced a bug in how popup tooltips work on dropdowns. 

In this repository, when running the application, you'll see a `ListBox` and a `ComboBox` both bound to the same `CollectionViewSource`. Both controls have an `ItemContainerStyle` where the item container should bind its `DataContext` as its `ToolTip`.

In .NET 5 (and 4.8), this all works as expected. In .NET 6 however, while the ToolTip works on a `ListBoxItem`, they close immediately on a `ComboBoxItem`.

You can change the target framework and observe the change in behavior. To ensure there's no confusion, the main window will set its title to the current framework.
