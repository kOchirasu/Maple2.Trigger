namespace Maple2.Trigger._02000346_bf {
    public static class _triggerwater {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014},
                    arg2: true, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(arg1: "15", arg2: 15);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State발판랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판랜덤 : TriggerState {
            internal State발판랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.SetRandomMesh(
                    arg1: new[]
                        {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014},
                    arg2: false, arg3: 8, arg4: 0, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State유저체크(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    // context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저체크 : TriggerState {
            internal State유저체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {60002})) {
                    context.SetMesh(
                        arg1: new[]
                            {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014},
                        arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    // context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}