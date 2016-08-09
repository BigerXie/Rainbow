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
    [TemplatePart(Name = CloseButton, Type = typeof(RbIconButton))]
    public class RbPageBarItem : ListBoxItem
    {
        private const string CloseButton = "Part_CloseButton";
        static RbPageBarItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RbPageBarItem), new FrameworkPropertyMetadata(typeof(RbPageBarItem)));
        }

        private const string RbMouseOver = "RbMouseOver";
        private const string RbNormal = "RbNormal";
        private const string RbSelected = "RbSelected";

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

        internal RbIconButton closeButton;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            closeButton = GetTemplateChild(CloseButton) as RbIconButton;
            closeButton.Click += closeButton_Click;
        }

        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            var p1 = VisualTreeHelper.GetParent(this) as StackPanel;
            var p2 = VisualTreeHelper.GetParent(p1) as Border;
            var owningPageBarControl = VisualTreeHelper.GetParent(p2) as RbPageBar;
                
            // run the command handler for the TabControl
            // see #555
              Dispatcher.BeginInvoke(new Action(() => {
                  owningPageBarControl.CloseButtonInvoke(this);
              }));
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            if (!this.IsSelected)
                VisualStateManager.GoToState(this, RbMouseOver, true);
        }
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            if (!this.IsSelected)
                VisualStateManager.GoToState(this, RbNormal, true);
        }
        protected override void OnSelected(RoutedEventArgs e)
        {
            base.OnSelected(e);
            VisualStateManager.GoToState(this, RbSelected, true);
        }
        protected override void OnUnselected(RoutedEventArgs e)
        {
            base.OnUnselected(e);
            VisualStateManager.GoToState(this, RbNormal, true);
        }
    }
}
