using System;

namespace Maple2.Trigger._52100013_qd {
    public static class _summon {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 203903, key: "Summon", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Summon", value: 1)) {
                    context.State = new StateSummon(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSummon : TriggerState {
            internal StateSummon(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {501, 502, 503}, arg2: true);
                context.SetUserValue(triggerID: 203903, key: "Summon", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Summon", value: 1)) {
                    context.State = new StateSummon_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSummon_02 : TriggerState {
            internal StateSummon_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52100013_QD__SUMMON__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52100013_QD__SUMMON__1$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new int[] {504, 505, 506}, arg2: true);
                context.SetUserValue(triggerID: 203903, key: "Summon", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Summon", value: 1)) {
                    context.State = new StateSummon_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSummon_03 : TriggerState {
            internal StateSummon_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 203903, key: "Summon", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Summon", value: 1)) {
                    context.State = new StateSummon(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}