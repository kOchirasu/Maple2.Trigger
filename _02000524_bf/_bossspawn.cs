namespace Maple2.Trigger._02000524_bf {
    public static class _bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State난이도별보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도별보스등장 : TriggerState {
            internal State난이도별보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonId() == 23046003) {
                    return new State일반난이도_보스등장(context);
                }

                if (context.GetDungeonId() == 23047003) {
                    return new State어려움난이도_보스등장(context);
                }

                if (context.WaitTick(waitTick: 1100)) {
                    return new State일반난이도_보스등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일반난이도_보스등장 : TriggerState {
            internal State일반난이도_보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {98}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {98})) {
                    return new State클리어처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려움난이도_보스등장 : TriggerState {
            internal State어려움난이도_보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {99}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State클리어처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클리어처리 : TriggerState {
            internal State클리어처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.DungeonClear();
                    return new State종료처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료처리 : TriggerState {
            internal State종료처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}