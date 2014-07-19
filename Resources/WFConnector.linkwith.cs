//
//  WFConnector.linkwith.cs
//
//  Author:
//       Safwan Choudhury <im@safwanc.com>
//
using System;

using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("WFConnector.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
