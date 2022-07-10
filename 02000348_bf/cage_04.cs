namespace Maple2.Trigger._02000348_bf {
    public static class _cage_04 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2104}, visible: false, arg3: 0, arg4: 10);
                context.SetEffect(triggerIds: new []{8004}, visible: false);
                context.SetActor(triggerId: 2204, visible: false, initialSequence: "Sit_Ground_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "cage_04") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2104}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{8004}, visible: true);
                context.SetActor(triggerId: 2204, visible: true, initialSequence: "Sit_Ground_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{214})) {
                    return new StateNpc(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc : TriggerState {
            internal StateNpc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8004}, visible: false);
                context.SetMesh(triggerIds: new []{2104}, visible: false, arg3: 0, arg4: 10);
                context.SetActor(triggerId: 2204, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{224}, arg2: true);
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
                context.DestroyMonster(spawnIds: new []{224});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
