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
using MahApps.Metro.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:MetroWindow 
    {   //variables
        float Number1,Number2;
        string operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BNumber(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Clear();
            Button b = (Button)sender;
            txtResult.Text += b.Content.ToString();
        } 

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = " ";
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)  //Addition
        {
            operation = "+";  //Operator value stores
            Number1=float.Parse(txtResult.Text);
            txtResult.Clear(); //Clear the TextBox 
            txtResult.Focus(); // Focus on TextBox after clearing
            Label1.Content= Number1.ToString() + "+";  //Display the Text on Label
        }
    
        private void ButtonSubtract_Click(object sender, RoutedEventArgs e)  //Subtraction
        {
            operation = "-";  //Operator value stores
            Number1 = float.Parse(txtResult.Text);
            txtResult.Clear(); //Clear the TextBox
            txtResult.Focus(); // Focus on TextBox after clearing
            Label1.Content = Number1.ToString() + "-";  //Display the Text on Label
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)  //Multiplication
        {
            operation = "*";  //Operator value stores
            Number1 = float.Parse(txtResult.Text);
            txtResult.Clear();  //Clear the TextBox
            txtResult.Focus();  // Focus on TextBox after clearing
            Label1.Content = Number1.ToString() + "*";  //Display the Text on Label
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";  //Operator value stores
            Number1 = float.Parse(txtResult.Text);
            txtResult.Clear();  //Clear the TextBox
            txtResult.Focus();  // Focus on TextBox after clearing
            Label1.Content = Number1.ToString() + "/";  //Display the Text on Label
        }

        public void Calculate()
        {
            switch (operation)  
            {
                case "+":               
                    Number2 = Number1 + float.Parse(txtResult.Text);   //Performs Addition
                    txtResult.Text = Number2.ToString();               // Converts Float to String
                    break;
                case "-":
                    Number2 = Number1 - float.Parse(txtResult.Text);    //Performs Subtraction
                    txtResult.Text = Number2.ToString();               // Converts Float to String
                    break;
                case "*":
                    Number2 = Number1 * float.Parse(txtResult.Text);   //Performs Multiplication
                    txtResult.Text = Number2.ToString();               // Converts Float to String
                    break;
                case "/":
                    Number2 = Number1 / float.Parse(txtResult.Text);   //Performs Division
                    txtResult.Text = Number2.ToString();               // Converts Float to String
                    break;
            }
            
        }
        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            Calculate();   //To Perform all such opertaion
            Label1.Content = "";  //Clears the Label Text
        }

        
    }
}
