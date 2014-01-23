#CookForMe


CookForMe is a simple desktop application that serves as a nutrition monitoring and food preparation assistant.


##Description  


This application is used for creation and monitoring of the nutrition plan. By using this application, a user can receive and define his own customized daily menus, and also find food under defined parameters and create his own recipes. There is also an option of adding pictures of ingredients and recipes and an option to lookup the calorie value of foods. 

There is also an option of creation and maintaining of the ingredients catalogue where ingredients are categorized by food type (eg. fruit, fish, dairy, sweets...). While adding an ingredient to the catalogue, a user must define its food type and nutrition value (energy, protein and fat amount). In order to find out how many calories are in some amount of food, a user can use the calorie calculator.  

The user is given an option of creating recipes. Each recipe must have a list of ingredients with their amounts and the method of preparation. A recipe can also contain pictures showing method of preparation or the prepared dish. recipes are categorized by meals for which they are prepared. A new meal can be defined only by adding a new recipe for this meal. In order to enable storing of several recipes for one dish, the user can create any number of recipes with the same name. For example, there are many ways to prepare a Black Forest cake and there should be more than one recipe for this cake. 

One of the main features of this application is the generation of daily menus by using the user selected criteria. Each daily menu contains recipes for each meal of the day. Daily menus can be categorized, for example, there can be a Christmas or a Birthday menu.   
In order for application to generate a daily menu, the user must select the desired meals, ingredients for each of these meals and the number of recipes per meal. The user has the option to save the generated menu with an optional description.  
The user can also create his own daily menu. When defining a menu, the user must select meals and add recipes for every selected meal.  

There is also a search engine where user can select the desired category (ingredient, recipe or daily menu) and enter keywords of interest and therefore find recipes, menus and foods faster.


##Application design


CookForMe is a desktop application written in C# using Windows Forms framework in MS Visual Studio IDE. Application was implemented using MVP (Model View Presenter) design pattern and unit-tested using NUnit.  


##Usage


In order to start the application, file CooKForMeApp.exe (located in folder CookForMe\CooKForMeApp\bin\Debug) must be executed. 


###Examples


Application's main menu is shown in the following image:

![Main menu](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/MainMenu.png)

The user can choose to add or view additional information about an ingredient, recipe or daily menu. There's also a search button and a option of generating daily menu shown when daily menus are selected.  
For example, user might want to find more information about a certain ingredient, such as Strawberry, so he selects "Ingredients" tab, option "View Ingredients" and chooses "Strawberry" under category "Fruit":

![View ingredients](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/ViewIngredients.png)

To read about strawberry in detail, the user must select the "Ingredient details" button, which opens a new dialog that contains the desired information:

![Ingredient details](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/IngredientDetails.png)

By clicking on the button "Calorie calculator", simple calorie calculator is displayed:

![Calorie calculator](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/CalorieCalculator.png)

The following snapshot displays the daily menu generated based on the desired criteria: breakfast with blueberry and butter and dinner with chicken. The area for criteria input is cleared after daily menu has been generated:

![Generate daily menu](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/GenerateDailyMenu.png)

The example of search engine shows that, although some of the search parameters were misspelled ("Cereal prdcts"), the result included ingredients and recipes from the category "Cereal products" (ingredients "Cornstarch" and "Rice"):

![Search parameters](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/SearchParameters.png)  


![Search results](https://raw2.github.com/lzadrija/CookForMe/master/ApplicationSnapshots/SearchResults.png)




