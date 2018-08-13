namespace CaffeineMode {
    using static Interop.NativeMethods;
    public class Caffeine {
        public bool CaffeineEnabled { get; private set; }

        public Caffeine() {
            this.CaffeineEnabled = false;
        }
        public override bool Equals(object obj) {
            Caffeine caffeine = obj as Caffeine;
            return caffeine != null &&
                   this.CaffeineEnabled == caffeine.CaffeineEnabled;
        }
        public override int GetHashCode() {
            return 2081580759 + this.CaffeineEnabled.GetHashCode();
        }

        /// <summary>
        /// Sets thread state to ES_CONTINUOUS | ES_DISPLAY_REQUIRED
        /// </summary>
        /// <returns>true if thread state change was successful, false otherwise</returns>
        public bool EnableThreadState() {
            EXECUTION_STATE ret = Kernel32_SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);

            if (ret == EXECUTION_STATE.ES_CONTINUOUS) {
                this.CaffeineEnabled = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sets thread state to ES_CONTINUOUS
        /// </summary>
        /// <returns>true if thread state change was successful, false otherwise</returns>
        public bool DisableThreadState() {
            EXECUTION_STATE ret = Kernel32_SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);

            if (ret == (EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED)) {
                this.CaffeineEnabled = false;
                return true;
            }

            return false;
        }
    }
}
