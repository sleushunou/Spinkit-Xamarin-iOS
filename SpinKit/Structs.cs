using System.Runtime.InteropServices;
using CoreAnimation;
using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpinKit
{
	[Native]
	public enum RTSpinKitViewStyle : ulong
	{
		Custom,
		Plane,
		CircleFlip,
		Bounce,
		Wave,
		WanderingCubes,
		Pulse,
		ChasingDots,
		ThreeBounce,
		Circle,
		RTSpinKitViewStyle9CubeGrid,
		WordPress,
		FadingCircle,
		FadingCircleAlt,
		Arc,
		ArcAlt
	}
}

