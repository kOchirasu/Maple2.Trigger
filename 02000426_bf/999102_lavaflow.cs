namespace Maple2.Trigger._02000426_bf {
    public static class _999102_lavaflow {
        public class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LavaflowHigh") == 1) {
                    context.SetUserValue(triggerId: 999102, key: "LavaflowHigh", value: 0);
                    return new State3칸이동(context);
                }

                if (context.GetUserValue(key: "LavaflowLow") == 1) {
                    context.SetUserValue(triggerId: 999102, key: "LavaflowLow", value: 0);
                    return new State2칸이동(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3칸이동 : TriggerState {
            internal State3칸이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 28000)) {
                    return new State리턴(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2칸이동 : TriggerState {
            internal State2칸이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State리턴(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리턴 : TriggerState {
            internal State리턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(spawnIds: new []{1001});
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1001});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
