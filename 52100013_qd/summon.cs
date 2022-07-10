namespace Maple2.Trigger._52100013_qd {
    public static class _summon {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon") == 1) {
                    return new StateSummon(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSummon : TriggerState {
            internal StateSummon(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{501, 502, 503}, arg2: true);
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon") == 1) {
                    return new StateSummon_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSummon_02 : TriggerState {
            internal StateSummon_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$52100013_QD__SUMMON__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$52100013_QD__SUMMON__1$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{504, 505, 506}, arg2: true);
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon") == 1) {
                    return new StateSummon_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSummon_03 : TriggerState {
            internal StateSummon_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon") == 1) {
                    return new StateSummon(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
