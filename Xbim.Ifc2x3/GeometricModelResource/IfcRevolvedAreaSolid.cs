// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRevolvedAreaSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRevolvedAreaSolid : IIfcSweptAreaSolid
	{
		IIfcAxis1Placement @Axis { get; }
		IfcPlaneAngleMeasure @Angle { get; }
		
	}
}

namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IFCREVOLVEDAREASOLID", 515)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRevolvedAreaSolid : IfcSweptAreaSolid, IInstantiableEntity, IIfcRevolvedAreaSolid, IEqualityComparer<@IfcRevolvedAreaSolid>, IEquatable<@IfcRevolvedAreaSolid>
	{
		#region IIfcRevolvedAreaSolid explicit implementation
		IIfcAxis1Placement IIfcRevolvedAreaSolid.Axis { get { return @Axis; } }	
		IfcPlaneAngleMeasure IIfcRevolvedAreaSolid.Angle { get { return @Angle; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRevolvedAreaSolid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axis;
		private IfcPlaneAngleMeasure _angle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis1Placement @Axis 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axis;
				((IPersistEntity)this).Activate(false);
				return _axis;
			} 
			set
			{
				SetValue( v =>  _axis = v, _axis, value,  "Axis");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure @Angle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _angle;
				((IPersistEntity)this).Activate(false);
				return _angle;
			} 
			set
			{
				SetValue( v =>  _angle = v, _angle, value,  "Angle");
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public GeometryResource.XbimLine @AxisLine 
		{
			get 
			{
				//## Getter for AxisLine
                if (Axis != null)
                {
                    return new XbimLine
                    {
                        Pnt = Axis.Location,
                        Orientation = Axis.Z,
                    };
                }
                return null;
				//##
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
					_axis = (IfcAxis1Placement)(value.EntityVal);
					return;
				case 3: 
					_angle = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : Axis.Location.Coordinates[3] = 0.0;*/
		/*WR32:	WR32 : Axis.Z.DirectionRatios[3] = 0.0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRevolvedAreaSolid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRevolvedAreaSolid
            var root = (@IfcRevolvedAreaSolid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRevolvedAreaSolid left, @IfcRevolvedAreaSolid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRevolvedAreaSolid left, @IfcRevolvedAreaSolid right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRevolvedAreaSolid x, @IfcRevolvedAreaSolid y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRevolvedAreaSolid obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}