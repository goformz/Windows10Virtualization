using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TestXamlVirt
{
    public sealed partial class TestPage : Page
    {
        public ExampleItemViewModel ViewModel = new ExampleItemViewModel();

        public TestPage()
        {
            this.InitializeComponent();
        }

        private void BackClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
