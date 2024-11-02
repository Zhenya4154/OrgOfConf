using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConfApp.Classes
{
    class Manager
    {
        public static Frame MainFrame { get; set; }

        public static void GetImageDate()
        {
            var list = Data.User1212Entities.GetContext().Event.ToList();
            foreach (var item in list)
            {
                string path = Directory.GetCurrentDirectory() + @"\img\" + item.id.ToString() + ".jpg";
                if (File.Exists(path))
                {
                    item.EventImage = File.ReadAllBytes(path);
                }
            }
            Data.User1212Entities.GetContext().SaveChanges();
        }
    }
}
