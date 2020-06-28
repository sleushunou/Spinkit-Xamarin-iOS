using System;
using CoreGraphics;
using SpinKit;
using UIKit;

namespace SpinkKitDemo
{
    public partial class ViewController : UIViewController
    {
        private int _numberOfSpinners = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void LoadView()
        {
            base.LoadView();

            var scrollView = new UIScrollView();
            scrollView.PagingEnabled = true;
            scrollView.AlwaysBounceVertical = false;
            scrollView.AlwaysBounceHorizontal = true;
            scrollView.DirectionalLockEnabled = true;
            scrollView.BackgroundColor = UIColor.DarkGray;
            this.View = scrollView;

            InsertSpinnerOfStyle(RTSpinKitViewStyle.Plane, UIColor.FromRGB(0.827f, 0.329f, 0), "Plane");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.Bounce, UIColor.FromRGB(0.173f, 0.243f, 0.314f), "Bounce");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.Wave, UIColor.FromRGB(0.102f, 0.737f, 0.612f), "Wave");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.WanderingCubes, UIColor.FromRGB(0.161f, 0.502f, 0.725f), "WanderingCubes");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.Pulse, UIColor.FromRGB(0.498f, 0.549f, 0.553f), "Pulse");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.CircleFlip, UIColor.FromWhiteAlpha(0.2f, 0.612f), "CircleFlip");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.ChasingDots, UIColor.FromRGB(0.95f, 0.77f, 0.06f), "ChasingDots");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.ThreeBounce, UIColor.FromRGB(0.83f, 0.33f, 0), "ThreeBounce");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.Circle, UIColor.FromRGB(0.15f, 0.68f, 0.38f), "Circle");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.RTSpinKitViewStyle9CubeGrid, UIColor.FromRGB(0.68f, 0.15f, 0.47f), "9CubeGrid");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.WordPress, UIColor.FromRGB(0.08f, 0.57f, 0.86f), "WordPress");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.FadingCircle, UIColor.FromRGB(0, 0.6f, 0.24f), "FadingCircle");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.FadingCircleAlt, UIColor.FromRGB(0.6f, 0, 0), "FadingCircleAlt");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.Arc, UIColor.FromRGB(0.56f, 0.27f, 0.68f), "Arc");
            InsertSpinnerOfStyle(RTSpinKitViewStyle.ArcAlt, UIColor.FromRGB(0.91f, 0.3f, 0.24f), "ArcAlt");

            var screenBounds = UIScreen.MainScreen.Bounds;
            scrollView.ContentSize = new CGSize(_numberOfSpinners * screenBounds.Width, screenBounds.Height);
        }

        private void InsertSpinnerOfStyle(
            RTSpinKitViewStyle style,
            UIColor backgroundColor,
            string labelString)
        {
            var screenBounds = UIScreen.MainScreen.Bounds;
            var screenWidth = screenBounds.Width;

            var spinner = new RTSpinKitView(style, UIColor.White);
            spinner.Center = new CGPoint(screenBounds.GetMidX(), screenBounds.GetMidY());
            spinner.StartAnimating();

            screenBounds.Offset(screenWidth *_numberOfSpinners, 0f);

            var panel = new UIView(screenBounds);
            panel.BackgroundColor = backgroundColor;
            panel.AddSubview(spinner);

            var label = new UILabel(new CGRect(0, 50, screenWidth, 30));
            label.Text = labelString;
            label.Font = UIFont.SystemFontOfSize(25);
            label.TextColor = UIColor.White;
    
            if (label.RespondsToSelector(new ObjCRuntime.Selector("timeColor")))
            {
                label.TextAlignment = UITextAlignment.Center;
            }
            else
            {
                label.TextAlignment = UITextAlignment.Center;
                label.BackgroundColor = UIColor.Clear;
            }
            panel.AddSubview(label);
    
            var scrollView = (UIScrollView)View;
            scrollView.AddSubview(panel);
    
            _numberOfSpinners += 1;
        }       

        //public override void ViewDidLoad()
        //{
        //    base.ViewDidLoad();

        //    var view = new RTSpinKitView(RTSpinKitViewStyle.Wave)
        //    {
        //        Color = UIColor.Green,
        //        SpinnerSize = 200
        //    };
        //    view.SetColor(UIColor.Red, true);
        //    View.AddSubview(view);
        //}
    }
}