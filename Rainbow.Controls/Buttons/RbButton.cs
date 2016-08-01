using System.Windows;
using System.Windows.Controls;

namespace Rainbow.Controls.Buttons
{
    public class RbButton : Button
    {
        static RbButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RbButton), new FrameworkPropertyMetadata(typeof(RbButton)));
        }
    }
}
