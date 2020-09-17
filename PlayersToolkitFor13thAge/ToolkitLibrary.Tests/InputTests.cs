﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ToolkitLibrary.Tests
{
    public class InputTests
    {
        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "3")]
        public void InputHandler_ParseIntShouldReturnBool(bool expectedValue, string input) {
            bool actualValue = InputHandler.ParseInt(input, out int result);
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(false, "a")]
        [InlineData(true, "3")]
        public void InputHandler_ParseUintShouldReturnBool(bool expectedValue, string input) {
            bool actualValue = InputHandler.ParseUint(input, out uint result);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}
