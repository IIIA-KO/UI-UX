using System.Windows;

namespace TextEditor
{
    public partial class IndentDialog : Window
    {
        public int Indent { get; private set; }

        public IndentDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(IndentTextBox.Text, out int indent))
            {
                Indent = indent;
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
