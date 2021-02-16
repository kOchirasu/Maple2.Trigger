namespace Maple2.Trigger._02000328_bf {
    public static class _event1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {999998})) {
                    return new State진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행1 : TriggerState {
            internal State진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State진행2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행2 : TriggerState {
            internal State진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1101, 1102, 1103, 1104, 1105})) {
                    return new State진행3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {3, 4, 5, 6}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {7, 8, 9, 10, 11, 12}, arg2: true, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {13, 14, 15, 16, 17, 18, 19, 20}, arg2: true, arg3: 400, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {21, 22, 23, 24, 25, 26, 27, 28, 29, 30}, arg2: true, arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42}, arg2: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54}, arg2: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {55, 56, 57, 58, 59, 60, 61, 62, 63, 64}, arg2: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {65, 66, 67, 68, 69, 70, 71, 72}, arg2: true, arg3: 900, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {73, 74, 75, 76}, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
                context.ShowGuideSummary(entityId: 20003281, textId: 20003281);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetTimer(id: "100", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003281);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}