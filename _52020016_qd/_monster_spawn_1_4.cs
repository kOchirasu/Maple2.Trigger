using System;

namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_1_4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State체력조건(context);

        private class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "respawn_phase_1", value: 1)) {
                    context.State = new State전투페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투페이즈 : TriggerState {
            internal State전투페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {4000006}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4000006})) {
                    context.State = new State몬스터리젠(context);
                    return;
                }

                if (context.UserValue(key: "respawn_phase_1_end", value: 1)) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터리젠 : TriggerState {
            internal State몬스터리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {4000008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {4000008})) {
                    context.State = new State전투페이즈(context);
                    return;
                }

                if (context.UserValue(key: "respawn_phase_1_end", value: 1)) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {4000006}, arg2: false);
                context.DestroyMonster(arg1: new int[] {4000008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) { }
            }

            public override void OnExit() { }
        }
    }
}