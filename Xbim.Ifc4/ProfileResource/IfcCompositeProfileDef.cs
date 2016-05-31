// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCompositeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCompositeProfileDef : IIfcProfileDef
	{
		IItemSet<IIfcProfileDef> @Profiles { get; }
		IfcLabel? @Label { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IfcCompositeProfileDef", 172)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeProfileDef : IfcProfileDef, IInstantiableEntity, IIfcCompositeProfileDef, IContainsEntityReferences, IEquatable<@IfcCompositeProfileDef>
	{
		#region IIfcCompositeProfileDef explicit implementation
		IItemSet<IIfcProfileDef> IIfcCompositeProfileDef.Profiles { 
			get { return new Common.Collections.ProxyItemSet<IfcProfileDef, IIfcProfileDef>( @Profiles); } 
		}	
		IfcLabel? IIfcCompositeProfileDef.Label { 
 
			get { return @Label; } 
			set { Label = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeProfileDef(IModel model) : base(model) 		{ 
			_profiles = new ItemSet<IfcProfileDef>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcProfileDef> _profiles;
		private IfcLabel? _label;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 2, -1, 5)]
		public IItemSet<IfcProfileDef> @Profiles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _profiles;
				((IPersistEntity)this).Activate(false);
				return _profiles;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcLabel? @Label 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _label;
				((IPersistEntity)this).Activate(false);
				return _label;
			} 
			set
			{
				SetValue( v =>  _label = v, _label, value,  "Label", 4);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_profiles.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 3: 
					_label = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCompositeProfileDef
            var root = (@IfcCompositeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCompositeProfileDef left, @IfcCompositeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcCompositeProfileDef left, @IfcCompositeProfileDef right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Profiles)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}