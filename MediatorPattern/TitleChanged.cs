namespace MediatorPattern
{
    class TitleChanged : EventHandler
    {
        private TextBox titleTextBox;
        private Button saveButton;

        public TitleChanged(TextBox titleTextBox, Button saveButton)
        {
            this.titleTextBox = titleTextBox;
            this.saveButton = saveButton;
        }

        public void handle()
        {
            var content = titleTextBox.Content;
            saveButton.IsEnabled = !string.IsNullOrEmpty(content);
        }
    }
}
