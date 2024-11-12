using System.Windows.Forms;
using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.SNRLogger
{
    public class SNRLoggerPlugin : ISharpPlugin
    {
        private const string _displayName = "SNR Logger";
        private ISharpControl _control;
                        
        private ProcessorPanel _guiControl;
        
        public string DisplayName
        {
            get { return _displayName; }
        }

        public UserControl Gui
        {
            get { return _guiControl; }
        }

        public void Initialize(ISharpControl control)
        {
            _control = control;
            _guiControl = new ProcessorPanel(_control);
        }

        public void Close()
        {
        }        
    }
}
