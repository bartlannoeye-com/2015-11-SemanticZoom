using Windows.UI.Xaml;
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
            this.ZoomedInGridView.Loaded += ZoomedInGridView_Loaded;
        }

        private void ZoomedInGridView_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO: Only go to the correct state in reference to the windows size! For test we set it fixed...
            VisualStateManager.GoToState(this, "VisualStateMin320", false);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var collectionGroups = Collection.View.CollectionGroups;
            ((ListViewBase)this.SemanticZoom.ZoomedOutView).ItemsSource = collectionGroups;
        }
    }
}
