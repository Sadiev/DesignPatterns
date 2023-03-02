namespace MediatorPattern
{
    class ArticleSelected : EventHandler
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticleSelected(ListBox articlesListBox, TextBox titleTextBox, Button saveButton)
        {
            this.articlesListBox = articlesListBox;
            this.titleTextBox = titleTextBox;
            this.saveButton = saveButton;
        }

        public void handle()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }
    }
}
