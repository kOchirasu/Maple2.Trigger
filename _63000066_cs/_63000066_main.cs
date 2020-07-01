namespace Maple2.Trigger._63000066_cs {
    public static class _63000066_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 111, 112, 113, 114, 115, 116}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5002, 5003}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000351}, arg3: new byte[] {1})) {
                    return new State서랍장안내(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000351}, arg3: new byte[] {2})) {
                    return new State사다리안내(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State서랍장안내 : TriggerState {
            internal State서랍장안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300661, textId: 26300661);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {30000351}, arg3: new byte[] {2})) {
                    return new State사다리안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사다리안내 : TriggerState {
            internal State사다리안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300661);
                context.ShowGuideSummary(entityId: 26300662, textId: 26300662);
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {703}, arg2: new[] {30000351}, arg3: new byte[] {2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300662);
                context.SetEffect(arg1: new[] {5001, 5002}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
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
                if (context.WaitTick(waitTick: 500)) {
                    return new State마리엔등장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_01 : TriggerState {
            internal State마리엔등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.AddCinematicTalk(npcId: 11004293, msg: "$63000066_CS__63000066_MAIN__0$", duration: 2500, align: "right");
                context.SetSceneSkip(arg1: "스킵종료", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔등장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_02 : TriggerState {
            internal State마리엔등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State마리엔등장_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_03 : TriggerState {
            internal State마리엔등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔등장_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_04 : TriggerState {
            internal State마리엔등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔등장_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_05 : TriggerState {
            internal State마리엔등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004293, msg: "$63000066_CS__63000066_MAIN__1$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔등장_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_06 : TriggerState {
            internal State마리엔등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔등장_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_07 : TriggerState {
            internal State마리엔등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004293, msg: "$63000066_CS__63000066_MAIN__2$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔등장_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_08 : TriggerState {
            internal State마리엔등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State마리엔등장_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_09 : TriggerState {
            internal State마리엔등장_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "Think_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔등장_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_10 : TriggerState {
            internal State마리엔등장_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔등장_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_11 : TriggerState {
            internal State마리엔등장_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004293, msg: "$63000066_CS__63000066_MAIN__3$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔퇴장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_01 : TriggerState {
            internal State마리엔퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new[] {201});
                context.SetEffect(arg1: new[] {5003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마리엔퇴장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_02 : TriggerState {
            internal State마리엔퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State스킵종료 : TriggerState {
            internal State스킵종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.FaceEmotion(spawnPointId: 0);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {201});
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}