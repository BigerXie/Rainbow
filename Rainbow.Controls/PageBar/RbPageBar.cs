using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rainbow.Controls
{
    public class RbPageBar : ListBox
    {
        static RbPageBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RbPageBar), new FrameworkPropertyMetadata(typeof(RbPageBar)));
        }
        public RbPageBar()
        {
            SelectionMode = SelectionMode.Single;
        }
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is RbPageBarItem;
        }
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new RbPageBarItem() { ContentTemplate = ItemTemplate, Height = Height };
        }
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            if (element != item)
                element.SetCurrentValue(DataContextProperty, item);
            base.PrepareContainerForItemOverride(element, item);
        }
        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            var item = SelectedItem;
            base.OnSelectionChanged(e);
        }
        internal void CloseButtonInvoke(RbPageBarItem item)
        {
            var source = this.ItemsSource as IList;
            source.Remove(item.DataContext);
        }
    }
}
