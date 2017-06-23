using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestXamlVirt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ShowManyPageWithFewControls(object sender, RoutedEventArgs e)
        {
            // 100,000 X 10
            ExampleItemViewModel.Pages = 100000;
            ExampleItemViewModel.Controls = 10;
            
            // Navigate to the test page
            this.Frame.Navigate(typeof(TestPage));
        }

        private void ShowFewPagesWithManyControls(object sender, RoutedEventArgs e)
        {
            // 50 X 300
            ExampleItemViewModel.Pages = 20;
            ExampleItemViewModel.Controls = 500;

            // Navigate to the test page
            this.Frame.Navigate(typeof(TestPage));
        }
    }
}