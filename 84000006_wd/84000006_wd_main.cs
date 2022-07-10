using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_main {
        public class StateReception : TriggerState {
            internal StateReception(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10001, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 10002, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetEffect(triggerIds: new []{3000, 3001, 3002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateEntryDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEntryDelay : TriggerState {
            internal StateEntryDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 40, clearAtZero: true, display: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateOpeningScene_start(context);
                }

                if (context.GetUserCount(boxId: 9000) == 70) {
                    return new StateOpeningScene_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_start : TriggerState {
            internal StateOpeningScene_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.VisibleMyPc(visible: false);
                context.CameraSelectPath(pathIds: new []{5004, 5003}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateOpeningScene_1_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_1_1 : TriggerState {
            internal StateOpeningScene_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{3001}, visible: true);
                context.AddBalloonTalk(spawnId: 101, msg: "$84000006_WD__84000006_WD_MAIN__0$", duration: 3000, delayTick: 500);
                context.AddBalloonTalk(spawnId: 101, msg: "$84000006_WD__84000006_WD_MAIN__1$", duration: 3000, delayTick: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new StateOpeningScene_1_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpeningScene_1_2 : TriggerState {
            internal StateOpeningScene_1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{3001}, visible: true);
                context.AddBalloonTalk(spawnId: 101, msg: "$84000006_WD__84000006_WD_MAIN__2$", duration: 3000, delayTick: 500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateOpeningScene_1_3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{101});
            }
        }

        private class StateOpeningScene_1_3 : TriggerState {
            internal StateOpeningScene_1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(150f, 150f, 150f));
                context.CreateMonster(spawnIds: new []{201}, arg2: false, arg3: 30000);
                context.SetEffect(triggerIds: new []{3002}, visible: true);
                context.AddBalloonTalk(spawnId: 201, msg: "$84000006_WD__84000006_WD_MAIN__3$", duration: 4000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 201, msg: "$84000006_WD__84000006_WD_MAIN__4$", duration: 4000, delayTick: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateGameGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide01 : TriggerState {
            internal StateGameGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.AddBuff(boxIds: new []{9002}, skillId: 99940044, level: 1, arg4: false, arg5: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.VisibleMyPc(visible: true);
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000, script: "$84000006_WD__84000006_WD_MAIN__5$");
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 20000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide02 : TriggerState {
            internal StateGameGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000, script: "$84000006_WD__84000006_WD_MAIN__6$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide03 : TriggerState {
            internal StateGameGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000, script: "$84000006_WD__84000006_WD_MAIN__7$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide04 : TriggerState {
            internal StateGameGuide04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000, script: "$84000006_WD__84000006_WD_MAIN__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide05 : TriggerState {
            internal StateGameGuide05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000, script: "$84000006_WD__84000006_WD_MAIN__9$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameGuide06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide06 : TriggerState {
            internal StateGameGuide06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 2, script: "$84000006_WD__84000006_WD_MAIN__10$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePinata_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Ready : TriggerState {
            internal StatePinata_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1004, key: "Interaction", value: 1);
                context.DestroyMonster(spawnIds: new []{102});
                context.SetMesh(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.StartMiniGame(boxId: 9001, round: 1, isShowResultUI: false, type: MiniGame.WDPinata);
                context.AddBalloonTalk(spawnId: 201, msg: "$84000006_WD__84000006_WD_MAIN__11$", duration: 8000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 28500010, textId: 28500010, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Steal") == 1) {
                    return new StatePinata_Fight(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Fight : TriggerState {
            internal StatePinata_Fight(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000, script: "$84000006_WD__84000006_WD_MAIN__12$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePinata_Fight2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Fight2 : TriggerState {
            internal StatePinata_Fight2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 60, display: true);
                context.SetEventUI(arg1: 1, script: "$84000006_WD__84000006_WD_MAIN__13$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    context.AddBalloonTalk(spawnId: 201, msg: "$84000006_WD__84000006_WD_MAIN__14$", duration: 3000, delayTick: 1000);
                    context.SetTimer(timerId: "4", seconds: 20, clearAtZero: false, display: false);
                    return new StatePinata_Kill(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    context.AddBalloonTalk(spawnId: 201, msg: "$84000006_WD__84000006_WD_MAIN__15$", duration: 3000, delayTick: 1000);
                    context.SetTimer(timerId: "4", seconds: 20, clearAtZero: false, display: false);
                    return new StatePinata_noKill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Kill : TriggerState {
            internal StatePinata_Kill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.1f);
                context.EndMiniGame(winnerBoxId: 9001, type: MiniGame.WDPinata);
                context.AddBuff(boxIds: new []{9001}, skillId: 70000019, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StatePinata_Revive(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_noKill : TriggerState {
            internal StatePinata_noKill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
                context.EndMiniGameRound(winnerBoxId: 9002, expRate: 0.1f);
                context.EndMiniGame(winnerBoxId: 9002, type: MiniGame.WDPinata);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StatePinata_Revive2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Revive : TriggerState {
            internal StatePinata_Revive(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(255f, 255f, 255f));
                context.SetUserValue(triggerId: 1004, key: "Interaction", value: 2);
                context.SetEventUI(arg1: 3, script: "$84000006_WD__84000006_WD_MAIN__16$", duration: 3000, boxId: 9001);
                context.SetEventUI(arg1: 4, script: "$84000006_WD__84000006_WD_MAIN__17$", duration: 3000, notBoxId: 9001);
                context.CreateMonster(spawnIds: new []{101, 103}, arg2: false);
                context.SetEffect(triggerIds: new []{3001}, visible: true);
                context.AddBalloonTalk(spawnId: 101, msg: "$84000006_WD__84000006_WD_MAIN__18$", duration: 5000, delayTick: 100);
                context.AddBalloonTalk(spawnId: 103, msg: "$84000006_WD__84000006_WD_MAIN__19$", duration: 20000, delayTick: 1000);
                context.SetAmbientLight(color: new Vector3(255f, 255f, 255f));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePinata_Fireworks(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Revive2 : TriggerState {
            internal StatePinata_Revive2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(255f, 255f, 255f));
                context.SetUserValue(triggerId: 1004, key: "Interaction", value: 2);
                context.SetEventUI(arg1: 3, script: "$84000006_WD__84000006_WD_MAIN__20$", duration: 3000, boxId: 9002);
                context.SetEventUI(arg1: 4, script: "$84000006_WD__84000006_WD_MAIN__21$", duration: 3000, notBoxId: 9002);
                context.CreateMonster(spawnIds: new []{101, 103}, arg2: false);
                context.SetEffect(triggerIds: new []{3001}, visible: true);
                context.AddBalloonTalk(spawnId: 101, msg: "$84000006_WD__84000006_WD_MAIN__22$", duration: 5000, delayTick: 100);
                context.AddBalloonTalk(spawnId: 103, msg: "$84000006_WD__84000006_WD_MAIN__23$", duration: 20000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePinata_Fireworks(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePinata_Fireworks : TriggerState {
            internal StatePinata_Fireworks(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{5002, 5001}, returnView: true);
                context.SetUserValue(triggerId: 1002, key: "Fireworks", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateFinale(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFinale : TriggerState {
            internal StateFinale(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8022, 8023, 8024}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 10001, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10002, visible: true, enabled: true, minimapVisible: true);
                context.SetUserValue(triggerId: 1001, key: "Conder", value: 1);
                context.AddBuff(boxIds: new []{9002}, skillId: 99940042, level: 1, arg4: false, arg5: true);
                context.SetEventUI(arg1: 1, script: "$84000006_WD__84000006_WD_MAIN__24$", duration: 3000);
                context.SetTimer(timerId: "5", seconds: 150, clearAtZero: false, display: true);
                context.AddBalloonTalk(spawnId: 101, msg: "$84000006_WD__84000006_WD_MAIN__25$", duration: 5000, delayTick: 3000);
                context.AddBalloonTalk(spawnId: 103, msg: "$84000006_WD__84000006_WD_MAIN__26$", duration: 5000, delayTick: 3000);
                context.SetPhotoStudio(isEnable: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateReturn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturn : TriggerState {
            internal StateReturn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.RoomExpire();
                    return new StateEndGame(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndGame : TriggerState {
            internal StateEndGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
