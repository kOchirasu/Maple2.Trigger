namespace Maple2.Trigger._02000230_bf {
    public static class _save_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{300}, arg2: false);
                context.SetActor(triggerId: 301, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 30301, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 30302, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 30303, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 30304, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 30305, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000355}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000355}, arg2: 0)) {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000230_BF__SAVE_03__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 30301, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{30311}, arg2: true);
                context.SetActor(triggerId: 30302, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{30312}, arg2: true);
                context.SetActor(triggerId: 30303, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{30313}, arg2: true);
                context.SetActor(triggerId: 30304, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{30314}, arg2: true);
                context.SetActor(triggerId: 30305, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{30315}, arg2: true);
                context.SetConversation(type: 1, spawnId: 30311, script: "$02000230_BF__SAVE_03__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 30313, script: "$02000230_BF__SAVE_03__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{300});
                context.SetActor(triggerId: 301, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{311}, arg2: false);
                context.SetConversation(type: 1, spawnId: 311, script: "$02000230_BF__SAVE_03__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 311, patrolName: "MS2PatrolData_311_11000689");
                context.SetConversation(type: 1, spawnId: 311, script: "$02000230_BF__SAVE_03__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90311, spawnIds: new []{311})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{311});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{30311, 30312, 30313, 30314, 30315})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{30311, 30312, 30313, 30314, 30315})) {
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
                context.DestroyMonster(spawnIds: new []{30311, 30312, 30313, 30314, 30315});
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
