// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace AppiumProofOfConcept
{
	[Register ("AppiumProofOfConceptViewController")]
	partial class AppiumProofOfConceptViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField ExampleTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ExampleTextField != null) {
				ExampleTextField.Dispose ();
				ExampleTextField = null;
			}
		}
	}
}
