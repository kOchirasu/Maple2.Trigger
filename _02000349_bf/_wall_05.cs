namespace Maple2.Trigger._02000349_bf {
    public static class _wall_05 {
        public class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        35001, 35002, 35003, 35004, 35005, 35006, 35007, 35008, 35009, 35010, 35011, 35012, 35013,
                        35014, 35015, 35016, 35017, 35018, 35019, 35020
                    }, arg2: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new State벽삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        35001, 35002, 35003, 35004, 35005, 35006, 35007, 35008, 35009, 35010, 35011, 35012, 35013,
                        35014, 35015, 35016, 35017, 35018, 35019, 35020
                    }, arg2: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {105})) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벽재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}