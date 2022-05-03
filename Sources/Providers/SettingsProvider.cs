using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.L.O.O_.Providers
{
    internal static class SettingsProvider
    {
        private static GameWindowSettings? _gameWindowSettings;
        private static NativeWindowSettings? _nativeWindowSettings;

        public static GameWindowSettings GameWindowSettings { get; set; }
        public static NativeWindowSettings NativeWindowSettings { get; set; }

    }
}
