namespace Maple2.Trigger._02000337_bf {
    public static class _boss {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7301, 7302, 7303, 7304, 7305, 7306, 7307, 7308, 7309}, arg2: false);
                context.SetEffect(arg1: new[] {7310}, arg2: true);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
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
                context.CameraSelect(arg1: 8002, arg2: true);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004}, arg2: false, arg4: 0, arg5: 10f);
                context.SetEffect(arg1: new[] {7308}, arg2: true);
                context.SetTimer(id: "2", arg2: 2, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State폭발(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭발 : TriggerState {
            internal State폭발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7306}, arg2: true);
                context.SetSkill(arg1: new[] {8306, 8307}, arg2: true);
                context.SetTimer(id: "2", arg2: 2, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
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
                context.CameraSelect(arg1: 8002, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 111, textId: 20003371);
            }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 112, textId: 20003372);
                context.SetInteractObject(arg1: new[] {10000891}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000891}, arg2: 0)) {
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
                context.CreateMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {202});
                context.SetEffect(arg1: new[] {7301, 7302, 7303, 7304, 7305, 7306, 7307, 7308, 7309, 7310, 7311}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_Dark_Ending_Chord_01");
                context.SetActor(arg1: 5001, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5002, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5003, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5004, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5005, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5006, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5007, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5008, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
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
                context.CreateMonster(arg1: new[] {199});
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11003124, script: "$02000337_BF__BOSS__0$", arg4: 3);
                context.SetSkip(state: new State웨이홍_Script02(context));
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
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
                context.SetConversation(arg1: 2, arg2: 11003124, script: "$02000337_BF__BOSS__1$", arg4: 3);
                context.SetSkip(state: new StateEnd(context));
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
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
                context.SetConversation(arg1: 2, arg2: 11003124, script: "$02000337_BF__BOSS__2$", arg4: 3);
                context.SetSkip(state: new StateEnd(context));
                context.SetTimer(id: "4", arg2: 4, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
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
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000337_BF__BOSS__3$", arg4: 3, arg5: 2);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}