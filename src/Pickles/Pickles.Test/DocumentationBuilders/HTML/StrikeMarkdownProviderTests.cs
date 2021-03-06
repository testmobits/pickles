﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="StrikeMarkdownProviderTests.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using NFluent;

using NUnit.Framework;

namespace PicklesDoc.Pickles.Test.DocumentationBuilders.HTML
{
    [TestFixture]
    public class StrikeMarkdownProviderTests
    {
        [Test]
        public void ShouldRenderHrAsClosed()
        {
            var strikeMarkdownProvider = new StrikeMarkdownProvider();

            var result = strikeMarkdownProvider.Transform("---");
            var relevantPart = result.Substring(0, 5);

            Check.That(relevantPart).IsEqualTo("<hr/>");
        }
    }
}