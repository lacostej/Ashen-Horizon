using System.Runtime.CompilerServices;
using UnityEngine;

[assembly:InternalsVisibleTo("UpliftTesting")]

namespace Uplift
{
    public static class TestingProperties
    {
        public static void SetLogging(bool on)
        {
            Debug.unityLogger.logEnabled = on;
        }
    }
}