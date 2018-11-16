using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SegmentedControlDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestPage : ContentPage
	{
		public TestPage ()
		{
			InitializeComponent ();

            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add("item" + i);
            }
            MyListView.ItemsSource = list;
        }
	}
}