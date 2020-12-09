using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using System;
using MyApp3.Model;

namespace MyApp3.Controls
{
    [ContentProperty(Name = nameof(Employee))]
    public sealed partial class EmployeeDetailControl : UserControl
    {
        public static readonly DependencyProperty EmployeeProperty = DependencyProperty.Register("Employee", typeof(Employee),
            typeof(EmployeeDetailControl), new PropertyMetadata(null));

        public EmployeeDetailControl()
        {
            this.InitializeComponent();
        }

        public Employee Employee
        {
            get { return (Employee)GetValue(EmployeeProperty); }
            set { SetValue(EmployeeProperty, value); }
        }
    }
}
