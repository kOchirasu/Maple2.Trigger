namespace Maple2.Trigger._02000328_bf {
    public static class _event2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138,
                        139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157,
                        158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1201, 1202, 1203, 1204, 1205})) {
                    context.State = new State진행3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {101, 102}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {103, 104, 105, 106}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {107, 108, 109, 110, 111, 112}, arg2: true, arg3: 300, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new[] {113, 114, 115, 116, 117, 118, 119, 120}, arg2: true, arg3: 400,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128, 129, 130}, arg2: true,
                    arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142},
                    arg2: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154},
                    arg2: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, arg2: true,
                    arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {165, 166, 167, 168, 169, 170, 171, 172}, arg2: true, arg3: 900,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {173, 174, 175, 176}, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
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