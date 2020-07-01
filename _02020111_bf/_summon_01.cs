using System;
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _summon_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1001})) {
                    context.State = new State소환준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환준비 : TriggerState {
            internal State소환준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Summon", value: 1)) {
                    context.State = new State몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900005, key: "Lapenta_Attack_Guide", value: 1);
                context.CreateMonster(arg1: new int[] {111, 112, 113, 114});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State몬스터등장_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2 : TriggerState {
            internal State몬스터등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
            }

            public override void Execute() {
                if (context.UserValue(key: "Summon", value: 0)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}