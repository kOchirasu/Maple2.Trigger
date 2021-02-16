using System.Numerics;

namespace Maple2.Trigger._51000004_dg {
    public static class _51000004_main {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000004, arg2: 10);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
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
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Walk_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3, arg2: "$51000004_DG__51000004_MAIN__0$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인트로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인트로01 : TriggerState {
            internal State인트로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3, arg2: "$51000004_DG__51000004_MAIN__1$");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3, arg2: "$51000004_DG__51000004_MAIN__2$");
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_01_I_Bore", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3, arg2: "$51000004_DG__51000004_MAIN__3$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State게임시작_Wait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class State셋둘하나_스킵완료 : TriggerState {
            internal State셋둘하나_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.5f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State게임시작_Wait(context);
                }

                if (!context.UserDetected(arg1: new[] {9000})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작_Wait : TriggerState {
            internal State게임시작_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "PinkBeanThreeTwoOne_start");
                context.WriteLog(arg1: "PinkBeanThreeTwoOne_log", arg2: 9000, arg3: "char_event", arg5: "gamestart");
                context.ArcadeThreeTwoOneStartGame(lifeCount: 5, initScore: 10000);
                context.SetUserValue(triggerId: 4001, key: "Fail", value: 1);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$51000004_DG__51000004_MAIN__4$", duration: 3000);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_GetReadyGo_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드Prepare : TriggerState {
            internal State라운드Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9000})) {
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
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_ArrowPopup_01");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9000})) {
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
                context.AddBalloonTalk(spawnPointId: 101, msg: "$51000004_DG__51000004_MAIN__5$", duration: 1800);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new State01_좌로돌아(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new State02_뒤로돌아(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
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
                context.SetNpcRotation(arg1: 101, arg2: 270);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Turning_01");
            }

            public override TriggerState Execute() {
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
                context.SetNpcRotation(arg1: 101, arg2: 180);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Turning_01");
            }

            public override TriggerState Execute() {
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
                context.SetNpcRotation(arg1: 101, arg2: 90);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Turning_01");
            }

            public override TriggerState Execute() {
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
                context.InitNpcRotation(arg1: new[] {101});
                context.SetPcRotation(rotation: new Vector3(0f, 0f, 0f));
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ThreeTwoOneResult") == 1) {
                    context.SetNpcEmotionLoop(arg1: 101, arg2: "Failure_A", arg3: 2700f);
                    context.SetPcEmotionLoop(arg1: "Emotion_Dance_V", arg2: 2450f);
                    context.AddBalloonTalk(spawnPointId: 101, msg: "$51000004_DG__51000004_MAIN__6$", duration: 3000);
                    context.AddBalloonTalk(msg: "$51000004_DG__51000004_MAIN__7$", duration: 3000);
                    context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Correct_01");
                    return new State결과정산(context);
                }

                if (context.GetUserValue(key: "ThreeTwoOneResult") == 0) {
                    context.SetNpcEmotionLoop(arg1: 101, arg2: "Dance_A", arg3: 2700f);
                    context.SetPcEmotionSequence(arg1: "Emotion_Fuss_A");
                    context.AddBalloonTalk(spawnPointId: 101, msg: "$51000004_DG__51000004_MAIN__8$", duration: 3000);
                    context.AddBalloonTalk(msg: "$51000004_DG__51000004_MAIN__9$", duration: 2700);
                    context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Wrong_01");
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.MoveUser(arg1: 51000004, arg2: 44);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 8010, arg2: true);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Result_01");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}