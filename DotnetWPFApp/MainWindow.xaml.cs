using System;
using System.Collections.Generic;
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

namespace DotnetWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> Employees { get; set; }
        public MainWindow()
        {
            //Employees = new List<string>();
            //Employees.Add("Gregg");
            //Employees.Add("Doris");
            //Employees.Add("Tudou");
            //Employees.Add("Tudou");

            var db = new DatabaseContext();
            //db.Database.EnsureCreated(); after first execution, data will stay
            //if(db.Employees?.Count()==0) //null conditional
            //{
            //    db.Employees.Add(new Employee() { Name = "Gregg", Age = 28 });
            //    db.Employees.Add(new Employee() { Name = "Doris", Age = 28 });
            //    db.Employees.Add(new Employee() { Name = "Tudou", Age = 4 });
            //    db.SaveChanges();
            //}
            Employees = db.Employees.ToList();
            this.DataContext = this;
            InitializeComponent();
        }
    }
}
