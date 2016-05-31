// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ActorResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOrganization
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOrganization : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		IfcIdentifier? @Identification { get;  set; }
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IItemSet<IIfcActorRole> @Roles { get; }
		IItemSet<IIfcAddress> @Addresses { get; }
		IEnumerable<IIfcOrganizationRelationship> @IsRelatedBy {  get; }
		IEnumerable<IIfcOrganizationRelationship> @Relates {  get; }
		IEnumerable<IIfcPersonAndOrganization> @Engages {  get; }
	
	}
}

namespace Xbim.Ifc4.ActorResource
{
	[ExpressType("IfcOrganization", 276)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrganization : INotifyPropertyChanged, IInstantiableEntity, IIfcOrganization, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcOrganization>
	{
		#region IIfcOrganization explicit implementation
		IfcIdentifier? IIfcOrganization.Identification { 
 
			get { return @Identification; } 
			set { Identification = value;}
		}	
		IfcLabel IIfcOrganization.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcOrganization.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IItemSet<IIfcActorRole> IIfcOrganization.Roles { 
			get { return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>( @Roles); } 
		}	
		IItemSet<IIfcAddress> IIfcOrganization.Addresses { 
			get { return new Common.Collections.ProxyItemSet<IfcAddress, IIfcAddress>( @Addresses); } 
		}	
		 
		IEnumerable<IIfcOrganizationRelationship> IIfcOrganization.IsRelatedBy {  get { return @IsRelatedBy; } }
		IEnumerable<IIfcOrganizationRelationship> IIfcOrganization.Relates {  get { return @Relates; } }
		IEnumerable<IIfcPersonAndOrganization> IIfcOrganization.Engages {  get { return @Engages; } }
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrganization(IModel model) 		{ 
			Model = model; 
			_roles = new OptionalItemSet<IfcActorRole>( this, 0,  4);
			_addresses = new OptionalItemSet<IfcAddress>( this, 0,  5);
		}

		#region Explicit attribute fields
		private IfcIdentifier? _identification;
		private IfcLabel _name;
		private IfcText? _description;
		private readonly OptionalItemSet<IfcActorRole> _roles;
		private readonly OptionalItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcIdentifier? @Identification 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _identification;
				((IPersistEntity)this).Activate(false);
				return _identification;
			} 
			set
			{
				SetValue( v =>  _identification = v, _identification, value,  "Identification", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 4)]
		public IOptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _roles;
				((IPersistEntity)this).Activate(false);
				return _roles;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 5)]
		public IOptionalItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _addresses;
				((IPersistEntity)this).Activate(false);
				return _addresses;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedOrganizations")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 6)]
		public IEnumerable<IfcOrganizationRelationship> @IsRelatedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganizationRelationship>(e => e.RelatedOrganizations != null &&  e.RelatedOrganizations.Contains(this), "RelatedOrganizations", this);
			} 
		}
		[InverseProperty("RelatingOrganization")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 7)]
		public IEnumerable<IfcOrganizationRelationship> @Relates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganizationRelationship>(e => Equals(e.RelatingOrganization), "RelatingOrganization", this);
			} 
		}
		[InverseProperty("TheOrganization")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, -1, 8)]
		public IEnumerable<IfcPersonAndOrganization> @Engages 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => Equals(e.TheOrganization), "TheOrganization", this);
			} 
		}
		#endregion

		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName, byte propertyOrder)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified, propertyOrder);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_identification = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 4: 
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOrganization other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOrganization
            var root = (@IfcOrganization)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOrganization left, @IfcOrganization right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcOrganization left, @IfcOrganization right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcOrganization left, IfcActorSelect right)
		{
			return left == right as @IfcOrganization;
		}

		public static bool operator !=(@IfcOrganization left, IfcActorSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcOrganization left, IfcObjectReferenceSelect right)
		{
			return left == right as @IfcOrganization;
		}

		public static bool operator !=(@IfcOrganization left, IfcObjectReferenceSelect right)
		{
			return !(left == right);
		}

        public static bool operator ==(@IfcOrganization left, IfcResourceObjectSelect right)
		{
			return left == right as @IfcOrganization;
		}

		public static bool operator !=(@IfcOrganization left, IfcResourceObjectSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Roles)
					yield return entity;
				foreach(var entity in @Addresses)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Addresses)
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