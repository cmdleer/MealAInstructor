using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace MealAInstructor.ViewModels;

public class UserInputViewModel : ViewModelBase
{
    private string _ingredient = null!;
    private string _difficulty = null!;
    private string _addedIngredients = null!;
    private int _portions;

    public string Ingredient
    {
        get => _ingredient;
        set
        {
            if (value == _ingredient) return;
            _ingredient = value;
            OnPropertyChanged(nameof(_ingredient));
        }
    }

    public string Difficulty
    {
        get => _difficulty;
        set
        {
            if (value == _difficulty) return;
            _difficulty = value;
            OnPropertyChanged(nameof(_difficulty));
        }
    }

    public int Portions
    {
        get => _portions;
        set
        {
            if (value == _portions) return;
            _portions = value;
            OnPropertyChanged(nameof(_portions));
        }
    }

    public string AddedIngredients
    {
        get => _addedIngredients;
        set
        {
            if (value == _addedIngredients) return;
            _addedIngredients = value;
            OnPropertyChanged(nameof(_addedIngredients));
        }
    }
    
    public ICommand EnterCommand { get; set; }

    public UserInputViewModel()
    {
        EnterCommand = new RelayCommand(OnEnter);
    }

    private void OnEnter()
    {
        
    }
}