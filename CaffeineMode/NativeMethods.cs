using System;
using System.Runtime.InteropServices;

namespace CaffeineMode {
    internal static class NativeMethods {
        [Flags]
        internal enum EXECUTION_STATE : uint {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            //ES_USER_PRESENT = 0x00000004
        };

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern EXECUTION_STATE SetThreadExecutionState([In] EXECUTION_STATE esFlags);

        internal static EXECUTION_STATE ThreadExecutionState(EXECUTION_STATE flags) {
            return SetThreadExecutionState(flags);
        }
    }
}
