using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomViewCell : ViewCell
    {
        private string _name;
        public string Name
        {
            get => _name;
        }
        public CustomViewCell(string name)
        {
            _name = name;
            InitializeComponent();
            setNameInGui();
        }

        private void setNameInGui()
        {
            label.Text = Name;
        }
    }
}