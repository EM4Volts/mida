using System.Windows.Controls;

namespace MIDA;

public partial class ConfigSettingControl : UserControl
{
    public ConfigSettingControl()
    {
        InitializeComponent();
        DataContext = this;
    }

    public string SettingName { get; set; }
    public string SettingValue { get; set; }
    public string SettingLabel { get; set; }
}
