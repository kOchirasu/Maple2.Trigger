namespace Maple2.Trigger._02000426_bf {
    public static class _999109_lavaflow {
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
                if (context.GetUserValue(key: "LavaflowRight") == 1) {
                    return new State오른쪽용암Creation(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오른쪽용암Creation : TriggerState {
            internal State오른쪽용암Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999109, key: "LavaflowRight", value: 0);
                context.SetUserValue(triggerId: 999109, key: "LavaflowRightStop", value: 0);
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CreateMonster(spawnIds: new []{1003}, arg2: false);
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003A");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LavaflowRightStop") == 1) {
                    return new State오른쪽용암내려가기(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오른쪽용암내려가기 : TriggerState {
            internal State오른쪽용암내려가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999109, key: "LavaflowRight", value: 0);
                context.SetUserValue(triggerId: 999109, key: "LavaflowRightStop", value: 0);
                context.MoveNpc(spawnId: 1003, patrolName: "MS2PatrolData_1003C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(spawnIds: new []{1003});
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1003});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
