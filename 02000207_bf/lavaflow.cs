namespace Maple2.Trigger._02000207_bf {
    public static class _lavaflow {
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
                if (context.GetUserValue(key: "LavaflowHigh") == 1) {
                    return new State3칸분기(context);
                }

                if (context.GetUserValue(key: "LavaflowLow") == 1) {
                    return new State2칸분기(context);
                }

                if (context.GetUserValue(key: "LavaflowLeft") == 1) {
                    return new State왼쪽용암Creation(context);
                }

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

        private class State3칸분기 : TriggerState {
            internal State3칸분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowHigh", value: 0);
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001A");
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 52)) {
                    return new State3칸이동(context);
                }

                if (context.RandomCondition(rate: 48)) {
                    return new State리턴(context);
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

        private class State2칸분기 : TriggerState {
            internal State2칸분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowLow", value: 0);
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false);
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001A");
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 99)) {
                    return new State2칸이동(context);
                }

                if (context.RandomCondition(rate: 1)) {
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
                context.MoveNpc(spawnId: 1001, patrolName: "MS2PatrolData_1001A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
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

        private class State왼쪽용암Creation : TriggerState {
            internal State왼쪽용암Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeftStop", value: 0);
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
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowLeftStop", value: 0);
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

        private class State오른쪽용암Creation : TriggerState {
            internal State오른쪽용암Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999102, key: "LavaflowRight", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowRightStop", value: 0);
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
                context.SetUserValue(triggerId: 999102, key: "LavaflowRight", value: 0);
                context.SetUserValue(triggerId: 999102, key: "LavaflowRightStop", value: 0);
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
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
