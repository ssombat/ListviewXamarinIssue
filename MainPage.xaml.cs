using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<CustomViewCell> observableCollection = new ObservableCollection<CustomViewCell>(); 
        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = observableCollection;

            observableCollection.Add(new CustomViewCell("test1"));
            observableCollection.Add(new CustomViewCell("test2"));
            observableCollection.Add(new CustomViewCell("test3"));
            observableCollection.Add(new CustomViewCell("test4"));
            observableCollection.Add(new CustomViewCell("test5"));
            observableCollection.Add(new CustomViewCell("test6"));
        }
    }
}
