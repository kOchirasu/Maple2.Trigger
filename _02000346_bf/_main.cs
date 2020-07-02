namespace Maple2.Trigger._02000346_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 9001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 9002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 9003, arg2: false, arg3: false, arg4: 0);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10000791}, arg2: 0);
                context.SetMesh(arg1: new[] {6001, 6010}, arg2: true);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new StateObjective_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjective_01 : TriggerState {
            internal StateObjective_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateObjective_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjective_02 : TriggerState {
            internal StateObjective_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetProductionUI(arg1: 3, arg2: "$02000346_BF__MAIN1__0$");
                context.SetTimer(arg1: "5", arg2: 5, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000346_BF__MAIN1__2$", stage: 0, count: 3);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
                context.SetMesh(arg1: new[] {6001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 9001, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 9002, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 9003, arg2: true, arg3: true, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetEventUI(arg1: 7, arg2: "$02000346_BF__MAIN1__1$", arg3: 3000);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: true, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {6010}, arg2: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000791}, arg2: 1);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateClear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear_02 : TriggerState {
            internal StateClear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40009);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}