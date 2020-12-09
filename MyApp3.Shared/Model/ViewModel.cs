using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MyApp3.Model
{
  public class ViewModel : Observable
  {
    private Employee _selectedEmployee;

    public ViewModel()
    {
      Employees = new ObservableCollection<Employee>{
          new Employee{FirstName="Grillo",LastName="Huber",Nationality="German"},
          new Employee{FirstName="Anna",LastName="Rockstar",Nationality="Nigerian"},
          new Employee{FirstName="Julia",LastName="Mojave", Nationality="Canadian"},
        };
    }

    public Employee SelectedEmployee
    {
      get { return _selectedEmployee; }
      set
      {
        if (_selectedEmployee != value)
        {
          _selectedEmployee = value;
          NotifyPropertyChanged();
          NotifyPropertyChanged(nameof(IsEmployeeSelected));
        }
      }
    }

    public bool IsEmployeeSelected => SelectedEmployee != null;

    public ObservableCollection<Employee> Employees { get; }

    public void AddEmployee()
    {
      var employee = new Employee { FirstName = "New" };
      Employees.Add(employee);
      SelectedEmployee = employee;
    }

    public void DeleteEmployee()
    {
      var employee = SelectedEmployee;
      if (employee != null)
      {
        Employees.Remove(employee);
        SelectedEmployee = null;
      }
    }
  }
}
