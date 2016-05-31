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
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcOrganization : IIfcOrganization
	{
		Ifc4.MeasureResource.IfcIdentifier? IIfcOrganization.Identification 
		{ 
			get
			{
				if (!Id.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(Id.Value);
			} 
			set
			{
				Id = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel IIfcOrganization.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new MeasureResource.IfcLabel(value);
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcOrganization.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
		IItemSet<IIfcActorRole> IIfcOrganization.Roles 
		{ 
			get
			{
				foreach (var member in Roles)
				{
					yield return member as IIfcActorRole;
				}
			} 
		}
		IItemSet<IIfcAddress> IIfcOrganization.Addresses 
		{ 
			get
			{
				foreach (var member in Addresses)
				{
					yield return member as IIfcAddress;
				}
			} 
		}
		IEnumerable<IIfcOrganizationRelationship> IIfcOrganization.IsRelatedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcOrganizationRelationship>(e => e.RelatedOrganizations != null &&  e.RelatedOrganizations.Contains(this), "RelatedOrganizations", this);
			} 
		}
		IEnumerable<IIfcOrganizationRelationship> IIfcOrganization.Relates 
		{ 
			get
			{
				return Model.Instances.Where<IIfcOrganizationRelationship>(e => (e.RelatingOrganization as IfcOrganization) == this, "RelatingOrganization", this);
			} 
		}
		IEnumerable<IIfcPersonAndOrganization> IIfcOrganization.Engages 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPersonAndOrganization>(e => (e.TheOrganization as IfcOrganization) == this, "TheOrganization", this);
			} 
		}
	//## Custom code
	//##
	}
}