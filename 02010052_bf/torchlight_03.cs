namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 20499, visible: false, initialSequence: "Closed");
                context.SetActor(triggerId: 20501, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{20500}, visible: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetEffect(triggerIds: new []{7002, 7003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new StateBurn_state_01(context);
                }

                if (context.MonsterDead(spawnIds: new []{103})) {
                    return new StateBurn_state_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{71001, 71002, 71003, 71004, 71005}, visible: true);
                context.SetActor(triggerId: 8001, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8002, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8003, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8004, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8005, visible: false, initialSequence: "Dmg_A");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305}, arg2: false);
                context.SetConversation(type: 1, spawnId: 993, script: "$02010052_BF__TORCHLIGHT_03__0$", arg4: 3);
            }
        }

        private class StateBurn_state_01 : TriggerState {
            internal StateBurn_state_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103})) {
                    return new StateBurn_state_complete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7003}, visible: true);
            }
        }

        private class StateBurn_state_02 : TriggerState {
            internal StateBurn_state_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new StateBurn_state_complete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7002}, visible: true);
            }
        }

        private class StateBurn_state_complete : TriggerState {
            internal StateBurn_state_complete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7503}, visible: true);
                context.SetMesh(triggerIds: new []{6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032}, visible: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetConversation(type: 1, spawnId: 9999, script: "$02010052_BF__TORCHLIGHT_03__1$", arg4: 3);
                context.HideGuideSummary(entityId: 200);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_03__2$", duration: 3000);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSpawn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_state : TriggerState {
            internal StateSpawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 299, textId: 20105203);
                context.SetMesh(triggerIds: new []{5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110}, visible: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEffect(triggerIds: new []{7902}, visible: true);
                context.DestroyMonster(spawnIds: new []{9999});
                context.SetActor(triggerId: 8100, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8006, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8007, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8008, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8009, visible: false, initialSequence: "Dmg_A");
                context.SetActor(triggerId: 8010, visible: false, initialSequence: "Dmg_A");
                context.CreateMonster(spawnIds: new []{199, 321, 322, 323, 324, 325}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{199})) {
                    return new StateMonsterkill(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 299);
            }
        }

        private class StateMonsterkill : TriggerState {
            internal StateMonsterkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 20499, visible: true, initialSequence: "Opening");
                context.SetActor(triggerId: 20501, visible: false, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{20500}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
