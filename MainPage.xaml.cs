namespace MAUIElementCreationTask
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // The following code checks if the button has been created successfully:
            Button closeButton = this.FindByName<Button>("CloseBtn");

            if (closeButton == null)
                throw new Exception("Close button is not found");

            if (closeButton.Text != "Close")
                throw new Exception("The 'Text' property of the CloseBtn is not set to 'Close'.");

            if (closeButton.HorizontalOptions != LayoutOptions.Fill)
                throw new Exception("The 'HorizontalOptions' property of the CloseBtn is not set to 'Fill'.");
        }
    }
}
