using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MoneyCalcWeb.DataService;

namespace MoneyCalcWeb
{
    public partial class MainPage : UserControl
    {
        MessageBox messageBox;

        public MainPage()
        {
            InitializeComponent();
            messageBox = new MessageBox();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataServiceSoapClient dataService = new DataServiceSoapClient();
            dataService.HelloWorldCompleted += new EventHandler<HelloWorldCompletedEventArgs>(dataService_HelloWorldCompleted);
            dataService.HelloWorldAsync();
        }

        void dataService_HelloWorldCompleted(object sender, HelloWorldCompletedEventArgs e)
        {
            //messageBox.ShowText(e.Result);
            System.Windows.MessageBox.Show(e.Result);
        }
    }
}
