using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interactivity;
using System.Windows;
using Rainbow.Shell.Utility;
using System.Windows.Controls;
using Rainbow.Controls;
using System.Windows.Media;

namespace Rainbow.Shell.Actions
{
    /// <summary>
    /// Creating custom triggers and actions:
    /// https://msdn.microsoft.com/en-us/library/ff724707(v=expression.40).aspx
    /// Creating custom behaviors:
    /// https://msdn.microsoft.com/en-us/library/ff724708(v=expression.40).aspx
    /// </summary>
    public class FullScreenAction : TargetedTriggerAction<Window>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            ChangeButtonState(WindowHelper.IsFullScreen);
        }
        protected override void Invoke(object parameter)
        {
            if (this.Target == null)
                return;
            if (WindowHelper.IsFullScreen)
                this.Target.ExitFullScreen();
            else
                this.Target.FullScreen();
            ChangeButtonState(WindowHelper.IsFullScreen);
        }
        private void ChangeButtonState(bool isFullScreen)
        {
            var button = AssociatedObject as RbIconButton;
            if (button == null)
                return;
            if (isFullScreen)
            {
                button.IconPath = Application.Current.Resources["Path_ExitFullDisplay"] as Geometry;
                button.ToolTip = "Exit FullScreen";
            }
            else
            {
                button.IconPath = Application.Current.Resources["Path_FullDisplay"] as Geometry;
                button.ToolTip = "Enter FullScreen";
            }
        }
    }
}
