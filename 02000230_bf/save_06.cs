namespace Maple2.Trigger._02000230_bf {
    public static class _save_06 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{600}, arg2: false);
                context.SetActor(triggerId: 601, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 60601, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 60602, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 60603, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 60604, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 60605, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000358}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000358}, arg2: 0)) {
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
                context.SetConversation(type: 1, spawnId: 600, script: "$02000230_BF__SAVE_06__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 60601, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{60611}, arg2: true);
                context.SetActor(triggerId: 60602, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{60612}, arg2: true);
                context.SetActor(triggerId: 60603, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{60613}, arg2: true);
                context.SetActor(triggerId: 60604, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{60614}, arg2: true);
                context.SetActor(triggerId: 60605, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{60615}, arg2: true);
                context.SetConversation(type: 1, spawnId: 60611, script: "$02000230_BF__SAVE_06__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 60613, script: "$02000230_BF__SAVE_06__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{600});
                context.SetActor(triggerId: 601, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{611}, arg2: false);
                context.SetConversation(type: 1, spawnId: 611, script: "$02000230_BF__SAVE_06__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 611, patrolName: "MS2PatrolData_611_11000688");
                context.SetConversation(type: 1, spawnId: 611, script: "$02000230_BF__SAVE_06__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90611, spawnIds: new []{611})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{611});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{60611, 60612, 60613, 60614, 60615})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{60611, 60612, 60613, 60614, 60615})) {
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
                context.DestroyMonster(spawnIds: new []{60611, 60612, 60613, 60614, 60615});
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
