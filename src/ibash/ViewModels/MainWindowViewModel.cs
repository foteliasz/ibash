
using System.Linq;
using Avalonia.Media;

namespace ibash.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Debug { get; private set; }
    
    public string Command => "Welcome to Avalonia!";

    public MainWindowViewModel()
    {
    }
}
