using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace MealAInstructor.ViewModels;

public class UserInputViewModel : ViewModelBase
{
    public string Ingredient { get; set; }
    public string Difficulty { get; set; }
    public string AddedIngredients { get; set; }
    public int Portions { get; set; }
    
    public ICommand EnterCommand { get; set; }

    public UserInputViewModel()
    {
        EnterCommand = new RelayCommand(OnEnter);
    }

    private void OnEnter()
    {
    }
}