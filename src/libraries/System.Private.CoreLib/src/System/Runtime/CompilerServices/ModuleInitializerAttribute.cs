// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Used to indicate to the compiler that a method should be called
    /// in its containing module's initializer. When one or more valid methods
    /// with this attribute are found in a compilation, the compiler will
    /// emit a `<Module>..cctor` which calls the attributed methods
    /// in the order they appear in source.
    ///
    /// Certain requirements are imposed on any method targeted with this attribute:
    /// - The method must be `static`.
    /// - The method must be an ordinary member method, as opposed to a property accessor, constructor, local function, etc.
    /// - The method must be parameterless.
    /// - The method must return `void`.
    /// - The method must not be generic or be contained in a generic type.
    /// - The method must be accessible from the `<Module>` class.
    ///   - This means the method's effective accessibility must be `internal` or `public`.
    /// </summary>
    /// <remarks>
    /// The specification for module initializers in the .NET runtime can be found here:
    /// https://github.com/dotnet/runtime/blob/master/docs/design/specs/Ecma-335-Augments.md#module-initializer
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class ModuleInitializerAttribute : Attribute
    {
        public ModuleInitializerAttribute()
        {
        }
    }
}
