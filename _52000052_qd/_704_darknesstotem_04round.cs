namespace Maple2.Trigger._52000052_qd {
    public static class _704_darknesstotem_04round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "TotemApp", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "TotemApp") == 1) {
                    context.State = new StateTotemApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTotemApp01 : TriggerState {
            internal StateTotemApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2004});
                context.CreateMonster(arg1: new[] {2304}, arg2: false);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513}, arg2: true, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(arg1: new[] {922}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJuntaReady01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJuntaReady01 : TriggerState {
            internal StateJuntaReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2304, arg3: "$52000052_QD__702_DARKNESSTOTEM_02ROUND__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateJuntaGoUp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJuntaGoUp01 : TriggerState {
            internal StateJuntaGoUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2304, arg2: "MS2PatrolData_2304");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDestoryTotem01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDestoryTotem01 : TriggerState {
            internal StateDestoryTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2104}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateJuntaReturn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJuntaReturn01 : TriggerState {
            internal StateJuntaReturn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {922, 2304, 2104});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJuntaReturn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJuntaReturn02 : TriggerState {
            internal StateJuntaReturn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3508, 3509, 3510, 3511, 3512, 3513}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}