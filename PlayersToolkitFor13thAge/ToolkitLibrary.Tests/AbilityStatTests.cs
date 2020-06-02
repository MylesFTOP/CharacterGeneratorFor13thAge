﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitLibrary;
using Xunit;

namespace ToolkitLibrary.Tests
{
    public class AbilityStatTests
    {
        private static readonly AbilityStat abilityStat = new AbilityStat();

        [Fact]
        public void AbilityStat_ModifierShouldCalculate() {
            int expectedValue = 1;
            int actualValue = abilityStat.CalculateModifier(12);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
