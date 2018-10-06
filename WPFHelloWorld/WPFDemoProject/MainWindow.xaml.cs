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

namespace WPFDemoProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> students = new List<Student>(); //This creates a list of students. Records are added to teh list in the MainWindow method below. 

        public MainWindow()
        {
            InitializeComponent();

            students.Add(new Student { FirstName = "Ian", LastName = "Lee" }); //These students are in the list of students 
            students.Add(new Student { FirstName = "John", LastName = "Smit" });
            students.Add(new Student { FirstName = "Sally", LastName = "Jones" });
            students.Add(new Student { FirstName = "Debbie", LastName = "Long" });

            cboStudentNames.ItemsSource = students; //As it was called in the xaml file. So basically, it places the student list into the combobox. It will only show the student records though and not the names yet. 
        }

        private void btnClickHere_Click(object sender, RoutedEventArgs e)
        {
            string firstName = tbxFirstName.Text.Trim();
            MessageBox.Show($"Your first name is " + firstName);
        }

        public class Student //The class student is the object. Parameters within the class are the parts of the class. like first name and last name.  
        {
            public string FirstName { get; set; } //FirstName is not a variable. It is a parameter. Public parameters uses Pascal case. Private parameters use Camel case. 
            public string LastName { get; set; }

            public string FullName //This will enable one to pull the firstName and lastName whenever it is called. 
            {
                get
                {
                    return $"{FirstName} { LastName }";
                }

            } 


        }
    }
}
