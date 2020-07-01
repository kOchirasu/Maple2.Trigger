using System;

namespace Maple2.Trigger._02100004_bf {
    public static class _npc08 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State소환대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환대기 : TriggerState {
            internal State소환대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999992, key: "NpcSpawned08", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "NpcSpawn08", value: 1)) {
                    context.State = new State소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999992, key: "NpcSpawned08", value: 1);
                context.CreateMonster(arg1: new int[] {2008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}