**Last Read at 16.7.2024**

<h3>What is Repository Pattern and Why Should We Use It?</h3>
<p></p>


<h3></h3>
<p>With the Repository Pattern, we create an abstraction layer between the data access and the business logic layer of an application. By using it, we are promoting a more loosely coupled approach to access our data frorm the database. Also, the code is cleaner and easier to maintain and reuse. Data access logic is in a separate class, or sets of classes called a repository, with the responsibility of persisting the application's business model.</p>

<h3></h3>
<p></p>

<h3></h3>
<p></p>

<h3></h3>
<p></p>

<h3></h3>
<p></p>

<h3></h3>
<p></p>

<h3></h3>
<p></p>

# To Run

```

//Go to project folder and run the following commands
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet ef migrations list

```