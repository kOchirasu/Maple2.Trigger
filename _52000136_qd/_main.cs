namespace Maple2.Trigger._52000136_qd {
    public static class _main {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604},
                    arg3: new byte[] {1})) {
                    context.State = new State기본(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001603},
                    arg3: new byte[] {3})) {
                    context.State = new State기본(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001603},
                    arg3: new byte[] {2})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본 : TriggerState {
            internal State기본(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫진입(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫진입 : TriggerState {
            internal State첫진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000136_QD__MAIN__0$", duration: 3000,
                    align: "left");
                context.SetSceneSkip(arg1: "불안한케이틀린_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전경스케치01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치01 : TriggerState {
            internal State전경스케치01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전경스케치02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경스케치02 : TriggerState {
            internal State전경스케치02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.MoveUser(arg1: 52000136, arg2: 10);
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린발견01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린발견01 : TriggerState {
            internal State케이틀린발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "Patrol_101_katelyn_wander");
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__1$", duration: 1000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__2$", duration: 1000,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__3$", duration: 1000,
                    delayTick: 500);
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State케이틀린발견02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린발견02 : TriggerState {
            internal State케이틀린발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000136_QD__MAIN__4$", duration: 3000,
                    align: "left");
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린발견03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린발견03 : TriggerState {
            internal State케이틀린발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__5$", duration: 3000,
                    delayTick: 500);
                context.MoveNpc(arg1: 101, arg2: "Patrol_101_katelyn_run");
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사01 : TriggerState {
            internal State케이틀린대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003261, arg3: "$52000136_QD__MAIN__6$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4300f);
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePC대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대사01 : TriggerState {
            internal StatePC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000136_QD__MAIN__7$", duration: 3000,
                    align: "left");
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사02 : TriggerState {
            internal State케이틀린대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003261, arg3: "$52000136_QD__MAIN__8$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "불안한케이틀린_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State문줌인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문줌인 : TriggerState {
            internal State문줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State불안한케이틀린_스킵완료 : TriggerState {
            internal State불안한케이틀린_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8011}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000136, arg2: 11);
                context.MoveNpc(arg1: 101, arg2: "Patrol_101_katelyn_run");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}