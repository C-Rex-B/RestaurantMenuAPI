RestaurantMenuAPI

Project Description

This is a ASP.NET Core RESTful API service project, named `RestaurantMenuAPI`, provides functionality related to managing and retrieving Dish information for a restaurant menu. It utilizes MongoDB as its database for storing and retrieving Dish data.

Features

Dish Management: Add, update, and retrieve dishes and delete menus and dishes.

Endpoints: The API provides several endpoints for different operations.

Project Structure

The primary class in this project is the `Dish` class, defined as follows:

Dish Class

The `Dish` class represents a menu item and includes various properties defining its attributes:
- `Id`: Unique identifier for the Dish (MongoDB ObjectId).
- `MenuName`: Name of the menu to which the Dish belongs.
- `DishName`: Name of the Dish.
- `Description`: Description or details of the Dish.
- `Price`: Price of the Dish.
- `Category`: Category to which the Dish belongs (e.g., main course, starter, etc.).
- `Ingredients`: Ingredients used in the Dish.
- `Allergens`: Information about any allergens present in the Dish.
- `PreparationTime`: Time required to prepare the Dish.
- `Availability`: Dictionary representing the availability of the Dish based on days and time slots.
- `DeactivationStatus`: Status indicating whether the Dish is deactivated or active.
- `Calories`: Caloric value of the Dish.
- `SpicinessLevel`: Level of spiciness in the Dish.
- `PortionSize`: Size of the Dish portion.
- `ImageUrl`: URL pointing to an image of the Dish.
- `DishRating`: Rating of the Dish.
- `CreatedDate`: Date and time when the Dish was created.
- `Origin`: Origin or cuisine type of the Dish.


Usage

This API supports various endpoints allowing CRUD (Create, Read, Update, Delete) operations for Dish entities. It utilizes MongoDB as the database for storing and retrieving Dish data.

How to Test?

1. Clone the repository to your local machine.	
2. Ensure you have MongoDB instance running locally or on a server accessible to the API.
3. Open the project in Visual Studio.
4. Run the project.
5. Use tools like Postman or Swagger UI to test the different endpoints provided by the API for Dish management.


API Endpoints

- `GET /Dish`: Retrieve all Dishes.
- `GET /Dish/{id}`: Retrieve a Dish by its ID.
- `POST /Dish`: Create a new Dish.
- `PUT /Dish/{id}`: Update an existing Dish.
- `DELETE /Dish/{id}`: Delete a Dish by its ID.

Setup Instructions

1. Clone the Repository:

	git clone <repository-url>


2. Install Dependencies:

	dotnet restore


3. Run the Application:

	dotnet run

	
Environment Variables

1. Create a configuration file named appsettings.json in the RestaurantMenuAPI directory.

  - `MONGO_CONNECTION_S{
  "DishStoreDatabaseSettings": {
    "ConnectionString": "<YOUR_MONGODB_CONNECTION_STRING>",
    "DatabaseName": "MongoDotNetRestaurantMenuDish",
    "DishsCollectionName": "DishCollection"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}TRING`

Note: Replace <YOUR_MONGODB_CONNECTION_STRING> with your actual MongoDB connection string.


2. Name of the MongoDB database

- `DATABASE_NAME` 

Requirements

- .NET Core SDK
- MongoDB

Feel free to contribute to the project or report any issues.

For detailed usage instructions and examples, refer to the project's documentation.

