namespace Maple2.Trigger._52000052_qd {
    public static class _708_darknesstotem_08round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "TotemApp", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TotemApp") == 1) {
                    return new StateTotemApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTotemApp01 : TriggerState {
            internal StateTotemApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2008});
                context.CreateMonster(spawnIds: new []{2308}, arg2: false);
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713}, visible: true, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(spawnIds: new []{924}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJuntaReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaReady01 : TriggerState {
            internal StateJuntaReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2308, script: "$52000052_QD__702_DARKNESSTOTEM_02ROUND__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateJuntaGoUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaGoUp01 : TriggerState {
            internal StateJuntaGoUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2308, patrolName: "MS2PatrolData_2308");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDestoryTotem01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDestoryTotem01 : TriggerState {
            internal StateDestoryTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateJuntaReturn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaReturn01 : TriggerState {
            internal StateJuntaReturn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{924, 2308, 2108});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJuntaReturn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaReturn02 : TriggerState {
            internal StateJuntaReturn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2208}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3708, 3709, 3710, 3711, 3712, 3713}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
