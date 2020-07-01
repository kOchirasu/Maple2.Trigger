namespace Maple2.Trigger._02000378_bf {
    public static class _702_darknesstotem_02round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313},
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
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {2302}, arg2: false);
                context.SetMesh(
                    arg1: new[]
                        {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313},
                    arg2: true, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(arg1: new[] {920}, arg2: false);
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
                context.SetConversation(arg1: 1, arg2: 2302, arg3: "$02000378_BF__702_DARKNESSTOTEM_02ROUND__0$",
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
                context.MoveNpc(arg1: 2302, arg2: "MS2PatrolData_2302");
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
                context.CreateMonster(arg1: new[] {2102}, arg2: false);
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
                context.DestroyMonster(arg1: new[] {920});
                context.DestroyMonster(arg1: new[] {2302});
                context.DestroyMonster(arg1: new[] {2102});
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
                context.CreateMonster(arg1: new[] {2202}, arg2: false);
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
                        {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313},
                    arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}