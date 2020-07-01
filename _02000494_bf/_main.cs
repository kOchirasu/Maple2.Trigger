namespace Maple2.Trigger._02000494_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3100, 3200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    context.State = new State전투01(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {1002})) {
                    context.State = new State전투01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105, 106, 107})) {
                    context.State = new State포털개방(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털개방 : TriggerState {
            internal State포털개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3100, 3200}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115},
                    arg2: true, arg3: 0, arg4: 100, arg5: 1f);
                context.SetMesh(
                    arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212},
                    arg2: true, arg3: 0, arg4: 100, arg5: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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