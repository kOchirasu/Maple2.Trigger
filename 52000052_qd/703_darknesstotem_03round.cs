namespace Maple2.Trigger._52000052_qd {
    public static class _703_darknesstotem_03round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.DestroyMonster(spawnIds: new []{2003});
                context.CreateMonster(spawnIds: new []{2303}, arg2: false);
                context.SetMesh(triggerIds: new []{3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413}, visible: true, arg3: 0, arg4: 0, arg5: 5f);
                context.CreateMonster(spawnIds: new []{921}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateJuntaReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJuntaReady01 : TriggerState {
            internal StateJuntaReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2303, script: "$52000052_QD__702_DARKNESSTOTEM_02ROUND__0$", arg4: 3, arg5: 0);
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
                context.MoveNpc(spawnId: 2303, patrolName: "MS2PatrolData_2303");
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
                context.CreateMonster(spawnIds: new []{2103}, arg2: false);
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
                context.DestroyMonster(spawnIds: new []{921, 2303, 2103});
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
                context.CreateMonster(spawnIds: new []{2203}, arg2: false);
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
                context.SetMesh(triggerIds: new []{3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
