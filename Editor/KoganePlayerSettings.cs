using System.Linq;
using UnityEditor;

namespace Kogane
{
    public static class KoganePlayerSettings
    {
        public static void SetScriptingDefineSymbolsForGroup
        (
            BuildTargetGroup targetGroup,
            string           defines
        )
        {
            var currentDefines = PlayerSettings
                    .GetScriptingDefineSymbolsForGroup( targetGroup )
                    .Split( ";" )
                    .OrderBy( x => x )
                    .ToArray()
                ;

            var newDefines = defines
                    .Split( ";" )
                    .OrderBy( x => x )
                    .ToArray()
                ;

            if ( currentDefines.SequenceEqual( newDefines ) ) return;

            PlayerSettings.SetScriptingDefineSymbolsForGroup( targetGroup, defines );
        }
    }
}