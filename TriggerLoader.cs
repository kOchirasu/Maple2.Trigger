using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Maple2.Trigger {
    public class TriggerLoader {
        private readonly Dictionary<string, Dictionary<string, Func<ITriggerContext, TriggerState>>> scriptLookup;

        public TriggerLoader() {
            scriptLookup = new Dictionary<string, Dictionary<string, Func<ITriggerContext, TriggerState>>>();

            var assembly = Assembly.GetAssembly(typeof(TriggerLoader));
            foreach (Type type in assembly.GetExportedTypes()) {
                if (!type.IsNested) continue;

                ConstructorInfo? constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new []{typeof(ITriggerContext)}, null);

                // No matching constructor for dungeon_common
                if (constructor == null || type.Namespace == null) {
                    continue;
                }

                string key = GetKey(type.Namespace);
                if (!scriptLookup.ContainsKey(key)) {
                    scriptLookup[key] = new Dictionary<string, Func<ITriggerContext, TriggerState>>();
                }

                scriptLookup[key].Add(GetKey(type.Name), context => (TriggerState) constructor.Invoke(new object[]{context}));
            }
        }

        public bool TryGetTrigger(string mapName, string scriptName, [NotNullWhen(true)] out Func<ITriggerContext, TriggerState>? func) {
            if (!scriptLookup.ContainsKey(mapName)) {
                func = null;
                return false;
            }

            return scriptLookup[mapName].TryGetValue(scriptName, out func);
        }

        public IReadOnlyDictionary<string, Func<ITriggerContext, TriggerState>> GetTriggerTable(string mapName) {
            if (!scriptLookup.ContainsKey(mapName)) {
                return new Dictionary<string, Func<ITriggerContext, TriggerState>>();
            }

            return scriptLookup[mapName];
        }

        public Func<ITriggerContext, TriggerState>[] GetTriggers(string mapName) {
            if (!scriptLookup.ContainsKey(mapName)) {
                return Array.Empty<Func<ITriggerContext, TriggerState>>();
            }

            return scriptLookup[mapName].Values.ToArray();
        }

        private static string GetKey(string @namespace) {
            int start = @namespace.IndexOf('_');
            Debug.Assert(start != -1);
            return @namespace.Substring(start + 1);
        }
    }
}
