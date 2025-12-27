using System.Windows.Controls;
using Autodesk.Revit.UI;

namespace DeepDeepBim.RevitApi.App;

public partial class ApplicationUI : UserControl
{
	public ApplicationUI()
	{
		InitializeComponent();

		TaskDialog.Show("DeepDeepBim Revit Add-in", "Hello from DeepDeepBim Revit Add-in!");
	}
}