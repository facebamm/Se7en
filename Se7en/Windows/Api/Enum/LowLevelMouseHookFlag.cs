﻿#if Windows
using System;
using System.Collections.Generic;
using System.Text;

namespace Se7en.Windows.Api.Enum
{
    public enum LowLevelMouseHookFlag
    {
        /// <summary>
        /// Test the event-injected (from any process) flag.
        /// </summary>
        LLMHF_INJECTED = 0x00000001,
        /// <summary>
        /// Test the event-injected (from a process running at lower integrity level) flag.
        /// </summary>
        LLMHF_LOWER_IL_INJECTED = 0x00000002
    }
}
#endif