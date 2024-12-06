using AvaloniaApplication2.Models;
using AvaloniaApplication2.Views;
using Kompozit.Mdb.Materials.Documents;
using ReactiveUI;
using System.Windows.Input;

namespace AvaloniaApplication2.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    private readonly IBusinessService _businessService;

    public ICommand? DoSomethingCommand { get; }

    public MainViewModel(IBusinessService businessService)
    {
        _businessService = businessService;

        DoSomethingCommand = ReactiveCommand.Create(DoSomething);
    }

    public void DoSomething()
    {
        _businessService.DoSomething();
    }
}
