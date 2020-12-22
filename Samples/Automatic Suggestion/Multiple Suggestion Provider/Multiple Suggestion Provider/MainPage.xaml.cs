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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Multiple_Suggestion_Provider
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
            suggestionProvider01.SuggestionBoxStyle = this.Resources["SuggestionBoxStyle01"] as Style;
            List<NameSuggestionItem> suggestionItems01 = new List<NameSuggestionItem>();
            NameSuggestionItem suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Desktop App";
            suggestionItem01.Link = "10 queries";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Mobile App";
            suggestionItem01.Link = "13 queries";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Web App";
            suggestionItem01.Link = "15 queries";
            suggestionItems01.Add(suggestionItem01);

            suggestionItem01 = new NameSuggestionItem();
            suggestionItem01.Name = "Library";
            suggestionItem01.Link = "8 queries";
            suggestionItems01.Add(suggestionItem01);

            (suggestionProvider01 as NameSuggestionProvider).ItemsSource = suggestionItems01;
            richTextBoxAdv.SuggestionSettings.SuggestionProviders.Add(suggestionProvider01);


            ISuggestionProvider suggestionProvider = new NameSuggestionProvider();
            suggestionProvider.SuggestionBoxStyle = this.Resources["SuggestionBoxStyle"] as Style;
            List<NameSuggestionItem> suggestionItems = new List<NameSuggestionItem>();
            NameSuggestionItem suggestionItem = new NameSuggestionItem();
            suggestionItem.Name = "Nancy Davolio";
            suggestionItem.Link = "mailto:nancy.davolio@northwindtraders.com";
            BitmapImage bitmapImage = new BitmapImage(new Uri(new DirectoryInfo(@"ms - appx:..\..\Assets\People_Circle0.png").FullName));
            suggestionItem.ImageSource = bitmapImage;
            suggestionItems.Add(suggestionItem);

            suggestionItem = new NameSuggestionItem();
            suggestionItem.Name = "Andrew Fuller";
            suggestionItem.Link = "mailto:andrew.fuller@northwindtraders.com";
            bitmapImage = new BitmapImage(new Uri(new DirectoryInfo(@"ms - appx:..\..\Assets\People_Circle5.png").FullName));
            suggestionItem.ImageSource = bitmapImage;
            suggestionItems.Add(suggestionItem);


            suggestionItem = new NameSuggestionItem();
            suggestionItem.Name = "Steven Buchanan";
            suggestionItem.Link = "mailto:steven.buchanan@northwindtraders.com";
            bitmapImage = new BitmapImage(new Uri(new DirectoryInfo(@"ms - appx:..\..\Assets\People_Circle18.png").FullName));
            suggestionItem.ImageSource = bitmapImage;
            suggestionItems.Add(suggestionItem);

            (suggestionProvider as NameSuggestionProvider).ItemsSource = suggestionItems;

            richTextBoxAdv.SuggestionSettings.SuggestionProviders.Add(suggestionProvider);

        }
    }
}
