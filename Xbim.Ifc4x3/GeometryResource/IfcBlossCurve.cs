// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometryResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometryResource
{
	[ExpressType("IfcBlossCurve", 1489)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBlossCurve : IfcCurve, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcBlossCurve>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBlossCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _position;
		private IfcPositiveLengthMeasure _curveLength;
		private IfcPositiveLengthMeasure _radius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcAxis2Placement @Position 
		{ 
			get 
			{
				if(_activated) return _position;
				Activate();
				return _position;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _position = v, _position, value,  "Position", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure @CurveLength 
		{ 
			get 
			{
				if(_activated) return _curveLength;
				Activate();
				return _curveLength;
			} 
			set
			{
				SetValue( v =>  _curveLength = v, _curveLength, value,  "CurveLength", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(_activated) return _radius;
				Activate();
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_position = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 1: 
					_curveLength = value.RealVal;
					return;
				case 2: 
					_radius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBlossCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}