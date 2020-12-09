using Windows.Foundation.Metadata;

namespace MyApp3.Model
{
    [CreateFromString(
      MethodName = "MyApp3.Model.ModelConverter.CreateEmployeeFromString")]
    public class Employee : Observable
    {
        private string _firstName;
        private string _lastName;
        private string _nationality;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                NotifyPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                NotifyPropertyChanged();
            }
        }

        public string Nationality
        {
            get => _nationality;
            set
            {
                _nationality = value;
                NotifyPropertyChanged();
            }
        }
    }
}
