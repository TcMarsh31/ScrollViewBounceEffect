using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BounceEffect
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BounceTabbedPage : TabbedPage
    {
        public BounceTabbedPage()
        {
            InitializeComponent();
        }
    }
}
