using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ArticlesDialogBox
    {
        private ListBox articlesListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogBox()
        {
            articlesListBox.addEventHandler(new ArticleSelected(articlesListBox, titleTextBox, saveButton));
            titleTextBox.addEventHandler(new TitleChanged(titleTextBox, saveButton));
        }

        public void simulateUserInteraction()
        {
            articlesListBox.Selection = "Article 1";
            //test
            //titleTextBox.Content= string.Empty;
            //titleTextBox.Content = "Article 2";
            Console.WriteLine("TextBox: "+ titleTextBox.Content);
            Console.WriteLine("Button: " + saveButton.IsEnabled);
        }
    }
}
