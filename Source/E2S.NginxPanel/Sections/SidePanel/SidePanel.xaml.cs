using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;

namespace E2S.NginxPanel.Sections.SidePanel;

public partial class SidePanel : ContentView
{

    internal SidePanelVm? Vm { get; set; }
    public SidePanel()
    {
        InitializeComponent();
    }
}

internal class SidePanelVm
{
    public List<string> TestList { get; set; }

    public SidePanelVm()
    {
        TestList = ["A", "BB", "CCC", "DDDDD"];
    }
}

