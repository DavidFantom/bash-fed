using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Model;

namespace MVC.DAL
{
    public static class LocalStorage
    { 
        public static List<ToDoItem> Items { get; set; }
        public static List<String> Statuses { get; set; }

        static LocalStorage()
        {
            Items = new List<ToDoItem>();
            Statuses = new List<String>
            {
                "Новое","В работе","Завершена","Отменена"
            };
            
            Items.Add(new ToDoItem
                {

                    Name = "Test",
                    Description = "Test",
                    Status = Statuses[0],
                    
                });
        }
    }
}
