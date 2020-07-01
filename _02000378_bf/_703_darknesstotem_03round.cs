namespace Maple2.Trigger._02000378_bf {
    public static class _703_darknesstotem_03round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.DestroyMonster(arg1: new[] {2003});
                context.CreateMonster(arg1: new[] {2303}, arg2: false);
                context.SetMesh(
                    arg1: new[]
                        {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413},
                    arg2: true, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(arg1: new[] {921}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateJuntaReady01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJuntaReady01 : TriggerState {
            internal StateJuntaReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2303, arg3: "$02000378_BF__703_DARKNESSTOTEM_03ROUND__0$",
                    arg4: 3, arg5: 0);
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
                context.MoveNpc(arg1: 2303, arg2: "MS2PatrolData_2303");
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
                context.CreateMonster(arg1: new[] {2103}, arg2: false);
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
                context.DestroyMonster(arg1: new[] {921});
                context.DestroyMonster(arg1: new[] {2303});
                context.DestroyMonster(arg1: new[] {2103});
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
                context.CreateMonster(arg1: new[] {2203}, arg2: false);
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
                context.SetMesh(
                    arg1: new[]
                        {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413},
                    arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}