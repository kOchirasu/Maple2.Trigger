namespace Maple2.Trigger._02000329_bf {
    public static class _bossbattle_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{611}, visible: false);
                context.SetInteractObject(interactIds: new []{10000759}, state: 2);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 211, visible: true, initialSequence: "Closed");
                context.CreateMonster(spawnIds: new []{1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018}, arg2: false);
                context.SetEffect(triggerIds: new []{6811}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{5001})) {
                    return new StateBoss소환(context);
                }

                if (context.MonsterDead(spawnIds: new []{5001, 5002})) {
                    return new State닭장열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss소환 : TriggerState {
            internal StateBoss소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 109, textId: 20000070);
                context.SetSkip(state: new StateBossCombatStart(context));
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{5001, 5002})) {
                    return new State닭장열기(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateBossCombatStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateBossCombatStart : TriggerState {
            internal StateBossCombatStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{5001, 5002})) {
                    return new State닭장열기(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 109);
            }
        }

        private class State닭장열기 : TriggerState {
            internal State닭장열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{611}, visible: true);
                context.SetInteractObject(interactIds: new []{10000759}, state: 1);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 103, textId: 20000050);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000759}, arg2: 0)) {
                    return new StateBossCombatEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 103);
            }
        }

        private class StateBossCombatEnd : TriggerState {
            internal StateBossCombatEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{611}, visible: false);
                context.SetEffect(triggerIds: new []{6811}, visible: true);
                context.SetTimer(timerId: "6", seconds: 6);
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetActor(triggerId: 211, visible: true, initialSequence: "Opened");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State닭장오픈(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 106, type: "trigger", code: "ClearSavetheChicken");
            }
        }

        private class State닭장오픈 : TriggerState {
            internal State닭장오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.DungeonClear();
                context.MoveNpc(spawnId: 1011, patrolName: "MS2PatrolData_1010");
                context.MoveNpc(spawnId: 1012, patrolName: "MS2PatrolData_1009");
                context.MoveNpc(spawnId: 1013, patrolName: "MS2PatrolData_1008");
                context.MoveNpc(spawnId: 1014, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 1015, patrolName: "MS2PatrolData_1006");
                context.MoveNpc(spawnId: 1016, patrolName: "MS2PatrolData_1005");
                context.MoveNpc(spawnId: 1017, patrolName: "MS2PatrolData_1004");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
