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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcTypeObject : IIfcTypeObject
	{
		Ifc4.MeasureResource.IfcIdentifier? IIfcTypeObject.ApplicableOccurrence 
		{ 
			get
			{
				if (!ApplicableOccurrence.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(ApplicableOccurrence.Value);
			} 
			set
			{
				ApplicableOccurrence = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IItemSet<IIfcPropertySetDefinition> IIfcTypeObject.HasPropertySets 
		{ 
			get
			{
				foreach (var member in HasPropertySets)
				{
					yield return member as IIfcPropertySetDefinition;
				}
			} 
		}
		IEnumerable<IIfcRelDefinesByType> IIfcTypeObject.Types 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByType>(e => (e.RelatingType as IfcTypeObject) == this, "RelatingType", this);
			} 
		}
	//## Custom code
        IEnumerable<IIfcRelDefinesByProperties> IIfcTypeObject.DefinedByProperties
        {
            get
            {
                //this will never return anything because IIfcRelDefinesByProperties.RelatedObjects is of different type in IFC4
                yield break;
            }
        }
	//##
	}
}