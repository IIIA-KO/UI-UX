using System;
using System.Windows;

namespace TextEditor
{
    public partial class NewTab : Window
    {
        public NewTab()
        {
            InitializeComponent();
        }

        public string? FileName { get; set; }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (FileNameTextBox.Text != null && !string.IsNullOrWhiteSpace(FileNameTextBox.Text))
                    FileName = FileNameTextBox.Text;
                else throw new NullReferenceException();

                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
