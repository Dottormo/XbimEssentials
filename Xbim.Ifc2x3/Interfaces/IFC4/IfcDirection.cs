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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcDirection : IIfcDirection
	{
		IItemSet<Xbim.Ifc4.MeasureResource.IfcReal> IIfcDirection.DirectionRatios 
		{ 
			get
			{
				//## Handle return of DirectionRatios for which no match was found
			    return DirectionRatios.Select(ratio => new Ifc4.MeasureResource.IfcReal(ratio));
			    //##
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcDirection.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}