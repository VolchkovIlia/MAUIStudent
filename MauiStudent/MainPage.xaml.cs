
namespace MauiStudent;


public partial class MainPage : ContentPage
{
    private Repository repository = new Repository();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        string firstName = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;
        int age = int.Parse(ageEntry.Text);

        Student student = new Student(firstName, lastName, age);
        repository.AddStudent(student);

        DisplayAlert("Успешно", "Студент успешно добавлен в коллекцию", "OK");

        // Очистка полей ввода
        firstNameEntry.Text = "";
        lastNameEntry.Text = "";
        ageEntry.Text = "";
    }
}

