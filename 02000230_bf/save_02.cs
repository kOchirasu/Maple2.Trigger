namespace Maple2.Trigger._02000230_bf {
    public static class _save_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 20201, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 20202, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 20203, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 20204, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 20205, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000279}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000279}, arg2: 0)) {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000230_BF__SAVE_02__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 20201, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{20211}, arg2: true);
                context.SetActor(triggerId: 20202, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{20212}, arg2: true);
                context.SetActor(triggerId: 20203, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{20213}, arg2: true);
                context.SetActor(triggerId: 20204, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{20214}, arg2: true);
                context.SetActor(triggerId: 20205, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{20215}, arg2: true);
                context.SetConversation(type: 1, spawnId: 20211, script: "$02000230_BF__SAVE_02__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 20213, script: "$02000230_BF__SAVE_02__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{200});
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{211}, arg2: false);
                context.SetConversation(type: 1, spawnId: 211, script: "$02000230_BF__SAVE_02__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 211, patrolName: "MS2PatrolData_211_11000688");
                context.SetConversation(type: 1, spawnId: 211, script: "$02000230_BF__SAVE_02__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90211, spawnIds: new []{211})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{211});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{20211, 20212, 20213, 20214, 20215})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{20211, 20212, 20213, 20214, 20215})) {
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
                context.DestroyMonster(spawnIds: new []{20211, 20212, 20213, 20214, 20215});
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
