# WinForms-simple-project

This C# code is for a Windows Forms application. It defines a partial class called "Form1" which represents the main form of the application. 

The class has a constructor that initializes the form components using the InitializeComponent() method. It also declares a SqlConnection object named "sql" to establish a connection with a SQL Server database.

The Form1_Load event handler is empty and does not contain any code.

The connect_Click event handler is triggered when the "connect" button is clicked. It creates a new instance of the SqlConnection class and sets its ConnectionString property to the value specified in the configuration file. It then checks if the connection is closed and opens it if necessary. It also sets the XACT_ABORT option of the connection to ON. Finally, it displays the state of the connection in a MessageBox.

The textBox6_TextChanged, textBox1_TextChanged, textBox2_TextChanged, textBox3_TextChanged, textBox4_TextChanged, and textBox5_TextChanged event handlers are empty and do not contain any code.

The submit_Click event handler is triggered when the "submit" button is clicked. It retrieves the values entered in various textboxes (id, name, price, description, quantity, and location) and assigns them to corresponding variables. It then creates a new instance of the SqlCommand class with the name of the stored procedure "AddProduct" and the SqlConnection object. It sets the CommandType property of the command to StoredProcedure. It then adds parameters to the command object and assigns the values from the variables to the parameters. Finally, it executes the stored procedure using the ExecuteNonQuery method and displays a MessageBox indicating that the product has been added.

The Delete_Click event handler is triggered when the "Delete" button is clicked. It retrieves the values entered in the id and location textboxes and assigns them to corresponding variables. It then creates a new instance of the SqlCommand class with the name of the stored procedure "DeleteProduct" and the SqlConnection object. It sets the CommandType property of the command to StoredProcedure. It then adds parameters to the command object and assigns the values from the variables to the parameters. Finally, it executes the stored procedure using the ExecuteNonQuery method and displays a MessageBox indicating that the product has been deleted.

The button1_Click event handler is triggered when the "View Inventory" button is clicked. It retrieves the value entered in the id textbox and assigns it to a variable. It then creates a new instance of the SqlCommand class with the name of the stored procedure "ViewInventory" and the SqlConnection object. It sets the CommandType property of the command to StoredProcedure. It then adds a parameter to the command object and assigns the value from the variable to the parameter. It then executes the stored procedure using the ExecuteReader method and retrieves the data returned by the stored procedure. If there are rows returned, it loops through the rows and retrieves the values of each column using the reader object. It then displays the retrieved data in a MessageBox. If no rows are returned, it displays a MessageBox indicating that no data was found.

The Update_Click event handler is triggered when the "Update" button is clicked. It retrieves the values entered in the id, quantity, and location textboxes and assigns them to corresponding variables. It then creates a new instance of the SqlCommand class with the name of the stored procedure "UpdateInventory" and the SqlConnection object. It sets the CommandType property of the command to StoredProcedure. It then adds parameters to the command object and assigns the values from the variables to the parameters. Finally, it executes the stored procedure using the ExecuteNonQuery method and displays a MessageBox indicating that the inventory has been updated.