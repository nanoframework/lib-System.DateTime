//
// Copyright (c) 2017 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace System.Globalization
{
    /// <summary>
    /// nanoFramework extensions for <see cref="CultureInfo"/> class.
    /// </summary>
    public static class CultureInfoExtensions
    {
        /// <summary>
        /// Gets a DateTimeFormatInfo that defines the culturally appropriate format of displaying dates and times.
        /// </summary>
        /// <value>A DateTimeFormatInfo that defines the culturally appropriate format of displaying dates and times.</value>
        /// <remarks>This extension method is implemented by nanoFrameowrk to replace the property with the same name existing in the <see cref="CultureInfo"/> the full framework version.</remarks>
        public static DateTimeFormatInfo DateTimeFormat(this CultureInfo value)
        {
            return new DateTimeFormatInfo(value);
        }
    }
}
