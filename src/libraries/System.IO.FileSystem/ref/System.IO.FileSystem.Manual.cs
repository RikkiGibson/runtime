// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


namespace Microsoft.Win32.SafeHandles
{
    // Members from SafeHandleMinusOneOrZeroIsInvalid needed after removing base
    public sealed partial class SafeFileHandle
    {
        public override bool IsInvalid {[System.Security.SecurityCriticalAttribute]get { return default(bool); } }
    }
}
