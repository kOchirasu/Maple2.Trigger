namespace Maple2.Trigger._02000328_bf {
    public static class _event3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {201}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999998})) {
                    context.State = new State진행1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행1 : TriggerState {
            internal State진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State진행2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행2 : TriggerState {
            internal State진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219,
                        220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238,
                        239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257,
                        258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1301, 1302, 1303, 1304, 1305})) {
                    context.State = new State진행3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {201, 202}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {203, 204, 205, 206}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {207, 208, 209, 210, 211, 212}, arg2: true, arg3: 300, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {213, 214, 215, 216, 217, 218, 219, 220}, arg2: true, arg3: 400,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {221, 222, 223, 224, 225, 226, 227, 228, 229, 230}, arg2: true,
                    arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242},
                    arg2: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254},
                    arg2: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, arg2: true,
                    arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {265, 266, 267, 268, 269, 270, 271, 272}, arg2: true, arg3: 900,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {273, 274, 275, 276}, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
                context.ShowGuideSummary(entityId: 20003281, textId: 20003281);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetTimer(arg1: "100", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료2 : TriggerState {
            internal State종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003281);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}