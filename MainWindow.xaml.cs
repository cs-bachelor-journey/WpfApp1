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
        }
        // ── Public properties ────────────────────────────────────────────────────

        /// <summary>Nom saisi par l'utilisateur.</summary>
        public string NomUtilisateur { get; private set; } = string.Empty;

        /// <summary>Fonction sélectionnée par l'utilisateur.</summary>
        public string FonctionUtilisateur { get; private set; } = string.Empty;

        // ── Constructor ──────────────────────────────────────────────────────────
        public MainWindow()
        {
            InitializeComponent();
            CmbFonction.SelectedIndex = 0;
        }
        


       
        // ── Event handlers ───────────────────────────────────────────────────────

        private void BtnBienvenue_Click(object sender, RoutedEventArgs e)
        {
            string nom = TxtNom.Text.Trim();
            string fonction = (CmbFonction.SelectedItem as ComboBoxItem)?.Content?.ToString()
                              ?? string.Empty;

            if (string.IsNullOrEmpty(nom))
            {
                TxtStatus.Text = "Veuillez entrer votre nom.";
                TxtNom.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fonction))
            {
                TxtStatus.Text = "Veuillez choisir une fonction.";
                CmbFonction.Focus();
                return;
            }

            NomUtilisateur = nom;
            FonctionUtilisateur = fonction;
            TxtStatus.Text = $"Bienvenue, {nom} !";

            DialogResult = true;
            Close();
        }
    }
}