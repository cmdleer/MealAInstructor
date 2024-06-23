namespace MealAInstructor.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        var responseViewModel = new ResponseViewModel();
        var userInputViewModel = new UserInputViewModel();
    }
}