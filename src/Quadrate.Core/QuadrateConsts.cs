using Quadrate.Debugging;

namespace Quadrate
{
    public class QuadrateConsts
    {
        public const string LocalizationSourceName = "Quadrate";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8cad9cd9e6944cdda850d0ce1743a97b";
    }
}
