// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcArbitraryProfileDefWithVoids : IIfcArbitraryProfileDefWithVoids
	{
		IItemSet<IIfcCurve> IIfcArbitraryProfileDefWithVoids.InnerCurves 
		{ 
			get
			{
				foreach (var member in InnerCurves)
				{
					yield return member as IIfcCurve;
				}
			} 
		}
	//## Custom code
	//##
	}
}