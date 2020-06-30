using System;

namespace Maple2.Trigger._52020001_qd {
    public static class _monster_respawn_2_4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State체력조건(context);

        private class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "respawn", value: 1)) {
                    context.State = new State몬스터사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터사망 : TriggerState {
            internal State몬스터사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {6000033})) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {6000033}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State몬스터사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}