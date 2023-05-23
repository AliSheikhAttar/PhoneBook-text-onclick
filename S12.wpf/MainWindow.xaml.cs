using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace S12.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // public string FirstName {get; set;} = "Hossein";
        // public int selectedIndex {get; set;}

        // public ObservableCollection<Student> Students {get; set;} = 
        //      new ObservableCollection<Student>();
        // private int _Age = 25;

        // public string Age {
        //     get => _Age.ToString();
        //     set => _Age = int.Parse(value);
        // }
        public int Selected_Index{get;set;}
        public string fname{get; set;}
        public string fname_tofind{get; set;}
        public string lname_tofind{get; set;}
        public string lname{get; set;}
        public string number{get;set;}
        public string email{get;set;}
        public string state{get;set;}
        public string town{get;set;}
        public string street{get;set;}
        public ObservableCollection<Person> Contacts{get;set;} = new ObservableCollection<Person>();
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            this.dgContacts.DataContext = this.Contacts;
        }
        private void Add_onClick(object? sender, RoutedEventArgs args)
        {
            var n_Name = new Name(this.fname,this.lname);
            var n_Address = new Address(this.state,this.town,this.street);
            var n = new Person(n_Name,this.number,this.email,n_Address);
            Contacts.Add(n);
        }
        private void Delete_onClick(object? sender, RoutedEventArgs args)
        {
            Contacts.RemoveAt(Selected_Index);
        }
        private void Find_onClick(object? sender, RoutedEventArgs args)
        {
            int index = -1;
            foreach(var person in Contacts)
            {
                if(((person.Person_Name.FirstName == fname_tofind) && ((string.IsNullOrEmpty(lname_tofind)) || (person.Person_Name.LastName == lname_tofind))) || 
                ((person.Person_Name.LastName == lname_tofind) && ((string.IsNullOrEmpty(fname_tofind)) || (person.Person_Name.FirstName == fname_tofind))))
                {
                    index = Contacts.IndexOf(person)+1;
                    MessageBox.Show($"A Person with this name is the {index}th Person in the List");
                    index = 0;
                }
            }
            if(index == -1)
                MessageBox.Show("This Person does not exist in the List");
        }
    }
}
