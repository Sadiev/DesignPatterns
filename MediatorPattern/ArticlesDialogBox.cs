using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            this.articlesListBox = new ListBox(this);
            this.titleTextBox = new TextBox(this);
            this.saveButton = new Button(this);
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

        public override void changed(UIControl control)
        {
            if (control==articlesListBox)
            {
                articleSelected();
            }
            else if (control==titleTextBox)
            {
                titleChanged();
            }
        }

        private void titleChanged()
        {
            var content = titleTextBox.Content;
            saveButton.IsEnabled = !string.IsNullOrEmpty(content);
        }

        private void articleSelected()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled= true;
        }
    }
}
