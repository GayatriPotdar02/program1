CREATE TABLE Employee
(
   EmployeeId INT PRIMARY KEY,
   FirstName NVARCHAR(50),
   LastName NVARCHAR(50),
   Age INT,
   Salary DECIMAL(18, 2)
);



//create
sqlCommand.CommandText = "INSERT INTO Employee VALUES (@EmployeeId, @FirstName, @LastName, @Age, @Salary)";
sqlCommand.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
sqlCommand.Parameters.AddWithValue("@FirstName", employee.FirstName);
sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
sqlCommand.Parameters.AddWithValue("@Age", employee.Age);
sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
sqlCommand.ExecuteNonQuery();



// Read
sqlCommand.CommandText = "SELECT * FROM Employee";
SqlDataReader reader = sqlCommand.ExecuteReader();
while (reader.Read())
{
    // Display data or add to DataGridView
}
reader.Close();


// Update
sqlCommand.CommandText = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Salary = @Salary WHERE EmployeeId = @EmployeeId";
sqlCommand.Parameters.AddWithValue("@FirstName", updatedEmployee.FirstName);
sqlCommand.Parameters.AddWithValue("@LastName", updatedEmployee.LastName);
sqlCommand.Parameters.AddWithValue("@Age", updatedEmployee.Age);
sqlCommand.Parameters.AddWithValue("@Salary", updatedEmployee.Salary);
sqlCommand.ExecuteNonQuery();

// Delete
sqlCommand.CommandText = "DELETE FROM Employee WHERE EmployeeId = @EmployeeId";
sqlCommand.Parameters.AddWithValue("@EmployeeId", employeeIdToDelete);
sqlCommand.ExecuteNonQuery();
