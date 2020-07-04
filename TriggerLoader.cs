using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Maple2.Trigger {
    public class TriggerLoader {
        private readonly Dictionary<string, List<Func<ITriggerContext, TriggerState>>> scriptLookup;

        public TriggerLoader() {
            scriptLookup = new Dictionary<string, List<Func<ITriggerContext, TriggerState>>>();

            var assembly = Assembly.GetAssembly(typeof(TriggerLoader));
            foreach (Type type in assembly.GetExportedTypes()) {
                if (!type.IsNested) continue;

                ConstructorInfo constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                    new[] {typeof(ITriggerContext)}, null);

                // No matching constructor for dungeon_common
                if (constructor == null) {
                    continue;
                }

                string key = GetKey(type.Namespace);
                if (!scriptLookup.ContainsKey(key)) {
                    scriptLookup[key] = new List<Func<ITriggerContext, TriggerState>>();
                }

                scriptLookup[key].Add(context => (TriggerState) constructor.Invoke(new object[] {context}));
            }
        }

        public ICollection<Func<ITriggerContext, TriggerState>> GetTriggers(string mapName) {
            if (!scriptLookup.ContainsKey(mapName)) {
                return new Func<ITriggerContext, TriggerState>[0];
            }

            return scriptLookup[mapName];
        }

        private static string GetKey(string @namespace) {
            int start = @namespace.IndexOf('_');
            Debug.Assert(start != -1);
            return @namespace.Substring(start + 1);
        }
    }
}