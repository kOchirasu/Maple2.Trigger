namespace Maple2.Trigger._02000390_bf {
    public static class _summon {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {501, 502, 503}, arg2: true);
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000390_BF__SUMMON__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000390_BF__SUMMON__1$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new[] {504, 505, 506}, arg2: true);
                context.SetUserValue(triggerId: 203903, key: "Summon", value: 0);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon") == 1) {
                    return new StateSummon(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}