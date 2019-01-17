﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.VisualStudio.IntegrationTest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Roslyn.VisualStudio.IntegrationTests.CSharp
{
    [TestClass]
    public class CSharpErrorListDesktop : CSharpErrorListCommon
    {
        public CSharpErrorListDesktop(VisualStudioInstanceFactory instanceFactory)
            : base(WellKnownProjectTemplates.ClassLibrary)
        {
        }

        [TestMethod, TestProperty(Traits.Feature, Traits.Features.ErrorList)]
        public override void ErrorList()
        {
            base.ErrorList();
        }

        [TestMethod, TestProperty(Traits.Feature, Traits.Features.ErrorList)]
        public override void ErrorLevelWarning()
        {
            base.ErrorLevelWarning();
        }

        [TestMethod, TestProperty(Traits.Feature, Traits.Features.ErrorList)]
        public override void ErrorsDuringMethodBodyEditing()
        {
            base.ErrorsDuringMethodBodyEditing();
        }
    }
}
