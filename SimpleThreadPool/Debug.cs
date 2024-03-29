﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleThreadPool
{
    #region Imports

    using System.Diagnostics;
    using SysDebug = System.Diagnostics.Debug;
    using JetBrains.Annotations;

    #endregion

    /// <summary>
    /// Provides methods for assertions and debugging help that is mostly 
    /// applicable during development.
    /// </summary>

    internal sealed class Debug
    {
        [Conditional("DEBUG")]
        [AssertionMethod]
        public static void Assert([AssertionCondition(AssertionConditionType.IS_TRUE)] bool condition)
        {
            SysDebug.Assert(condition);
        }

        [Conditional("DEBUG")]
        public static void AssertStringNotEmpty(string s)
        {
            Assert(s != null);
            Assert(s.Length != 0);
        }

        private Debug() { }
    }

}
