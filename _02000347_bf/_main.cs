using System;

namespace Maple2.Trigger._02000347_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 9001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 9002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 9003, arg2: false, arg3: false, arg4: 0);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10000787}, arg2: 0);
                context.SetMesh(arg1: new int[] {6001, 6011}, arg2: true);
                context.SetMesh(arg1: new int[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010},
                    arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 60001, arg2: 1)) {
                    context.State = new State오브젝티브_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝티브_01 : TriggerState {
            internal State오브젝티브_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State오브젝티브_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝티브_02 : TriggerState {
            internal State오브젝티브_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.SetProductionUI(arg1: 3, arg2: "$02000347_BF__MAIN1__0$");
                context.SetTimer(arg1: "5", arg2: 5, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State시작_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State시작_01 : TriggerState {
            internal State시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000347_BF__MAIN1__2$", stage: 0, count: 3);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_02 : TriggerState {
            internal State시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 9001, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 9002, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 9003, arg2: true, arg3: true, arg4: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어 : TriggerState {
            internal State클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetEventUI(arg1: 7, arg2: "$02000347_BF__MAIN1__1$", arg3: new int[] {3000});
                context.SetMesh(arg1: new int[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010},
                    arg2: true, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new int[] {6011}, arg2: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000787}, arg2: 1);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State클리어_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어_02 : TriggerState {
            internal State클리어_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 110, textID: 40009);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}