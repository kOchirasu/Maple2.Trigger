namespace Maple2.Trigger._52000149_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 111, 112});
                context.SetEffect(arg1: new[] {6001, 6002}, arg2: true);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Sit_Down_A", arg3: 99999999f);
                context.SetNpcEmotionLoop(arg1: 112, arg2: "Event_02_Idle", arg3: 99999999f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest조건체크 : TriggerState {
            internal StateQuest조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001633}, arg3: new byte[] {2})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001633}, arg3: new byte[] {1})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001632}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001632}, arg3: new byte[] {2})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001632}, arg3: new byte[] {1})) {
                    return new State전경_SetupCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001631}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001631}, arg3: new byte[] {2})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001631}, arg3: new byte[] {1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001632}, arg3: new byte[] {1})) {
                    return new State전경_SetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경_SetupCinematic : TriggerState {
            internal State전경_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000149, arg2: 10);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State전경_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경_StartCinematic : TriggerState {
            internal State전경_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000, 8010}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_pc");
                context.SetSceneSkip(arg1: "아노스아파_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_아노스줌인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_아노스줌인 : TriggerState {
            internal StateCamera_아노스줌인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003436, msg: "$52000149_QD__MAIN__0$", duration: 3000);
                context.SetSkip(arg1: "아노스아파_스킵완료");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_아노스줌인01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_아노스줌인01 : TriggerState {
            internal StateCamera_아노스줌인01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_케이틀린01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_케이틀린01 : TriggerState {
            internal StateCamera_케이틀린01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002, 8004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003436, msg: "$52000149_QD__MAIN__1$", duration: 3000);
                context.SetSkip(arg1: "아노스아파_스킵완료");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_케이틀린0102(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_케이틀린0102 : TriggerState {
            internal StateCamera_케이틀린0102(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_케이틀린02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_케이틀린02 : TriggerState {
            internal StateCamera_케이틀린02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 3000f);
                context.AddCinematicTalk(npcId: 11003436, msg: "$52000149_QD__MAIN__2$", duration: 3000);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000149_QD__MAIN__3$", duration: 3000, delayTick: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_katelyn");
                context.SetSkip(arg1: "아노스아파_스킵완료");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State호르헤이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State호르헤이동 : TriggerState {
            internal State호르헤이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Jorge");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 112});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스아파_스킵완료 : TriggerState {
            internal State아노스아파_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000149, arg2: 11);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Jorge");
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
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "AnosReturns");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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