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

namespace _8thball
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
       
        }

        public object Console { get; private set; }
        
        private void Button1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Random num = new Random();
            int a = num.Next(8);
            switch (a)
            {
                case 0:
                    Harold.Text = "";
                    break;
                case 1:
                    Harold.Text = "Yes";
                    break;
                case 2:
                    Harold.Text = "No";
                    break;
                case 3:
                    Harold.Text = "Maybe";
                    break;
                case 4:
                    Harold.Text = "You could say that";
                    break;
                case 5:
                    Harold.Text = "Most certain";
                    break;
                case 6:
                    Harold.Text = "Dont even try";
                    break;
                case 7:
                    Harold.Text = "Full steam ahead";
                    break;
                case 8:
                    Harold.Text = "Try again";
                    break;
            }
            System.Diagnostics.Debug.WriteLine("clicked!");
        }
    }
    }
