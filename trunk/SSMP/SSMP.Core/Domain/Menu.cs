using System;
using System.Collections.Generic;

namespace SSMP.Core.Domain
{
    /// <summary>
    /// Menu object for NHibernate mapped table Menu.
    /// </summary>
    [Serializable]
    public class Menu : DomainObject<System.Int32>
    {
        private System.String _MenuName;

        public Menu()
        {

        }

        public Menu(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String MenuName {
             get { return _MenuName; }
             set { _MenuName = value;}
        }
        
        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
     }
}
