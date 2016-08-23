using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rainbow.Controls
{
    public class RbPage : ContentControl
    {
        static RbPage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RbPage), new FrameworkPropertyMetadata(typeof(RbPage)));
        }
        public RbPage()
        {
            Loaded += RbPage_Loaded;
            Unloaded += RbPage_Unloaded;
        }

        void RbPage_Unloaded(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "ZoomIn", true);
        }

        void RbPage_Loaded(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "ZoomOut", true);
        }

        public object HeaderContent
        {
            get { return (object)GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderContentProperty =
            DependencyProperty.Register("HeaderContent", typeof(object), typeof(RbPage), new PropertyMetadata(null));



        public Brush HeaderBackground
        {
            get { return (Brush)GetValue(HeaderBackgroundProperty); }
            set { SetValue(HeaderBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderBackgroundProperty =
            DependencyProperty.Register("HeaderBackground", typeof(Brush), typeof(RbPage), new PropertyMetadata(null));



        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(RbPage), new PropertyMetadata(null));



        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(RbPage), new PropertyMetadata(null));

        

    }
}
