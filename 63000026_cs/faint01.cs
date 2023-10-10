namespace Maple2.Trigger._63000026_cs {
    public static class _faint01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 10000, enabled: false);
                context.SetEffect(triggerIds: new []{5000, 5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5300, 5400, 6000, 6001, 6002, 6003}, visible: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007}, visible: true);
                context.SetAgent(triggerIds: new []{8100, 8101}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000450}, questStates: new byte[]{1})) {
                    return new StateEnter02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter02 : TriggerState {
            internal StateEnter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10033010, textId: 10033010);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateOnTheBridge01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10033010);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107}, visible: false);
            }
        }

        private class StateOnTheBridge01 : TriggerState {
            internal StateOnTheBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 500, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateOnTheBridge02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOnTheBridge02 : TriggerState {
            internal StateOnTheBridge02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000026, portalId: 10, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    return new StateOnTheBridge03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOnTheBridge03 : TriggerState {
            internal StateOnTheBridge03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    return new StateOnTheBridge04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOnTheBridge04 : TriggerState {
            internal StateOnTheBridge04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateTinChaiComeIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn01 : TriggerState {
            internal StateTinChaiComeIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enabled: true);
                context.SetSound(triggerId: 10000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateTinChaiComeIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn02 : TriggerState {
            internal StateTinChaiComeIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000026_CS__FAINT01__5$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateTinChaiComeIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn03 : TriggerState {
            internal StateTinChaiComeIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTinChaiComeIn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn04 : TriggerState {
            internal StateTinChaiComeIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetSceneSkip(state: new StatePCTeleport03(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateTinChaiTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000026_CS__FAINT01__0$", arg4: 5);
                context.SetSkip(state: new StateTinChaiTalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTinChaiTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02 : TriggerState {
            internal StateTinChaiTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTinChaiTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk03 : TriggerState {
            internal StateTinChaiTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001, 5400}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000026_CS__FAINT01__1$", arg4: 3);
                context.CreateMonster(spawnIds: new []{900, 901, 902, 903, 904, 905, 910, 911, 912, 913, 914, 915});
                context.MoveNpc(spawnId: 900, patrolName: "MS2PatrolData_900");
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_901");
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_902");
                context.MoveNpc(spawnId: 903, patrolName: "MS2PatrolData_903");
                context.MoveNpc(spawnId: 904, patrolName: "MS2PatrolData_904");
                context.MoveNpc(spawnId: 905, patrolName: "MS2PatrolData_905");
                context.MoveNpc(spawnId: 910, patrolName: "MS2PatrolData_910");
                context.MoveNpc(spawnId: 911, patrolName: "MS2PatrolData_911");
                context.MoveNpc(spawnId: 912, patrolName: "MS2PatrolData_912");
                context.MoveNpc(spawnId: 913, patrolName: "MS2PatrolData_913");
                context.MoveNpc(spawnId: 914, patrolName: "MS2PatrolData_914");
                context.MoveNpc(spawnId: 915, patrolName: "MS2PatrolData_915");
                context.CameraSelect(triggerId: 600, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDarkShadowApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkShadowApp01 : TriggerState {
            internal StateDarkShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDarkShadowApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkShadowApp02 : TriggerState {
            internal StateDarkShadowApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.MoveUser(mapId: 63000026, portalId: 20, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDarkShadowApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDarkShadowApp03 : TriggerState {
            internal StateDarkShadowApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 602, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle01 : TriggerState {
            internal StateReadyToBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000026_CS__FAINT01__2$", arg4: 5);
                context.SetSkip(state: new StateReadyToBattle02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReadyToBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle02 : TriggerState {
            internal StateReadyToBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelectPath(pathIds: new []{700, 701}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_102");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateReadyToBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle03 : TriggerState {
            internal StateReadyToBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000026, portalId: 30, boxId: 9900);
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000026_CS__FAINT01__3$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateReadyToBattle05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle05 : TriggerState {
            internal StateReadyToBattle05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToBattle06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle06 : TriggerState {
            internal StateReadyToBattle06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 30000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCFaint01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFaint01 : TriggerState {
            internal StatePCFaint01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 702, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCFaint02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFaint02 : TriggerState {
            internal StatePCFaint02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_103");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCFaint03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFaint03 : TriggerState {
            internal StatePCFaint03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000026_CS__FAINT01__4$", arg4: 5);
                context.DestroyMonster(spawnIds: new []{900, 901, 902, 903, 904, 905, 910, 911, 912, 913, 914, 915});
                context.CreateMonster(spawnIds: new []{920, 921, 922}, arg2: false);
                context.SetSkip(state: new StatePCFaint04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCFaint04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFaint04 : TriggerState {
            internal StatePCFaint04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTinChaiGoToFight01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiGoToFight01 : TriggerState {
            internal StateTinChaiGoToFight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 710, enabled: true);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_104");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTinChaiGoToFight02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiGoToFight02 : TriggerState {
            internal StateTinChaiGoToFight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTinChaiGoToFight03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiGoToFight03 : TriggerState {
            internal StateTinChaiGoToFight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCTeleport01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8100, 8101}, visible: true);
                context.CameraSelectPath(pathIds: new []{720, 721}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCTeleport02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCTeleport03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport03 : TriggerState {
            internal StatePCTeleport03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 721, enabled: false);
                context.MoveUser(mapId: 63000027, portalId: 1, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
