using Syncfusion.UI.Xaml.RichTextBoxAdv;
using System.IO;
using System.Reflection;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfRichTextBoxAdv
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Constructor
        public MainPage()
        {
            this.InitializeComponent();

            //Loads the document into UWP SfRichTextBoxAdv.
            Stream fileStream = typeof(MainPage).GetTypeInfo().Assembly.GetManifestResourceStream("SfRichTextBoxAdv.Assets.GettingStarted.docx");
            richTextBoxAdv.Load(fileStream, FormatType.Docx);
        }
        #endregion
    }
}
