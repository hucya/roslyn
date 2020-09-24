﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.ExtractMethod
{
    internal class ReturnStyle
    {
        public ParameterBehavior ParameterBehavior { get; private set; }
        public ReturnBehavior ReturnBehavior { get; private set; }
        public DeclarationBehavior DeclarationBehavior { get; private set; }

        public static readonly ReturnStyle None =
            new() { ParameterBehavior = ParameterBehavior.None, ReturnBehavior = ReturnBehavior.None, DeclarationBehavior = DeclarationBehavior.None };

        public static readonly ReturnStyle AssignmentWithInput =
            new() { ParameterBehavior = ParameterBehavior.Input, ReturnBehavior = ReturnBehavior.Assignment, DeclarationBehavior = DeclarationBehavior.None };

        public static readonly ReturnStyle AssignmentWithNoInput =
            new() { ParameterBehavior = ParameterBehavior.None, ReturnBehavior = ReturnBehavior.Assignment, DeclarationBehavior = DeclarationBehavior.SplitIn };

        public static readonly ReturnStyle Initialization =
            new() { ParameterBehavior = ParameterBehavior.None, ReturnBehavior = ReturnBehavior.Initialization, DeclarationBehavior = DeclarationBehavior.SplitOut };
    }
}
