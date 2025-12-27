using System.Windows.Controls;
using Autodesk.Revit.UI;

namespace DeepDeepBim.RevitApi.App;

public partial class ApplicationUI : UserControl
{
	public ApplicationUI(ExternalCommandData commandData)
	{
		InitializeComponent();

		string message = string.Empty;

		new RevitApiAccessibilityTestCommand().Execute(commandData, ref message, null!);
	}
}