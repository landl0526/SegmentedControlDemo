using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SegmentedControlDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_ValueChanged(object sender, SegmentedControl.FormsPlugin.Abstractions.ValueChangedEventArgs e)
        {
            switch (e.NewValue)
            {
                case 0:
                    SegContent.Children.Clear();
                    TestPage test = new TestPage();
                    SegContent.Children.Add(test.Content);
                    break;
                case 1:
                    SegContent.Children.Clear();
                    SegContent.Children.Add(new Label() { Text = "tab selected" });
                    break;
                default:
                    break;
            }
        }
    }
}
