using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that an be blended
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends an object
        /// </summary>
        /// <returns>String containing the blended object</returns>
        string Blend();
    }
}
