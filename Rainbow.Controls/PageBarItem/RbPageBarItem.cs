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
    public class RbPageBarItem : ContentControl
    {
        static RbPageBarItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RbPageBarItem), new FrameworkPropertyMetadata(typeof(RbPageBarItem)));
        }

        public Thickness CloseButtonMargin
        {
            get { return (Thickness)GetValue(CloseButtonMarginProperty); }
            set { SetValue(CloseButtonMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButtonMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonMarginProperty =
            DependencyProperty.Register("CloseButtonMargin", typeof(Thickness), typeof(RbPageBarItem), new PropertyMetadata(new Thickness(0)));


        public double CloseButtonHeight
        {
            get { return (double)GetValue(CloseButtonHeightProperty); }
            set { SetValue(CloseButtonHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButtonHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonHeightProperty =
            DependencyProperty.Register("CloseButtonHeight", typeof(double), typeof(RbPageBarItem), new PropertyMetadata(0.0));


        public double CloseButtonWidth
        {
            get { return (double)GetValue(CloseButtonWidthProperty); }
            set { SetValue(CloseButtonWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CloseButtonWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseButtonWidthProperty =
            DependencyProperty.Register("CloseButtonWidth", typeof(double), typeof(RbPageBarItem), new PropertyMetadata(0.0));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(RbPageBarItem), new PropertyMetadata(null));



        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(RbPageBarItem), new PropertyMetadata(null));



        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsSelected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register("IsSelected", typeof(bool), typeof(RbPageBarItem), new PropertyMetadata(false, IsSelectedPropertyChangedCallback));

        private static void IsSelectedPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var rbPageBarItem = d as RbPageBarItem;
            if (rbPageBarItem == null)
                return;
            //if(rbPageBarItem.IsSelected)
            //    VisualStateManager.GoToState(rbPageBarItem, "Selected", true);
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            if (!this.IsSelected)
                VisualStateManager.GoToState(this, "MouseOver", true);
        }
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            if (!this.IsSelected)
                VisualStateManager.GoToState(this, "Normal", true);
        }
    }
}
