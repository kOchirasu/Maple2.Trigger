using System;

namespace Maple2.Trigger._02020065_bf {
    public static class _battle3_object1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {811}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle3_TurretSpawn_1", value: 1)) {
                    context.State = new State터렛_활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State터렛_활성화 : TriggerState {
            internal State터렛_활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {811}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle3_TurretSpawn_1", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {811})) {
                    context.State = new State터렛_비활성화(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {801})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State터렛_비활성화 : TriggerState {
            internal State터렛_비활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Battle3_TurretSpawn_1", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {801})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {811}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Battle3_TurretSpawn_1", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}