namespace Maui_IOT1
{
    [QueryProperty(nameof(QrCodeResult), "Thiết bị phát hiện ")]
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        public string QrCodeResult
        {
            set
            {
                CounterBtn.Text=$"Scanner result :{value}";
            }
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private async void ScanButtonClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ScanPage));
        }
    }

}
