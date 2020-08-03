/*********************************************************
       Code Generated By  .  .  .  .  Delaney's Script Bot
       WWW .  .  .  .  .  .  .  .  .  www.scriptbot.io
       Version.  .  .  .  .  .  .  .  10.0.0.14 
       Build  .  .  .  .  .  .  .  .  20191113 216
       Template Name.  .  .  .  .  .  Project Green 2.0
       Template Version.  .  .  .  .  20200306 002
       Author .  .  .  .  .  .  .  .  Delaney

                      ,        ,--,_
                       \ _ ___/ /\|
                       ( )__, )
                      |/_  '--,
                        \ `  / '
 
 Note: Create this object,
       populate from properties from the Core.Domain classes
       and send to a view.

Object Models
-------------
What can this object do.

* GetUser()
  Two overrides to get the parent user for the object.
  This is used to display parent in a summary table.

* GetModels()
  Return a model containing propeties populated with the objects values

* GetCreatedAndUpdated()
  Two overrides to get Users who created updated this object
  and assign them to CreatedBy and UpdatedBy properties.
 
 *********************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Delaney.Models
{
    public partial class Invoice
    {
        private Delaney.Services.Data.Core.Domain.Invoice _core;
        #region Constructors
        
        // This constructor is used by HTTP posts 
        public Invoice ()
        {
            _core = new Delaney.Services.Data.Core.Domain.Invoice();
        }
        public Invoice(Delaney.Services.Data.Core.Domain.Invoice core)
        {
            _core = core ??   
	        throw new NullReferenceException("The Delaney.Services.Data.Core.Domain.Invoice cannot be null");
        }
        #endregion

        #region Properties
        public Delaney.Services.Data.Core.Domain.Invoice GetCore()
        {
            return _core;
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        #region Id
        [DisplayName("Id")]
        public int? Id
        {
            get
            {
                return _core.Id;
            }
            set
            {
                if (_core.Id != value)
                    _core.Id = value;
            }
        }
        #endregion

        #region Address 1
        [DisplayName("Address 1")]
        public string Address1
        {
            get
            {
                return _core.Address1;
            }
            set
            {
                if (_core.Address1 != value)
                    _core.Address1 = value;
            }
        }
        #endregion

        #region Address 2
        [DisplayName("Address 2")]
        public string Address2
        {
            get
            {
                return _core.Address2;
            }
            set
            {
                if (_core.Address2 != value)
                    _core.Address2 = value;
            }
        }
        #endregion

        #region Address 3
        [DisplayName("Address 3")]
        public string Address3
        {
            get
            {
                return _core.Address3;
            }
            set
            {
                if (_core.Address3 != value)
                    _core.Address3 = value;
            }
        }
        #endregion

        #region Address 4
        [DisplayName("Address 4")]
        public string Address4
        {
            get
            {
                return _core.Address4;
            }
            set
            {
                if (_core.Address4 != value)
                    _core.Address4 = value;
            }
        }
        #endregion

        #region Address 5
        [DisplayName("Address 5")]
        public string Address5
        {
            get
            {
                return _core.Address5;
            }
            set
            {
                if (_core.Address5 != value)
                    _core.Address5 = value;
            }
        }
        #endregion

        #region Country Code
        [DisplayName("Country Code")]
        public string CountryCode
        {
            get
            {
                return _core.CountryCode;
            }
            set
            {
                if (_core.CountryCode != value)
                    _core.CountryCode = value;
            }
        }
        #endregion

        #region Email
        [Required]
        [StringLength(255)]
        [DisplayName("Email")]
        public string Email
        {
            get
            {
                return _core.Email;
            }
            set
            {
                if (_core.Email != value)
                    _core.Email = value;
            }
        }
        #endregion

        #region First Name
        [Required]
        [StringLength(255)]
        [DisplayName("First Name")]
        public string FirstName
        {
            get
            {
                return _core.FirstName;
            }
            set
            {
                if (_core.FirstName != value)
                    _core.FirstName = value;
            }
        }
        #endregion

        #region Last Name
        [Required]
        [StringLength(255)]
        [DisplayName("Last Name")]
        public string LastName
        {
            get
            {
                return _core.LastName;
            }
            set
            {
                if (_core.LastName != value)
                    _core.LastName = value;
            }
        }
        #endregion

        #region Middle Name
        [DisplayName("Middle Name")]
        public string MiddleName
        {
            get
            {
                return _core.MiddleName;
            }
            set
            {
                if (_core.MiddleName != value)
                    _core.MiddleName = value;
            }
        }
        #endregion

        #region Number
        [Required]
        [DisplayName("Number")]
        public int Number
        {
            get
            {
                return _core.Number;
            }
            set
            {
                if (_core.Number != value)
                    _core.Number = value;
            }
        }
        #endregion

        #region PayPal Order ID
        [DisplayName("PayPal Order ID")]
        public string PayPalOrderId
        {
            get
            {
                return _core.PayPalOrderId;
            }
            set
            {
                if (_core.PayPalOrderId != value)
                    _core.PayPalOrderId = value;
            }
        }
        #endregion

        #region PayPal Payer ID
        [DisplayName("PayPal Payer ID")]
        public string PayPalPayerId
        {
            get
            {
                return _core.PayPalPayerId;
            }
            set
            {
                if (_core.PayPalPayerId != value)
                    _core.PayPalPayerId = value;
            }
        }
        #endregion

        #region Post Code
        [DisplayName("Post Code")]
        public string PostCode
        {
            get
            {
                return _core.PostCode;
            }
            set
            {
                if (_core.PostCode != value)
                    _core.PostCode = value;
            }
        }
        #endregion

        #region Prefix
        [DisplayName("Prefix")]
        public string Prefix
        {
            get
            {
                return _core.Prefix;
            }
            set
            {
                if (_core.Prefix != value)
                    _core.Prefix = value;
            }
        }
        #endregion

        #region Suffix
        [DisplayName("Suffix")]
        public string Suffix
        {
            get
            {
                return _core.Suffix;
            }
            set
            {
                if (_core.Suffix != value)
                    _core.Suffix = value;
            }
        }
        #endregion


        #region Fullname Property
        public string Fullname
        {
            get
            {
                string s = FirstName;
                if (!string.IsNullOrEmpty(s)
                && !string.IsNullOrEmpty(LastName))
                    s += " ";

                s += LastName ?? "";

                return s;
            }
        }
        #endregion
      

        #region CreatedDate
        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get
            {
                return _core.CreatedDate;
            }
            set
            {
                if (_core.CreatedDate!= value)
                    _core.CreatedDate = value;
            }
        }
        #endregion

        [DisplayName("Created Date")]
        public string CreatedDateString
        {
            get
            {
                return CreatedDate?.ToString(Delaney.Settings.DateFormatShort);
            }
        }


        [DisplayName("Date")]
        public string DateDisplayed
        {
            get
            {
                return CreatedDate?.ToString("yyyy-MM-dd");
            }
        }

        [DisplayName("Date Time")]
        public string DateTimeDisplayed
        {
            get
            {
                return CreatedDate?.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        #endregion

        #region GUID
        [DisplayName("GUID")]
        public string GUID
        {
            get
            {
                return _core.GUID;
            }
            set
            {
                if (_core.GUID != value)
                    _core.GUID = value;
            }
        }
        #endregion

        public bool IsSelected { get; set; }

        /// <summary>
        /// Create model children and populate them with core children.
        /// </summary>
        //public void PopulateChilden()
        //{
        //}

        /// <summary>
        /// Create model parents and populate them with core parents.
        /// </summary>
//        public void PopulateParents()
//        {

//            if (_core.CreatedBy != null)
//                CreatedBy = (new Models.User(_core.CreatedBy)).ToString();

//            if (_core.User != null)
//                User = new Models.User(_core.User);
//        }



        public bool Validate(Services.Data.Core.IUnitOfWork unitOfWork,
                             out List<string> errors)
        {
            try
            {
                errors = new List<string>();
                bool isValid = true;

                if (unitOfWork == null)
                    throw new NullReferenceException("Services.Data.Core.IUnitOfWork cannot be null");

                if (!isValid)
                    return isValid;

                return isValid;
            }
            catch
            {
                throw;
            }
        }

        public override string ToString()
        {
            return Name;
        }
        #region Name Property
        public string Name
        {
            get
            {
                string s = Number.ToString();

                if (!string.IsNullOrEmpty(s))
                    s = "(" + s + ") ";

                s += FirstName ?? "";

                if (!string.IsNullOrEmpty(s)
                && !string.IsNullOrEmpty(LastName))
                    s += " ";

                s += LastName ?? "";

                return s;
            }
        }
        #endregion
    }
}