using System.Collections.ObjectModel;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Ursa.Demo.ViewModels;

public class PaginationDemoViewModel: ObservableObject
{
    public AvaloniaList<int> PageSizes { get; set; } = new() { 10, 20, 50, 100 };
}