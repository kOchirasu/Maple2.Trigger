using System;

namespace Maple2.Trigger._02000328_bf {
    public static class _event1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "999998")) {
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
                    arg1: new int[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1101, 1102, 1103, 1104, 1105})) {
                    context.State = new State진행3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1, 2}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {3, 4, 5, 6}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {7, 8, 9, 10, 11, 12}, arg2: true, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {13, 14, 15, 16, 17, 18, 19, 20}, arg2: true, arg3: 400, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new int[] {21, 22, 23, 24, 25, 26, 27, 28, 29, 30}, arg2: true, arg3: 500,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42}, arg2: true, arg3: 600,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54}, arg2: true, arg3: 700,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {55, 56, 57, 58, 59, 60, 61, 62, 63, 64}, arg2: true, arg3: 800,
                    arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new int[] {65, 66, 67, 68, 69, 70, 71, 72}, arg2: true, arg3: 900, arg4: 50,
                    arg5: 2f);
                context.SetMesh(arg1: new int[] {73, 74, 75, 76}, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
                context.ShowGuideSummary(entityID: 20003281, textID: 20003281);
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
                context.HideGuideSummary(entityID: 20003281);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}