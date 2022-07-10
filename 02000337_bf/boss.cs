namespace Maple2.Trigger._02000337_bf {
    public static class _boss {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7301, 7302, 7303, 7304, 7305, 7306, 7307, 7308, 7309}, visible: false);
                context.SetEffect(triggerIds: new []{7310}, visible: true);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State폭발예고(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발예고 : TriggerState {
            internal State폭발예고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 8002, enable: true);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004}, visible: false, arg4: 0, arg5: 10f);
                context.SetEffect(triggerIds: new []{7308}, visible: true);
                context.SetTimer(timerId: "2", seconds: 2, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State폭발(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발 : TriggerState {
            internal State폭발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7306}, visible: true);
                context.SetSkill(triggerIds: new []{8306, 8307}, arg2: true);
                context.SetTimer(timerId: "2", seconds: 2, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State폭발후(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State폭발후 : TriggerState {
            internal State폭발후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8002, enable: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 111, textId: 20003371);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State폭발후_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
            }
        }

        private class State폭발후_02 : TriggerState {
            internal State폭발후_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 112, textId: 20003372);
                context.SetInteractObject(interactIds: new []{10000891}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000891}, arg2: 0)) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 112);
            }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202});
                context.SetEffect(triggerIds: new []{7301, 7302, 7303, 7304, 7305, 7306, 7307, 7308, 7309, 7310, 7311}, visible: false);
                context.PlaySystemSoundInBox(sound: "System_Dark_Ending_Chord_01");
                context.SetActor(triggerId: 5001, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5002, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5003, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5004, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5005, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5006, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5007, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5008, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State웨이홍_Script01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }
        }

        private class State웨이홍_Script01 : TriggerState {
            internal State웨이홍_Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{199});
                context.CameraSelect(triggerId: 8001, enable: true);
                context.SetConversation(type: 2, spawnId: 11003124, script: "$02000337_BF__BOSS__0$", arg4: 3);
                context.SetSkip(state: new State웨이홍_Script02(context));
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State웨이홍_Script02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State웨이홍_Script02 : TriggerState {
            internal State웨이홍_Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003124, script: "$02000337_BF__BOSS__1$", arg4: 3);
                context.SetSkip(state: new StateEnd(context));
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State웨이홍_Script03 : TriggerState {
            internal State웨이홍_Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003124, script: "$02000337_BF__BOSS__2$", arg4: 3);
                context.SetSkip(state: new StateEnd(context));
                context.SetTimer(timerId: "4", seconds: 4, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.CameraSelect(triggerId: 8001, enable: false);
                context.SetConversation(type: 1, spawnId: 199, script: "$02000337_BF__BOSS__3$", arg4: 3, arg5: 2);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
