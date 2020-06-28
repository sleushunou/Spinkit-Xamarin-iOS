using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace SpinKit
{
	// @interface RTSpinKit9CubeGridAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKit9CubeGridAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitArcAltAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitArcAltAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitArcAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitArcAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitBounceAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitBounceAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitChasingDotsAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitChasingDotsAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitCircleAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitCircleAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitCircleFlipAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitCircleFlipAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitFadingCircleAltAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitFadingCircleAltAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitFadingCircleAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitFadingCircleAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitPlaneAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitPlaneAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitPulseAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitPulseAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitThreeBounceAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitThreeBounceAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitWanderingCubesAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitWanderingCubesAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitWaveAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitWaveAnimation : RTSpinKitAnimating
	{
	}

	// @interface RTSpinKitWordPressAnimation : NSObject <RTSpinKitAnimating>
	[BaseType(typeof(NSObject))]
	interface RTSpinKitWordPressAnimation : RTSpinKitAnimating
	{
	}

    // @protocol RTSpinKitAnimating <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface RTSpinKitAnimating
    {
        // @required -(void)setupSpinKitAnimationInLayer:(CALayer *)layer withSize:(CGSize)size color:(UIColor *)color;
        [Abstract]
        [Export("setupSpinKitAnimationInLayer:withSize:color:")]
        void SetupSpinKitAnimationInLayer(CALayer layer, CGSize size, UIColor color);
    }

	interface IRTSpinKitAnimating { }

	// @interface RTSpinKitView : UIView
	[BaseType(typeof(UIView))]
    interface RTSpinKitView
    {
        // @property (nonatomic, strong) UIColor * color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (assign, nonatomic) BOOL hidesWhenStopped;
        [Export("hidesWhenStopped")]
        bool HidesWhenStopped { get; set; }

        // @property (assign, nonatomic) RTSpinKitViewStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        RTSpinKitViewStyle Style { get; set; }

        // @property (assign, nonatomic) CGFloat spinnerSize;
        [Export("spinnerSize")]
        nfloat SpinnerSize { get; set; }

        // @property (getter = isStopped, assign, nonatomic) BOOL stopped;
        [Export("stopped")]
        bool Stopped { [Bind("isStopped")] get; set; }

        // -(instancetype)initWithCoder:(NSCoder *)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(instancetype)initWithStyle:(RTSpinKitViewStyle)style;
        [Export("initWithStyle:")]
        IntPtr Constructor(RTSpinKitViewStyle style);

        // -(instancetype)initWithStyle:(RTSpinKitViewStyle)style color:(UIColor *)color;
        [Export("initWithStyle:color:")]
        IntPtr Constructor(RTSpinKitViewStyle style, UIColor color);

         //-(instancetype) initWithAnimator:(id<RTSpinKitAnimating>) animator color:(UIColor*) color spinnerSize:(CGFloat) spinnerSize;
        [Export("initWithAnimator:color:spinnerSize:")]
        IntPtr Constructor(IRTSpinKitAnimating animator, UIColor color, nfloat spinnerSize);

        // -(instancetype)initWithStyle:(RTSpinKitViewStyle)style color:(UIColor *)color spinnerSize:(CGFloat)spinnerSize __attribute__((objc_designated_initializer));
        [Export("initWithStyle:color:spinnerSize:")]
        [DesignatedInitializer]
        IntPtr Constructor(RTSpinKitViewStyle style, UIColor color, nfloat spinnerSize);

        // -(void)startAnimating;
        [Export("startAnimating")]
        void StartAnimating();

        // -(void)stopAnimating;
        [Export("stopAnimating")]
        void StopAnimating();

        //-(BOOL) isAnimating;
        [Export("isAnimating")]
        //[Verify(MethodToProperty)]
        bool IsAnimating { get; }

        // -(void)setColor:(UIColor *)color animated:(BOOL)animated;
        [Export("setColor:animated:")]
        void SetColor(UIColor color, bool animated);
    }
}

