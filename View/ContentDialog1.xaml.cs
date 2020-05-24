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

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyMusicLibrary.View
{
    public sealed partial class ContentDialog1 : ContentDialog
    {
            public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
                "Text", typeof(string), typeof(ContentDialog1), new PropertyMetadata(default(string)));

            TextBox TextBox1 = new TextBox();
            public ContentDialog1()
            {
                this.InitializeComponent();
            }

            public string Text
            {
                get { return (string)GetValue(TextProperty); }
                set { SetValue(TextProperty, value); }
            }
            private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
            {

                //var text = ct1.Text;
            }
            private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
            {
                //TextBox1.Text = " ";
                //ct1.Hide();

            }

            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {
                string text1 = TextBox1.Text;
            }
        }
    }