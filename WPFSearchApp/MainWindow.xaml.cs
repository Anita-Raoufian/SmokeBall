using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using WpfSearchApp.GoogleImplementation;

namespace WpfSearchApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        private readonly SearchClient _searchEngine;
        private string _searchResult;
        public string SearchResult
        {
            get => _searchResult;
            set
            {
                _searchResult = value;
                OnPropertyChanged("SearchResult");
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            _searchEngine = new SearchClient(new GoogleFactory());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        
        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            SearchResult = "";

            DisableControls();  

            var resultText = string.Empty;
            var keywordsList = KeywordTextBox.Text.Split(',');

            resultText = keywordsList.Select(keyword => _searchEngine.SearchKeyword(keyword, 100))
                .Select(result => result.Select((x, i) => new {i, x})
                    .Where(x => x.ToString().Contains("www.smokeball.com.au"))
                    .Select(x => x.i + 1)
                    .FirstOrDefault())
                .Aggregate(resultText, (current, index) => current + (index + ","));

            resultText = resultText.Remove(resultText.Length - 1);
            SearchResult = "The search phrase index(es): " + resultText;

            EnableControls();
        }

        private void DisableControls()
        {
            SearchButton.IsEnabled = false;
            KeywordTextBox.IsEnabled = false;
        }

        private void EnableControls()
        {
            SearchButton.IsEnabled = true;
            KeywordTextBox.IsEnabled = true;
        }
    }
}
