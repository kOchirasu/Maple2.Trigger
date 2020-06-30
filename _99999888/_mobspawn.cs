using System;

namespace Maple2.Trigger._99999888 {
    public static class _mobspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 911, arg2: 1)) {
                    context.CreateMonster(arg1: new int[] {101}, arg2: true);
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 50000900, level: 1)) {
                    context.DebugString(@string: "버프가감지되었습니다. 20초 후 삭제합니다");
                    context.State = new State버프삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프삭제 : TriggerState {
            internal State버프삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.DebugString(@string: "버프가 삭제되었습니다.");
                    context.NpcRemoveAdditionalEffect(spawnPointID: 101, additionalEffectID: 50000900);
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