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
    public class RbIconButton : Button
    {
        static RbIconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RbIconButton), new FrameworkPropertyMetadata(typeof(RbIconButton)));
        }

        public Geometry IconPath
        {
            get { return (Geometry)GetValue(IconPathProperty); }
            set { SetValue(IconPathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconPath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconPathProperty =
            DependencyProperty.Register("IconPath", typeof(Geometry), typeof(RbIconButton), new PropertyMetadata(null));



        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(RbIconButton), new PropertyMetadata(15.0));



        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(RbIconButton), new PropertyMetadata(15.0));



        public VerticalAlignment IconVerticalAlignment
        {
            get { return (VerticalAlignment)GetValue(IconVerticalAlignmentProperty); }
            set { SetValue(IconVerticalAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconVerticalAlignment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconVerticalAlignmentProperty =
            DependencyProperty.Register("IconVerticalAlignment", typeof(VerticalAlignment), typeof(RbIconButton), new PropertyMetadata(VerticalAlignment.Center));



        public HorizontalAlignment IconHorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(IconHorizontalAlignmentProperty); }
            set { SetValue(IconHorizontalAlignmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconHorizontalAlignment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHorizontalAlignmentProperty =
            DependencyProperty.Register("IconHorizontalAlignment", typeof(HorizontalAlignment), typeof(RbIconButton), new PropertyMetadata(HorizontalAlignment.Center));


    }
}
