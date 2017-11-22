using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Projekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();  
        }

        private void BTN_Logind_OnClick(object sender, RoutedEventArgs e)
        {

            #region If statements
            //if (TBEmail.Text == "admin@admin.dk" && TBKodeord.Password == "12345")
            //{
            //    Frame.Navigate(typeof(Forside));
            //}
            //if (TBEmail.Text != "admin@admin.dk")
            //{
            //    TBEmail.BorderBrush = new SolidColorBrush(Colors.Red);
            //}
            //if (TBKodeord.Password != "admin@admin.dk")
            //{
            //    TBKodeord.BorderBrush = new SolidColorBrush(Colors.Red);
            //}
            //if (TBEmail.Text == "admin@admin.dk" && TBKodeord.Password != "12345")
            //{
            //    TBEmail.BorderBrush = new SolidColorBrush(Colors.LightGray);
            //}
            //if (TBEmail.Text != "admin@admin.dk" && TBKodeord.Password == "12345")
            //{
            //    TBKodeord.BorderBrush = new SolidColorBrush(Colors.LightGray);
            //}
            #endregion
            #region If statements2
            if (TBEmail.Text == "1" && TBKodeord.Password == "1")
            {
                Frame.Navigate(typeof(Forside));
            }
            if (TBEmail.Text != "1")
            {
                TBEmail.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (TBKodeord.Password != "1")
            {
                TBKodeord.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (TBEmail.Text == "1" && TBKodeord.Password != "1")
            {
                TBEmail.BorderBrush = new SolidColorBrush(Colors.LightGray);
            }
            if (TBEmail.Text != "1" && TBKodeord.Password == "1")
            {
                TBKodeord.BorderBrush = new SolidColorBrush(Colors.LightGray);
            }
            #endregion

        }
    }
}
