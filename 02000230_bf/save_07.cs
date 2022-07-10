namespace Maple2.Trigger._02000230_bf {
    public static class _save_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{700}, arg2: false);
                context.SetActor(triggerId: 701, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 70701, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 70702, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 70703, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 70704, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 70705, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000359}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000359}, arg2: 0)) {
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
                context.SetConversation(type: 1, spawnId: 700, script: "$02000230_BF__SAVE_07__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 70701, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{70711}, arg2: true);
                context.SetActor(triggerId: 70702, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{70712}, arg2: true);
                context.SetActor(triggerId: 70703, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{70713}, arg2: true);
                context.SetActor(triggerId: 70704, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{70714}, arg2: true);
                context.SetActor(triggerId: 70705, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{70715}, arg2: true);
                context.SetConversation(type: 1, spawnId: 70711, script: "$02000230_BF__SAVE_07__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 70713, script: "$02000230_BF__SAVE_07__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{700});
                context.SetActor(triggerId: 701, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{711}, arg2: false);
                context.SetConversation(type: 1, spawnId: 711, script: "$02000230_BF__SAVE_07__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 711, patrolName: "MS2PatrolData_711_11000687");
                context.SetConversation(type: 1, spawnId: 711, script: "$02000230_BF__SAVE_07__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90711, spawnIds: new []{711})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{711});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{70711, 70712, 70713, 70714, 70715})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{70711, 70712, 70713, 70714, 70715})) {
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
                context.DestroyMonster(spawnIds: new []{70711, 70712, 70713, 70714, 70715});
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
