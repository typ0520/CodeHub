// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CodeHub.iOS.ViewControllers.Accounts
{
	[Register ("AddAccountView")]
	partial class AddAccountViewController
	{
		[Outlet]
		UIKit.UISegmentedControl AuthenticationSelector { get; set; }

		[Outlet]
		UIKit.UIView ContainerView { get; set; }

		[Outlet]
		UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		UIKit.UITextField Domain { get; set; }

		[Outlet]
		UIKit.UIButton LoginButton { get; set; }

		[Outlet]
		UIKit.UIImageView Logo { get; set; }

		[Outlet]
		UIKit.UITextField Password { get; set; }

		[Outlet]
		UIKit.UIScrollView ScrollView { get; set; }

		[Outlet]
		UIKit.UIStackView StackView { get; set; }

		[Outlet]
		UIKit.UITextField TokenTextField { get; set; }

		[Outlet]
		UIKit.UITextField User { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ContainerView != null) {
				ContainerView.Dispose ();
				ContainerView = null;
			}

			if (Domain != null) {
				Domain.Dispose ();
				Domain = null;
			}

			if (LoginButton != null) {
				LoginButton.Dispose ();
				LoginButton = null;
			}

			if (Logo != null) {
				Logo.Dispose ();
				Logo = null;
			}

			if (Password != null) {
				Password.Dispose ();
				Password = null;
			}

			if (ScrollView != null) {
				ScrollView.Dispose ();
				ScrollView = null;
			}

			if (User != null) {
				User.Dispose ();
				User = null;
			}

			if (StackView != null) {
				StackView.Dispose ();
				StackView = null;
			}

			if (TokenTextField != null) {
				TokenTextField.Dispose ();
				TokenTextField = null;
			}

			if (AuthenticationSelector != null) {
				AuthenticationSelector.Dispose ();
				AuthenticationSelector = null;
			}

			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}
		}
	}
}
