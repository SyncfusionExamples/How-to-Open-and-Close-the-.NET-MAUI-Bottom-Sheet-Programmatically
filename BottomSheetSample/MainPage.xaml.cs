namespace BottomSheetSample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object? sender, ItemTappedEventArgs e)
        {
            bottomSheet.BottomSheetContent.BindingContext = e.Item;
            bottomSheet.IsOpen = true;
        }

        private void CloseBottomSheet(object sender, EventArgs e)
        {
            bottomSheet.IsOpen = false;
        }
    }

}
