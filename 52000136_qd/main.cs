using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000136_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    return new StateDefault(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001603}, arg3: new byte[] {3})) {
                    return new StateDefault(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001603}, arg3: new byte[] {2})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefault : TriggerState {
            internal StateDefault(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫진입(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫진입 : TriggerState {
            internal State첫진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8000}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000136_QD__MAIN__0$", duration: 3000, align: Align.Left);
                context.SetSceneSkip(state: new State불안한케이틀린_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전경스케치01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치01 : TriggerState {
            internal State전경스케치01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8001}, arg2: false);
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치02 : TriggerState {
            internal State전경스케치02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8002}, arg2: false);
                context.MoveUser(arg1: 52000136, arg2: 10);
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린발견01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린발견01 : TriggerState {
            internal State케이틀린발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8003}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "Patrol_101_katelyn_wander");
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__1$", duration: 1000, delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__2$", duration: 1000, delayTick: 500);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__3$", duration: 1000, delayTick: 500);
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State케이틀린발견02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린발견02 : TriggerState {
            internal State케이틀린발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8004}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000136_QD__MAIN__4$", duration: 3000, align: Align.Left);
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린발견03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린발견03 : TriggerState {
            internal State케이틀린발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8004}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000136_QD__MAIN__5$", duration: 3000, delayTick: 500);
                context.MoveNpc(arg1: 101, arg2: "Patrol_101_katelyn_run");
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script01 : TriggerState {
            internal State케이틀린Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003261, script: "$52000136_QD__MAIN__6$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4300f);
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript01 : TriggerState {
            internal StatePCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8005}, arg2: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000136_QD__MAIN__7$", duration: 3000, align: Align.Left);
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script02 : TriggerState {
            internal State케이틀린Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8010}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003261, script: "$52000136_QD__MAIN__8$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State불안한케이틀린_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State문줌인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문줌인 : TriggerState {
            internal State문줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8010, 8011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불안한케이틀린_스킵완료 : TriggerState {
            internal State불안한케이틀린_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8010, 8011}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.MoveUser(arg1: 52000136, arg2: 11);
                context.MoveNpc(arg1: 101, arg2: "Patrol_101_katelyn_run");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}