// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace BackgroundFilteredView {
	
	
	// Should subclass MonoMac.AppKit.NSView
	[Foundation.Register("BackgroundFilteredView")]
	public partial class BackgroundFilteredView {
		
		private global::AppKit.NSView __mt_controls;
		
		#pragma warning disable 0169
		[Foundation.Export("addFilter:")]
		partial void AddFilter (AppKit.NSButton sender);

		[Foundation.Export("removeFilter:")]
		partial void RemoveFilter (AppKit.NSButton sender);

		[Foundation.Connect("controls")]
		private global::AppKit.NSView controls {
			get {
				this.__mt_controls = ((global::AppKit.NSView)(this.GetNativeField("controls")));
				return this.__mt_controls;
			}
			set {
				this.__mt_controls = value;
				this.SetNativeField("controls", value);
			}
		}
	}
	
	// Should subclass MonoMac.AppKit.NSWindow
	[Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
	}
}
