﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Tools.FirmwareFlasher
{
    /// <summary>
    /// Availability of PSRAM.
    /// </summary>
    internal enum PSRamAvailability
    {
        /// <summary>
        /// Availability unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// PSRAM is available.
        /// </summary>
        Yes,

        /// <summary>
        /// PSRAM is not available.
        /// </summary>
        No
    }
}
