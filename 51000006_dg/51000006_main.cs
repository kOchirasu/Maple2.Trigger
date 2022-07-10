using System.Numerics;

namespace Maple2.Trigger._51000006_dg {
    public static class _51000006_main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 51000006, portalId: 10);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 610}, visible: false);
                context.SetActor(triggerId: 611, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetActor(triggerId: 612, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetActor(triggerId: 613, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetActor(triggerId: 614, visible: false, initialSequence: "0", arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State인트로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로 : TriggerState {
            internal State인트로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State셋둘하나_스킵완료(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State인트로00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로00 : TriggerState {
            internal State인트로00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003, 8004}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$51000006_DG__51000006_MAIN__0$");
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Walk_A", durationTick: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2600)) {
                    return new State인트로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로01 : TriggerState {
            internal State인트로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005, 8006}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$51000006_DG__51000006_MAIN__1$");
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Event_Bore_A", durationTick: 2900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인트로02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로02 : TriggerState {
            internal State인트로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002, 8001}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$51000006_DG__51000006_MAIN__2$");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Event_Eat_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3100)) {
                    return new State인트로03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로03 : TriggerState {
            internal State인트로03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraSelectPath(pathIds: new []{8003, 8006}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$51000006_DG__51000006_MAIN__3$");
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Attack_01_G", durationTick: 3200);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State게임시작_Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State셋둘하나_스킵완료 : TriggerState {
            internal State셋둘하나_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State게임시작_Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작_Wait : TriggerState {
            internal State게임시작_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "BlackbeanThreeTwoOne_start");
                context.WriteLog(logName: "ThreeTwoOne_log", triggerId: 9000, @event: "char_event", arg5: "BlackbeanThreeTwoOnegamestart");
                context.ArcadeThreeTwoOneStartGame(lifeCount: 5, initScore: 10000);
                context.SetUserValue(triggerId: 4001, key: "Fail", value: 1);
                context.AddBalloonTalk(spawnId: 0, msg: "$51000006_DG__51000006_MAIN__4$", duration: 3000);
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_GetReadyGo_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드Prepare : TriggerState {
            internal State라운드Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601, 602, 603, 604, 610}, visible: false);
                context.SetActor(triggerId: 611, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetActor(triggerId: 612, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetActor(triggerId: 613, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetActor(triggerId: 614, visible: false, initialSequence: "0", arg4: false, arg5: false);
                context.SetPcRotation(rotation: default);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new State완전끝(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State라운드시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드시작 : TriggerState {
            internal State라운드시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 1, textId: 26300736, duration: 3000);
                context.ArcadeThreeTwoOneStartRound(uiDuration: 4, round: 1);
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_ArrowPopup_01");
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new State완전끝(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new State라운드진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드진행 : TriggerState {
            internal State라운드진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$51000006_DG__51000006_MAIN__5$", duration: 1800);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new State01_좌로돌아(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State02_뒤로돌아(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new State03_우로돌아(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State01_좌로돌아 : TriggerState {
            internal State01_좌로돌아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOneResultRound(resultDirection: 1);
                context.SetNpcRotation(spawnId: 101, rotation: 270);
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Turning_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State결과Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State02_뒤로돌아 : TriggerState {
            internal State02_뒤로돌아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOneResultRound(resultDirection: 2);
                context.SetNpcRotation(spawnId: 101, rotation: 180);
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Turning_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State결과Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State03_우로돌아 : TriggerState {
            internal State03_우로돌아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOneResultRound(resultDirection: 3);
                context.SetNpcRotation(spawnId: 101, rotation: 90);
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Turning_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State결과Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결과Cinematic : TriggerState {
            internal State결과Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.InitNpcRotation(spawnIds: new []{101});
                context.SetPcRotation(rotation: default);
                context.SetEffect(triggerIds: new []{601, 602, 603, 604}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ThreeTwoOneResult") == 1) {
                    context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Dance_C_Ride", durationTick: 3300);
                    context.SetPcEmotionLoop(sequenceName: "Emotion_Dance_E", duration: 3300f);
                    context.SetEffect(triggerIds: new []{602, 604}, visible: true);
                    context.AddBalloonTalk(spawnId: 101, msg: "$51000006_DG__51000006_MAIN__6$", duration: 3300);
                    context.AddBalloonTalk(msg: "$51000006_DG__51000006_MAIN__7$", duration: 3300);
                    context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Correct_01");
                    return new State결과정산(context);
                }

                if (context.GetUserValue(key: "ThreeTwoOneResult") == 0) {
                    context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Event_Happy_A", durationTick: 3300);
                    context.SetEffect(triggerIds: new []{601, 603, 610}, visible: true);
                    context.SetActor(triggerId: 611, visible: true, initialSequence: "Run_A");
                    context.SetActor(triggerId: 612, visible: true, initialSequence: "Run_A");
                    context.SetActor(triggerId: 613, visible: true, initialSequence: "Run_A");
                    context.SetActor(triggerId: 614, visible: true, initialSequence: "Run_A");
                    context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Fuss_A"});
                    context.AddBalloonTalk(spawnId: 101, msg: "$51000006_DG__51000006_MAIN__8$", duration: 3300);
                    context.AddBalloonTalk(msg: "$51000006_DG__51000006_MAIN__9$", duration: 3300);
                    context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Wrong_01");
                    return new State결과정산(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결과정산 : TriggerState {
            internal State결과정산(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOneResultRound2(round: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State라운드결과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드결과 : TriggerState {
            internal State라운드결과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOneClearRound(round: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeThreeTwoOneEndGame();
                context.MoveUser(mapId: 51000006, portalId: 44);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State진짜끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진짜끝 : TriggerState {
            internal State진짜끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8010, enable: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Result_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State완전끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완전끝 : TriggerState {
            internal State완전끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
