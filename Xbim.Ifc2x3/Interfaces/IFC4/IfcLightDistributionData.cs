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
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcLightDistributionData : IIfcLightDistributionData
	{
		Ifc4.MeasureResource.IfcPlaneAngleMeasure IIfcLightDistributionData.MainPlaneAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(MainPlaneAngle);
			} 
			set
			{
				MainPlaneAngle = new MeasureResource.IfcPlaneAngleMeasure(value);
				
			}
		}
		IItemSet<Xbim.Ifc4.MeasureResource.IfcPlaneAngleMeasure> IIfcLightDistributionData.SecondaryPlaneAngle 
		{ 
			get
			{
				foreach (var member in SecondaryPlaneAngle)
				{
					yield return new Ifc4.MeasureResource.IfcPlaneAngleMeasure((double)member);
				}
			} 
		}
		IItemSet<Xbim.Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure> IIfcLightDistributionData.LuminousIntensity 
		{ 
			get
			{
				foreach (var member in LuminousIntensity)
				{
					yield return new Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure((double)member);
				}
			} 
		}
	//## Custom code
	//##
	}
}