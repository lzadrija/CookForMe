using System;
using System.Collections.Generic;
using System.Linq;

using CookForMeUtil;

namespace CookForMe.Model.Repositories
{
    public class MenuRepository : Subject
    {

        private readonly List<DailyMenu> _listDailyMenu;
        private static MenuRepository _instance;




        public MenuRepository()
        {
            _listDailyMenu = new List<DailyMenu>();
        }




        public static MenuRepository GetInstance()
        {
            return _instance ?? (_instance = new MenuRepository());
        }


        public void AddNewDailyMenu(String name, String description, 
                                    Dictionary<String, List<String>> menusForRecipesMap)
        {
            if (IsMenuDefined(name))
            {
                throw new ItemAlreadyExistsException();
            }

            var dailyMenu = new DailyMenu(name, description, menusForRecipesMap);

            _listDailyMenu.Add(dailyMenu);

            Notify();
        }



        public void UpdateDailyMenu(String menuName, String description, 
                                    Dictionary<String, List<String>> mealsForRecipesMap)
        {
            var menu = GetMenuByName(menuName);

            if (null == menu)
            {
                throw new ItemNotFoundException();
            }

            menu.Description = description;
            menu.MealsForRecipesMap = mealsForRecipesMap;

            Notify();
        }



        public void DeleteDailyMenu(String menuName)
        {
            var menu = GetMenuByName(menuName);

            if (null == menu)
            {
                throw new ItemNotFoundException();
            }

            _listDailyMenu.Remove(menu);

            Notify();
        }




        public List<string> GetMatchingDailyMenus(Dictionary<string, string> recipesData, List<string> searchParameters)
        {
            var matchedMenus = (from menu in _listDailyMenu let isMenuRecipeMatched = 
                                    menu.ContainsRecipes(recipesData.Keys.ToList()) where isMenuRecipeMatched select menu.Name).ToList();

            foreach (var menu in from searchParameter in searchParameters from menu in _listDailyMenu 
                                 where menu.IsDataPartOfName(searchParameter) && !matchedMenus.Contains(menu.Name) select menu)
            {
                matchedMenus.Add(menu.Name);
            }

            return matchedMenus;
        }




        public DailyMenu GetMenuByName(String menuName)
        {
            return _listDailyMenu.FirstOrDefault(menu => String.Compare(menu.Name, menuName, StringComparison.Ordinal) == 0);
        }

        public List<String> GetDailyMenuNames()
        {
            return _listDailyMenu.Select(menu => menu.Name).ToList();
        }


        public bool IsMenuDefined(String name)
        {
            return _listDailyMenu.Any(menu => String.Compare(menu.Name, name, StringComparison.Ordinal) == 0);
        }
    }
}
