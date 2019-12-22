using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Mobile.Models
{
    public enum MenuItemType
    {
        Profil,
        Obavijesti,
        Pravdanja,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
