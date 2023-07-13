# Launch Mod 3 Week 2 Assessment

## Questions (10 Points)

1. Define MVC and explain the purpose of each of the three parts of this pattern.
-- MVC is a design strategy. It involves each part (the Model, View, and Controller) having a different purpose. The View is what the user sees. The Model is all of the data logic and represents objects in the database. The Controller is the conductor between the model and the view. The Controller is responsible for building the response that gets sent to the client.

2. Explain the difference between the **New** route and the **Create** route.
-- The New route and the Create route have the same CRUD function (create) but utilize different HTTP methods and return types. The New is a GET request with a return type of View. Create is a POST HTTP method with a return type of redirect.

3. List all of the RESTful routes for the `employee` entity. Make sure to include the Route Name, Path, and HTTP Method for each of the routes. (2 points)
- Index, /employees, GET
- New, /employees/new, GET
- Create, /employees, POST
- Show, /employees/:id, GET
- Edit, /employees/:id/edit, GET
- Update, /employees/:id, PUT
- Destroy, /employees/:id, DELETE

</br>
For the following three questions, explain both how to fix the error/bug and why the part of the code that was broken is important. (2 points each)

4. This error occured because we did not pass the Hotels data from the controller into the View. In the HotelController, we need to update Line 20 from return View() to return View(hotels) so this data can be access by our Hotels View.
<img width="1213" alt="Screenshot 2023-06-13 102204" src="https://github.com/turingschool/launch-curriculum/assets/11747682/f37c233d-e7aa-483e-9f75-7c9b111811e5">

5. The error occured because the route requested, Index, does not exist as a View in the program. There is a View called 'Indexes'. The route and the view must match exactly in order for the View to be displayed. We will need to change "Indexes" to "Index".
<img width="1245" alt="Screenshot 2023-06-13 102555" src="https://github.com/turingschool/launch-curriculum/assets/11747682/87c9fbf7-de63-4580-9b36-8632df27b91b">

6. Thr razor syntax is missing for our Index file. We need the razor syntax to insert C# code into our HTML file in order to display the info for each hotel in our database. This would involve making the following edits: "@hotel.Name" and "@hotel.Location".
<img width="1238" alt="Screenshot 2023-06-13 102856" src="https://github.com/turingschool/launch-curriculum/assets/11747682/a39b525d-ae05-463f-b724-be68aa70148c">

## Exercise (10 Points)

Make sure to first run `update-database` to populate the `Tourism` database used by this application.

This application already has the `Index` route for States.

Your task is to do the following:
1. Add the `Show` RESTful route to display the name and abbreviation for a particular state.
1. Add a test for your new `Show` route in the `StateCRUDTests.cs` file.
