using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace DeepDeepBim.RevitApi.App;

[Transaction(TransactionMode.Manual)]
class RevitApiAccessibilityTestCommand : IExternalCommand
{
	public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
	{
		TaskDialog.Show("Revit API Accessibility Test", "The Revit API is accessible from this external command.");

		return Result.Succeeded;
	}
}
