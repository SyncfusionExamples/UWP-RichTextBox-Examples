using Syncfusion.UI.Xaml.RichTextBoxAdv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Custom_Suggestion_Provider
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ISuggestionProvider suggestionProvider01 = new NameSuggestionProvider();
            suggestionProvider01.MentionCharacter = '#';
            suggestionProvider01.SuggestionBoxStyle = this.Resources["SuggestionBoxStyle"] as Style;
            List<NameSuggestionItem> suggestionItems01 = new List<NameSuggestionItem>();
            NameSuggestionItem suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Desktop App";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Mobile App";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Web App";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Library";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Others";
            suggestionItems01.Add(suggestionItem01);

            (suggestionProvider01 as NameSuggestionProvider).ItemsSource = suggestionItems01;
            richTextBoxAdv.SuggestionSettings.SuggestionProviders.Add(suggestionProvider01);

        }
    }
}
