using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SemanticZoom
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

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var collectionGroups = Collection.View.CollectionGroups;
            ((ListViewBase)this.SemanticZoom.ZoomedOutView).ItemsSource = collectionGroups;
        }
    }
}
