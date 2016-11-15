using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFGoogleMapSample
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Voladora",
                IconSource = "contacts.png",
                TargetType = typeof(Voladora)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Carritos",
                IconSource = "todo.png",
                TargetType = typeof(Carritos)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "todos",
                IconSource = "reminders.png",
                TargetType = typeof(TodosJunto)
            });

            listView.ItemsSource = masterPageItems;
        }







    }
}

/* working copy
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFGoogleMapSample
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(ContactsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "todo.png",
                TargetType = typeof(TodoListPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "reminders.png",
                TargetType = typeof(ReminderPage)
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
working copy */