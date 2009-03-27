using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Country object for NHibernate mapped table Country.
    /// </summary>
    [Serializable]
    public class Country : DomainObject<System.Int32>
    {


        private System.String _CountryName;
        private IList<Manufacturer> _Manufacturers = new List<Manufacturer>();
        private IList<Provider> _Providers = new List<Provider>();

        public Country()
        {
        }

        public Country(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String CountryName {
             get { return _CountryName; }
             set { _CountryName = value;}
         }

         public virtual IList<Manufacturer> Manufacturers{
             get { return _Manufacturers; }
             set { _Manufacturers = value; }
         }

         public virtual IList<Provider> Providers{
             get { return _Providers; }
             set { _Providers = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
