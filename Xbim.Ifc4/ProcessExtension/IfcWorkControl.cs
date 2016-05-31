// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWorkControl
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWorkControl : IIfcControl
	{
		IfcDateTime @CreationDate { get;  set; }
		IItemSet<IIfcPerson> @Creators { get; }
		IfcLabel? @Purpose { get;  set; }
		IfcDuration? @Duration { get;  set; }
		IfcDuration? @TotalFloat { get;  set; }
		IfcDateTime @StartTime { get;  set; }
		IfcDateTime? @FinishTime { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IfcWorkControl", 185)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcWorkControl : IfcControl, IIfcWorkControl, IEquatable<@IfcWorkControl>
	{
		#region IIfcWorkControl explicit implementation
		IfcDateTime IIfcWorkControl.CreationDate { 
 
			get { return @CreationDate; } 
			set { CreationDate = value;}
		}	
		IItemSet<IIfcPerson> IIfcWorkControl.Creators { 
			get { return new Common.Collections.ProxyItemSet<IfcPerson, IIfcPerson>( @Creators); } 
		}	
		IfcLabel? IIfcWorkControl.Purpose { 
 
			get { return @Purpose; } 
			set { Purpose = value;}
		}	
		IfcDuration? IIfcWorkControl.Duration { 
 
			get { return @Duration; } 
			set { Duration = value;}
		}	
		IfcDuration? IIfcWorkControl.TotalFloat { 
 
			get { return @TotalFloat; } 
			set { TotalFloat = value;}
		}	
		IfcDateTime IIfcWorkControl.StartTime { 
 
			get { return @StartTime; } 
			set { StartTime = value;}
		}	
		IfcDateTime? IIfcWorkControl.FinishTime { 
 
			get { return @FinishTime; } 
			set { FinishTime = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkControl(IModel model) : base(model) 		{ 
			_creators = new OptionalItemSet<IfcPerson>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcDateTime _creationDate;
		private readonly OptionalItemSet<IfcPerson> _creators;
		private IfcLabel? _purpose;
		private IfcDuration? _duration;
		private IfcDuration? _totalFloat;
		private IfcDateTime _startTime;
		private IfcDateTime? _finishTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 19)]
		public IfcDateTime @CreationDate 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creationDate;
				((IPersistEntity)this).Activate(false);
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 20)]
		public IOptionalItemSet<IfcPerson> @Creators 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _creators;
				((IPersistEntity)this).Activate(false);
				return _creators;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _purpose;
				((IPersistEntity)this).Activate(false);
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcDuration? @Duration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _duration;
				((IPersistEntity)this).Activate(false);
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 23)]
		public IfcDuration? @TotalFloat 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _totalFloat;
				((IPersistEntity)this).Activate(false);
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 24)]
		public IfcDateTime @StartTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _startTime;
				((IPersistEntity)this).Activate(false);
				return _startTime;
			} 
			set
			{
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 25)]
		public IfcDateTime? @FinishTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _finishTime;
				((IPersistEntity)this).Activate(false);
				return _finishTime;
			} 
			set
			{
				SetValue( v =>  _finishTime = v, _finishTime, value,  "FinishTime", 13);
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_creationDate = value.StringVal;
					return;
				case 7: 
					_creators.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_purpose = value.StringVal;
					return;
				case 9: 
					_duration = value.StringVal;
					return;
				case 10: 
					_totalFloat = value.StringVal;
					return;
				case 11: 
					_startTime = value.StringVal;
					return;
				case 12: 
					_finishTime = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkControl other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWorkControl
            var root = (@IfcWorkControl)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWorkControl left, @IfcWorkControl right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcWorkControl left, @IfcWorkControl right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}