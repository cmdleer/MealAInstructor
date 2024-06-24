namespace MealAInstructor.ViewModels;

public class UserInputViewModel : ViewModelBase
{
    private string _ingredient;
    private string _difficulty;
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
}