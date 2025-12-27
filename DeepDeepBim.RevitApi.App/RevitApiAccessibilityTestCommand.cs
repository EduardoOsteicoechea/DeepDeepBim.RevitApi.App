using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace DeepDeepBim.RevitApi.App;

[Transaction(TransactionMode.Manual)]
class RevitApiAccessibilityTestCommand : IExternalCommand
{
	public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
	{
		var doc = commandData.Application.ActiveUIDocument.Document;

		TaskDialog.Show(
			"Revit API Accessibility Test", 
			$"{doc.Title}"
		);

		return Result.Succeeded;
	}
}
