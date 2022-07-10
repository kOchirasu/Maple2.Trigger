namespace Maple2.Trigger._02000207_bf {
    public static class _999108_lavaflow {
        public class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{2001})) {
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
                if (context.GetUserValue(key: "LavaflowLeft") == 1) {
                    return new State왼쪽용암Creation(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암Creation : TriggerState {
            internal State왼쪽용암Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeftStop", value: 0);
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002A");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LavaflowLeftStop") == 1) {
                    return new State왼쪽용암내려가기(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암내려가기 : TriggerState {
            internal State왼쪽용암내려가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeftStop", value: 0);
                context.MoveNpc(spawnId: 1002, patrolName: "MS2PatrolData_1002C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(spawnIds: new []{1002});
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1002});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
