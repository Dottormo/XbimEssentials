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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcFaceBasedSurfaceModel : IIfcFaceBasedSurfaceModel
	{
		IItemSet<IIfcConnectedFaceSet> IIfcFaceBasedSurfaceModel.FbsmFaces 
		{ 
			get
			{
				foreach (var member in FbsmFaces)
				{
					yield return member as IIfcConnectedFaceSet;
				}
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcFaceBasedSurfaceModel.Dim 
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