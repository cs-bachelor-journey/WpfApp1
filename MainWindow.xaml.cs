using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        // ── Public properties ────────────────────────────────────────────────────

        

        // ── Constructor ──────────────────────────────────────────────────────────
        public MainWindow()
        {
            InitializeComponent();
        }
        


       
        // ── Event handlers ───────────────────────────────────────────────────────

        private void WelcomeAction(object sender, RoutedEventArgs e)
        {
            // validation 
            if (!string.IsNullOrEmpty(personName.Text) && personJob.SelectedValue != null)
            {
                string personNameValue = personName.Text;

                ComboBoxItem comboBoxItem = (ComboBoxItem)personJob.SelectedValue;
                string personJobValue = comboBoxItem.Content.ToString();

                string generatedSentence = $"Bienvenue {personNameValue} ({personJobValue})";

                welcomeWords.Text = generatedSentence;
            }else
            {
                MessageBox.Show("Veuillex remplir tous les champs !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}