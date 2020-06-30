using System;

namespace Maple2.Trigger._02000283_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000427}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000430}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000431}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000432}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000433}, arg2: 2);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new int[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338,
                        339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                context.CreateMonster(arg1: new int[] {1006}, arg2: false);
                context.CreateMonster(arg1: new int[] {1007}, arg2: false);
                context.CreateMonster(arg1: new int[] {1008}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000427}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000427}, arg2: 0)) {
                    context.State = new State엘리트스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트스폰 : TriggerState {
            internal State엘리트스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.ShowGuideSummary(entityID: 20002818, textID: 20002818, durationTime: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetRandomMesh(
                    arg1: new int[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338,
                        339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355
                    }, arg2: false, arg3: 56, arg4: 0, arg5: 30);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.ShowGuideSummary(entityID: 20002813, textID: 20002813);
                    context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                    context.SetMesh(
                        arg1: new int[]
                            {400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416},
                        arg2: true, arg3: 0, arg4: 100, arg5: 0f);
                    context.State = new State소멸대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸대기 : TriggerState {
            internal State소멸대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002813);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}