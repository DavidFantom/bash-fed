using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVC.DAL;
using MVC.Model;

namespace MVC.Controller
{
    public static class MainController
    {
        public static List<String> GetStatuses()
        {
            return LocalStorage.Statuses;
        }

        public static List<ToDoItem> GetItems()
        {
            return LocalStorage.Items;
        }

        public static void AddItem(ToDoItem item)
        {
            LocalStorage.Items.Add(item);
        }

        public static void DeleteItem(ToDoItem item)
        {
            LocalStorage.Items.Remove(item);
        }

    }
}
