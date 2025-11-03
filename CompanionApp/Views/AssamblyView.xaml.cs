using System.Threading.Tasks;
using System.Windows.Controls;

namespace CompanionApp.Views
{
    /// <summary>
    /// Interaction logic for AssamblyView
    /// </summary>
    public partial class AssamblyView : UserControl
    {
        public AssamblyView()
        {
            InitializeComponent();
        }

        private void WebView2_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            LoadingBorder.Visibility = System.Windows.Visibility.Visible;
        }

        private async void WebView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            await Task.Delay(3000);
            //LoadingBorder.Visibility = Visibility.Collapsed;
        }
    }
}
