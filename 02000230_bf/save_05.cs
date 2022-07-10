namespace Maple2.Trigger._02000230_bf {
    public static class _save_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{500}, arg2: false);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 50501, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 50502, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 50503, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 50504, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 50505, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000357}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000357}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 3);
                context.SetConversation(type: 1, spawnId: 500, script: "$02000230_BF__SAVE_05__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 50501, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{50511}, arg2: true);
                context.SetActor(triggerId: 50502, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{50512}, arg2: true);
                context.SetActor(triggerId: 50503, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{50513}, arg2: true);
                context.SetActor(triggerId: 50504, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{50514}, arg2: true);
                context.SetActor(triggerId: 50505, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{50515}, arg2: true);
                context.SetConversation(type: 1, spawnId: 50511, script: "$02000230_BF__SAVE_05__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 50513, script: "$02000230_BF__SAVE_05__2$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State도망과공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망과공격 : TriggerState {
            internal State도망과공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{500});
                context.SetActor(triggerId: 501, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{511}, arg2: false);
                context.SetConversation(type: 1, spawnId: 511, script: "$02000230_BF__SAVE_05__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 511, patrolName: "MS2PatrolData_511_11000689");
                context.SetConversation(type: 1, spawnId: 511, script: "$02000230_BF__SAVE_05__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90511, spawnIds: new []{511})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{511});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{50511, 50512, 50513, 50514, 50515})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{50511, 50512, 50513, 50514, 50515})) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 10);
                context.DestroyMonster(spawnIds: new []{50511, 50512, 50513, 50514, 50515});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
