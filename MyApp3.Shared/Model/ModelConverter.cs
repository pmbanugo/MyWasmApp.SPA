namespace MyApp3.Model
{
  public static class ModelConverter
  {
    public static Employee CreateEmployeeFromString(string inputString)
    {
      var values = inputString.Split(',');
      return new Employee
      {
        FirstName = values[0],
        LastName = values[1],
        Nationality = values[2]
      };
    }
  }
}
