#CookForMe


CookForMe is a simple desktop application that serves as a nutrition monitoring and food preparation assistant.


##Description  


This application is used for creation and monitoring of the nutrition plan. By using this application, a user can define his own customized daily menus, lookup existing ones, and also find foods under defined parameters and create his own recipes. There is also an option for adding pictures of ingredients and recipes and an option to lookup the calorie value of foods. 

By using the ingredients catalogue, a user can add new ingredients and browse through the existing ones that are categorized by food type (eg. fruit, fish, dairy, sweets...). While adding an ingredient to the catalogue, a user must define its food type and nutrition value (energy, protein and fat amount). In order to find out how many calories are there in some amount of food, a user can use the calorie calculator.  

Users can also create custom recipes. Each recipe contains a list of ingredients and their amounts and the method of preparation. A recipe can also contain pictures showing method of preparation or the prepared dish. Recipes are categorized by meals. A new meal can be defined only by adding a new recipe for this meal. Users can create any number of recipes with the same name. For example, there are many ways to prepare a Black Forest cake and there should be more than one recipe for this cake. 

One of the main features of this application is the generation of daily menus by using the user defined criteria. Each daily menu contains recipes for each meal of the day. Daily menus can be categorized, for example, there can be a Christmas or a Birthday menu.   
In order for application to generate a daily menu, the user must select the desired meals, ingredients for each selected meal and the number of recipes per meal. Users can add an optional description to the generated menu.  
There is also an option for creating custom daily menus. When defining a menu, a user selects any number of meals and adds recipes for every selected meal.  

Browsing a large amount of foods, recipes or menus can be a tedious job. Users are offered a search engine option, where they can select desired categories (ingredients, recipes or daily menus) and enter keywords of interest and therefore find recipes, menus and foods faster.


##Application design


CookForMe is a desktop application written in C# using Windows Forms framework in MS Visual Studio IDE. Application was implemented using MVP (Model View Presenter) design pattern and unit-tested using NUnit.  


##Usage


In order to start the application, file CooKForMeApp.exe (located in folder CookForMe\CooKForMeApp\bin\Debug) must be executed. 


###Examples


Application's main menu is shown in the following image:

![Main menu](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/MainMenu.png)

The user can choose to add or view additional information about an ingredient, a recipe or a daily menu. There's also a search button and an option of generating a daily menu shown when daily menus are selected.  
For example, if a user wants to find more information about a certain ingredient, such as strawberry, he can select "Ingredients" tab, option "View Ingredients" and choose "Strawberry" under category "Fruit":

![View ingredients](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/ViewIngredients.png)

To read about strawberry in detail, the user must select the "Ingredient details" button, which opens a new dialog that contains the desired information:

![Ingredient details](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/IngredientDetails.png)

By clicking on the button "Calorie calculator", simple calorie calculator is displayed:

![Calorie calculator](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/CalorieCalculator.png)

The following snapshot displays a daily menu generated based on the desired criteria: breakfast with blueberry and butter and dinner with chicken. The area for the criteria input is cleared after the generation of the daily menu:

![Generate daily menu](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/GenerateDailyMenu.png)

The search engine example shows that despite of the fact that the search parameters were misspelled ("Cereal prdcts"), the search result included ingredients and recipes from the category "Cereal products" (ingredients "Cornstarch" and "Rice"):

![Search parameters](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/SearchParameters.png)  


![Search results](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/SearchResults.png)




