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
	public partial class @IfcRelDefinesByProperties : IIfcRelDefinesByProperties
	{
		IItemSet<IIfcObjectDefinition> IIfcRelDefinesByProperties.RelatedObjects 
		{ 
			get
			{
				foreach (var member in RelatedObjects)
				{
					yield return member as IIfcObjectDefinition;
				}
			} 
		}

		private  IIfcPropertySetDefinitionSelect _relatingPropertyDefinition4;

		IIfcPropertySetDefinitionSelect IIfcRelDefinesByProperties.RelatingPropertyDefinition 
		{ 
			get
			{
				return  _relatingPropertyDefinition4 ?? RelatingPropertyDefinition;
			} 
			set
			{
				if (value == null)
				{
					RelatingPropertyDefinition = null;
					if (_relatingPropertyDefinition4 != null)
						SetValue(v => _relatingPropertyDefinition4 = v, _relatingPropertyDefinition4, null, "RelatingPropertyDefinition", byte.MaxValue);
					return;
				}
				
				var val = value as IfcPropertySetDefinition;
				if (val != null)
				{
					RelatingPropertyDefinition = val;
					if (_relatingPropertyDefinition4 != null)
						SetValue(v => _relatingPropertyDefinition4 = v, _relatingPropertyDefinition4, null, "RelatingPropertyDefinition", byte.MaxValue);
					return;
				} 

				if(RelatingPropertyDefinition != null)
					RelatingPropertyDefinition = null;
				SetValue(v => _relatingPropertyDefinition4 = v, _relatingPropertyDefinition4, value, "RelatingPropertyDefinition", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}