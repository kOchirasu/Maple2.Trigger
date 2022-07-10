namespace Maple2.Trigger._02000230_bf {
    public static class _save_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{100}, arg2: false);
                context.SetActor(triggerId: 101, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 10101, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 10102, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 10103, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 10104, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 10105, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000354}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000354}, arg2: 0)) {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000230_BF__SAVE_01__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 10101, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{10111}, arg2: true);
                context.SetActor(triggerId: 10102, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{10112}, arg2: true);
                context.SetActor(triggerId: 10103, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{10113}, arg2: true);
                context.SetActor(triggerId: 10104, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{10114}, arg2: true);
                context.SetActor(triggerId: 10105, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{10115}, arg2: true);
                context.SetConversation(type: 1, spawnId: 10111, script: "$02000230_BF__SAVE_01__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 10113, script: "$02000230_BF__SAVE_01__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{100});
                context.SetActor(triggerId: 101, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.SetConversation(type: 1, spawnId: 111, script: "$02000230_BF__SAVE_01__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_111_11000687");
                context.SetConversation(type: 1, spawnId: 111, script: "$02000230_BF__SAVE_01__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90111, spawnIds: new []{111})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{10111, 10112, 10113, 10114, 10115})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{10111, 10112, 10113, 10114, 10115})) {
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
                context.DestroyMonster(spawnIds: new []{10111, 10112, 10113, 10114, 10115});
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
