namespace Maple2.Trigger._02100002_bf {
    public static class _02_guidenpcspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GuideNpcSpawn", value: 0);
                context.DestroyMonster(spawnIds: new []{109});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GuideNpcSpawn") == 1) {
                    return new StateNpcSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{109}, arg2: false);
                context.MoveNpc(spawnId: 109, patrolName: "MS2PatrolData_GuideNpc");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new StateCheckUser(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckUser : TriggerState {
            internal StateCheckUser(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{109});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
