namespace Maple2.Trigger._02000230_bf {
    public static class _save_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{400}, arg2: false);
                context.SetActor(triggerId: 401, visible: true, initialSequence: "Emotion_Failure_Idle_A");
                context.SetActor(triggerId: 40401, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 40402, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 40403, visible: true, initialSequence: "Attack_02_A");
                context.SetActor(triggerId: 40404, visible: true, initialSequence: "Attack_Idle_A");
                context.SetActor(triggerId: 40405, visible: true, initialSequence: "Attack_02_A");
            }

            public override TriggerState? Execute() {
                return new State주민구출(context);
            }

            public override void OnExit() { }
        }

        private class State주민구출 : TriggerState {
            internal State주민구출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000356}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000356}, arg2: 0)) {
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
                context.SetConversation(type: 1, spawnId: 400, script: "$02000230_BF__SAVE_04__0$", arg4: 2, arg5: 0);
                context.SetActor(triggerId: 40401, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{40411}, arg2: true);
                context.SetActor(triggerId: 40402, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{40412}, arg2: true);
                context.SetActor(triggerId: 40403, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{40413}, arg2: true);
                context.SetActor(triggerId: 40404, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{40414}, arg2: true);
                context.SetActor(triggerId: 40405, visible: false, initialSequence: "Attack_02_A");
                context.CreateMonster(spawnIds: new []{40415}, arg2: true);
                context.SetConversation(type: 1, spawnId: 40411, script: "$02000230_BF__SAVE_04__1$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 40413, script: "$02000230_BF__SAVE_04__2$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(spawnIds: new []{400});
                context.SetActor(triggerId: 401, visible: false, initialSequence: "Emotion_Failure_Idle_A");
                context.CreateMonster(spawnIds: new []{411}, arg2: false);
                context.SetConversation(type: 1, spawnId: 411, script: "$02000230_BF__SAVE_04__3$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 411, patrolName: "MS2PatrolData_411_11000687");
                context.SetConversation(type: 1, spawnId: 411, script: "$02000230_BF__SAVE_04__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90411, spawnIds: new []{411})) {
                    return new State도망완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망완료 : TriggerState {
            internal State도망완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{411});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{40411, 40412, 40413, 40414, 40415})) {
                    return new StateTriggerReset(context);
                }

                if (!context.MonsterInCombat(spawnIds: new []{40411, 40412, 40413, 40414, 40415})) {
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
                context.DestroyMonster(spawnIds: new []{40411, 40412, 40413, 40414, 40415});
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
