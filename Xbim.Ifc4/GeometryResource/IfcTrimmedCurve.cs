// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTrimmedCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTrimmedCurve : IIfcBoundedCurve
	{
		IIfcCurve @BasisCurve { get;  set; }
		IItemSet<IIfcTrimmingSelect> @Trim1 { get; }
		IItemSet<IIfcTrimmingSelect> @Trim2 { get; }
		IfcBoolean @SenseAgreement { get;  set; }
		IfcTrimmingPreference @MasterRepresentation { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcTrimmedCurve", 143)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTrimmedCurve : IfcBoundedCurve, IInstantiableEntity, IIfcTrimmedCurve, IContainsEntityReferences, IEquatable<@IfcTrimmedCurve>
	{
		#region IIfcTrimmedCurve explicit implementation
		IIfcCurve IIfcTrimmedCurve.BasisCurve { 
 
 
			get { return @BasisCurve; } 
			set { BasisCurve = value as IfcCurve;}
		}	
		IItemSet<IIfcTrimmingSelect> IIfcTrimmedCurve.Trim1 { 
			get { return new Common.Collections.ProxyItemSet<IfcTrimmingSelect, IIfcTrimmingSelect>( @Trim1); } 
		}	
		IItemSet<IIfcTrimmingSelect> IIfcTrimmedCurve.Trim2 { 
			get { return new Common.Collections.ProxyItemSet<IfcTrimmingSelect, IIfcTrimmingSelect>( @Trim2); } 
		}	
		IfcBoolean IIfcTrimmedCurve.SenseAgreement { 
 
			get { return @SenseAgreement; } 
			set { SenseAgreement = value;}
		}	
		IfcTrimmingPreference IIfcTrimmedCurve.MasterRepresentation { 
 
			get { return @MasterRepresentation; } 
			set { MasterRepresentation = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrimmedCurve(IModel model) : base(model) 		{ 
			_trim1 = new ItemSet<IfcTrimmingSelect>( this, 2,  2);
			_trim2 = new ItemSet<IfcTrimmingSelect>( this, 2,  3);
		}

		#region Explicit attribute fields
		private IfcCurve _basisCurve;
		private readonly ItemSet<IfcTrimmingSelect> _trim1;
		private readonly ItemSet<IfcTrimmingSelect> _trim2;
		private IfcBoolean _senseAgreement;
		private IfcTrimmingPreference _masterRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCurve @BasisCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisCurve;
				((IPersistEntity)this).Activate(false);
				return _basisCurve;
			} 
			set
			{
				SetValue( v =>  _basisCurve = v, _basisCurve, value,  "BasisCurve", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, 2, 4)]
		public IItemSet<IfcTrimmingSelect> @Trim1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _trim1;
				((IPersistEntity)this).Activate(false);
				return _trim1;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, 2, 5)]
		public IItemSet<IfcTrimmingSelect> @Trim2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _trim2;
				((IPersistEntity)this).Activate(false);
				return _trim2;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcBoolean @SenseAgreement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _senseAgreement;
				((IPersistEntity)this).Activate(false);
				return _senseAgreement;
			} 
			set
			{
				SetValue( v =>  _senseAgreement = v, _senseAgreement, value,  "SenseAgreement", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 7)]
		public IfcTrimmingPreference @MasterRepresentation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _masterRepresentation;
				((IPersistEntity)this).Activate(false);
				return _masterRepresentation;
			} 
			set
			{
				SetValue( v =>  _masterRepresentation = v, _masterRepresentation, value,  "MasterRepresentation", 5);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisCurve = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_trim1.InternalAdd((IfcTrimmingSelect)value.EntityVal);
					return;
				case 2: 
					_trim2.InternalAdd((IfcTrimmingSelect)value.EntityVal);
					return;
				case 3: 
					_senseAgreement = value.BooleanVal;
					return;
				case 4: 
                    _masterRepresentation = (IfcTrimmingPreference) System.Enum.Parse(typeof (IfcTrimmingPreference), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTrimmedCurve other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTrimmedCurve
            var root = (@IfcTrimmedCurve)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTrimmedCurve left, @IfcTrimmedCurve right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcTrimmedCurve left, @IfcTrimmedCurve right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisCurve != null)
					yield return @BasisCurve;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}