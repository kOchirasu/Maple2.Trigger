namespace Maple2.Trigger._02000328_bf {
    public static class _event4 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1401, 1402, 1403, 1404, 1405})) {
                    return new State진행3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302}, arg2: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {303, 304, 305, 306}, arg2: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {307, 308, 309, 310, 311, 312}, arg2: true, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {313, 314, 315, 316, 317, 318, 319, 320}, arg2: true, arg3: 400, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {321, 322, 323, 324, 325, 326, 327, 328, 329, 330}, arg2: true, arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342}, arg2: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354}, arg2: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {355, 356, 357, 358, 359, 360, 361, 362, 363, 364}, arg2: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {365, 366, 367, 368, 369, 370, 371, 372}, arg2: true, arg3: 900, arg4: 50, arg5: 2f);
                context.SetMesh(arg1: new[] {373, 374, 375, 376}, arg2: true, arg3: 1000, arg4: 50, arg5: 2f);
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