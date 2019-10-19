using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.AutoImplementedProperties
{
    public class Old
    {
        #region Fields
        /// <summary>
        /// My string
        /// </summary>
        private string myString;

        /// <summary>
        /// Get or set myString
        /// </summary>
        public string MyString
        {
            get { return myString; }
            set { myString = value; }
        }
        #endregion
    }
}