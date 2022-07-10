namespace Maple2.Trigger._02000348_bf {
    public static class _cage_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2103}, visible: false, arg3: 0, arg4: 10);
                context.SetEffect(triggerIds: new []{8003}, visible: false);
                context.SetActor(triggerId: 2203, visible: false, initialSequence: "Sit_Ground_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "cage_03") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2103}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{8003}, visible: true);
                context.SetActor(triggerId: 2203, visible: true, initialSequence: "Sit_Ground_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{213})) {
                    return new StateNpc(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc : TriggerState {
            internal StateNpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8003}, visible: false);
                context.SetMesh(triggerIds: new []{2103}, visible: false, arg3: 0, arg4: 10);
                context.SetActor(triggerId: 2203, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{223}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{223});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
