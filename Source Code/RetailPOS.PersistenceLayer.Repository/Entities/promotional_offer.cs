//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RetailPOS.PersistenceLayer.Repository.Entities
{
    public partial class promotional_offer : EntityBase
    {
        #region Primitive Properties
    
        public virtual long id
        {
            get;
            set;
        }
    
        public virtual string name
        {
            get;
            set;
        }
    
        public virtual string description
        {
            get;
            set;
        }
    
        public virtual System.DateTime start_date
        {
            get;
            set;
        }
    
        public virtual System.DateTime end_date
        {
            get;
            set;
        }
    
        public virtual short purchase_quantity
        {
            get;
            set;
        }
    
        public virtual short pqty_mu
        {
            get { return _pqty_mu; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_pqty_mu != value)
                    {
                        if (measure_unit1 != null && measure_unit1.id != value)
                        {
                            measure_unit1 = null;
                        }
                        _pqty_mu = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private short _pqty_mu;
    
        public virtual Nullable<decimal> offer_quantity
        {
            get;
            set;
        }
    
        public virtual Nullable<short> oqty_mu
        {
            get { return _oqty_mu; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_oqty_mu != value)
                    {
                        if (measure_unit != null && measure_unit.id != value)
                        {
                            measure_unit = null;
                        }
                        _oqty_mu = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<short> _oqty_mu;
    
        public virtual Nullable<decimal> offer_percentage
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual measure_unit measure_unit
        {
            get { return _measure_unit; }
            set
            {
                if (!ReferenceEquals(_measure_unit, value))
                {
                    var previousValue = _measure_unit;
                    _measure_unit = value;
                    Fixupmeasure_unit(previousValue);
                }
            }
        }
        private measure_unit _measure_unit;
    
        public virtual measure_unit measure_unit1
        {
            get { return _measure_unit1; }
            set
            {
                if (!ReferenceEquals(_measure_unit1, value))
                {
                    var previousValue = _measure_unit1;
                    _measure_unit1 = value;
                    Fixupmeasure_unit1(previousValue);
                }
            }
        }
        private measure_unit _measure_unit1;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void Fixupmeasure_unit(measure_unit previousValue)
        {
            if (previousValue != null && previousValue.promotional_offer.Contains(this))
            {
                previousValue.promotional_offer.Remove(this);
            }
    
            if (measure_unit != null)
            {
                if (!measure_unit.promotional_offer.Contains(this))
                {
                    measure_unit.promotional_offer.Add(this);
                }
                if (oqty_mu != measure_unit.id)
                {
                    oqty_mu = measure_unit.id;
                }
            }
            else if (!_settingFK)
            {
                oqty_mu = null;
            }
        }
    
        private void Fixupmeasure_unit1(measure_unit previousValue)
        {
            if (previousValue != null && previousValue.promotional_offer1.Contains(this))
            {
                previousValue.promotional_offer1.Remove(this);
            }
    
            if (measure_unit1 != null)
            {
                if (!measure_unit1.promotional_offer1.Contains(this))
                {
                    measure_unit1.promotional_offer1.Add(this);
                }
                if (pqty_mu != measure_unit1.id)
                {
                    pqty_mu = measure_unit1.id;
                }
            }
        }

        #endregion
    }
}
