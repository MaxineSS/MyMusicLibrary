using MyMusicLibrary.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Pickers.Provider;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static System.Net.Mime.MediaTypeNames;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyMusicLibrary.View
{
    public sealed partial class ContentDialog1 : ContentDialog
    {

        DialogBinding binding = new DialogBinding();
        public ContentDialog1()
        {
            this.InitializeComponent();
            DataContext = binding;
        }

        public string Text
        {
            get { return binding.Text; }
            set { binding.Text = value; }
        }
        public string Text2
        {
            get { return binding.Text2; }
            set { binding.Text2 = value; }
        }
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        class DialogBinding
        {
            public string Text { get; set; }
            public string Text2 { get; set; }
        }

    }
 }


