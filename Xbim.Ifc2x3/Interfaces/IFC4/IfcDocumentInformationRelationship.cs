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
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcDocumentInformationRelationship : IIfcDocumentInformationRelationship
	{
		IIfcDocumentInformation IIfcDocumentInformationRelationship.RelatingDocument 
		{ 
			get
			{
				return RelatingDocument;
			} 
			set
			{
				RelatingDocument = value as IfcDocumentInformation;
				
			}
		}
		IItemSet<IIfcDocumentInformation> IIfcDocumentInformationRelationship.RelatedDocuments 
		{ 
			get
			{
				foreach (var member in RelatedDocuments)
				{
					yield return member as IIfcDocumentInformation;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcDocumentInformationRelationship.RelationshipType 
		{ 
			get
			{
				if (!RelationshipType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(RelationshipType.Value);
			} 
			set
			{
				RelationshipType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		private  Ifc4.MeasureResource.IfcLabel? _name;

		Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				return _name;
			} 
			set
			{
				SetValue(v => _name = v, _name, value, "Name", byte.MaxValue);
				
			}
		}

		private  Ifc4.MeasureResource.IfcText? _description;

		Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", byte.MaxValue);
				
			}
		}
	//## Custom code
	//##
	}
}