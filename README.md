##The MVC Programming Model


MVC is one of three ASP.NET programming models.


MVC is a framework for building web applications using a MVC (Model View Controller) design:


1. The Model represents the application core (for instance a list of database records).
2. The View displays the data (the database records).
3. The Controller handles the input (to the database records).


The MVC model also provides full control over HTML, CSS, and JavaScript.


The Model is the part of the application that handles the logic for the application data. Often model objects retrieve data (and store data) from a database.


The View is the parts of the application that handles the display of the data. Most often the views are created from the model data.


The Controller is the part of the application that handles user interaction. Typically controllers read data from a view, control user input, and send input data to the model.


The MVC separation helps you manage complex applications, because you can focus on one aspect a time. For example, you can focus on the view without depending on the business logic. It also makes it easier to test an application.


The MVC separation also simplifies group development. Different developers can work on the view, the controller logic, and the business logic in parallel.