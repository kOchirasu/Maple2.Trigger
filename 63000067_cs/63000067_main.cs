namespace Maple2.Trigger._63000067_cs {
    public static class _63000067_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000352}, arg3: new byte[] {1})) {
                    return new State인형찾기(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000352}, arg3: new byte[] {2})) {
                    return new State마리엔의방(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateEnd_일반(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인형찾기 : TriggerState {
            internal State인형찾기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300671, textId: 26300671);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {30000352}, arg3: new byte[] {2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔의방 : TriggerState {
            internal State마리엔의방(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {30000352}, arg3: new byte[] {2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300671);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State암전_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_02 : TriggerState {
            internal State암전_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔Appear_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_01 : TriggerState {
            internal State마리엔Appear_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "스킵종료", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔Appear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_02 : TriggerState {
            internal State마리엔Appear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔Appear_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }
        }

        private class State마리엔Appear_03 : TriggerState {
            internal State마리엔Appear_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Appear_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_04 : TriggerState {
            internal State마리엔Appear_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000067_CS__63000067_MAIN__0$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Appear_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_05 : TriggerState {
            internal State마리엔Appear_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000067_CS__63000067_MAIN__1$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Appear_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_06 : TriggerState {
            internal State마리엔Appear_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Appear_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_07 : TriggerState {
            internal State마리엔Appear_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000067_CS__63000067_MAIN__2$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Appear_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_08 : TriggerState {
            internal State마리엔Appear_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Appear_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_09 : TriggerState {
            internal State마리엔Appear_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000067_CS__63000067_MAIN__3$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔Appear_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Appear_10 : TriggerState {
            internal State마리엔Appear_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000067_CS__63000067_MAIN__4$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_01 : TriggerState {
            internal State마리엔Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new[] {201});
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마리엔Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔Exit_02 : TriggerState {
            internal State마리엔Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                return new StateEnd_Quest(context);
            }

            public override void OnExit() { }
        }

        private class State스킵종료 : TriggerState {
            internal State스킵종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {201});
            }

            public override TriggerState Execute() {
                return new StateEnd_Quest(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd_Quest : TriggerState {
            internal StateEnd_Quest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_일반 : TriggerState {
            internal StateEnd_일반(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}