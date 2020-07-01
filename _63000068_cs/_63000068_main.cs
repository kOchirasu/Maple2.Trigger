namespace Maple2.Trigger._63000068_cs {
    public static class _63000068_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(arg1: new[] {5001, 5002, 5003}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000358}, arg3: new byte[] {3})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000358}, arg3: new byte[] {2})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000358}, arg3: new byte[] {1})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000357}, arg3: new byte[] {3})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000357}, arg3: new byte[] {2})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000357}, arg3: new byte[] {1})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000356}, arg3: new byte[] {3})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000356}, arg3: new byte[] {2})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000356}, arg3: new byte[] {1})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000355}, arg3: new byte[] {3})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000355}, arg3: new byte[] {2})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000355}, arg3: new byte[] {1})) {
                    return new State몬스터등장_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000354}, arg3: new byte[] {3})) {
                    return new State몬스터등장_03(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000354}, arg3: new byte[] {2})) {
                    return new State몬스터등장_02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000354}, arg3: new byte[] {1})) {
                    return new State잠시대기_01(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new State몬스터등장_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시대기_01 : TriggerState {
            internal State잠시대기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State잠시대기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State잠시대기_02 : TriggerState {
            internal State잠시대기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔등장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_01 : TriggerState {
            internal State마리엔등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "마리엔등장_10", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔등장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_02 : TriggerState {
            internal State마리엔등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__0$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔등장_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_03 : TriggerState {
            internal State마리엔등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__1$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔등장_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_04 : TriggerState {
            internal State마리엔등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__2$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔등장_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_05 : TriggerState {
            internal State마리엔등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State마리엔등장_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_06 : TriggerState {
            internal State마리엔등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔등장_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_07 : TriggerState {
            internal State마리엔등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__3$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마리엔등장_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_08 : TriggerState {
            internal State마리엔등장_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__4$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔등장_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔등장_09 : TriggerState {
            internal State마리엔등장_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
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
                context.SetSceneSkip();
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State몬스터등장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_01 : TriggerState {
            internal State몬스터등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔퇴장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_02 : TriggerState {
            internal State몬스터등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State재입장시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_03 : TriggerState {
            internal State몬스터등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State퀘스트마리엔등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_04 : TriggerState {
            internal State몬스터등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_01 : TriggerState {
            internal State마리엔퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔퇴장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_02 : TriggerState {
            internal State마리엔퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__5$", duration: 2000, align: "right");
                context.SetEffect(arg1: new[] {5003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔퇴장_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_03 : TriggerState {
            internal State마리엔퇴장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔퇴장_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔퇴장_04 : TriggerState {
            internal State마리엔퇴장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 26300681, textId: 26300681);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {705}, arg2: new[] {30000354}, arg3: new byte[] {2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재입장시 : TriggerState {
            internal State재입장시(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {705}, arg2: new[] {30000354}, arg3: new byte[] {2})) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300681);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
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
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마리엔재등장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_01 : TriggerState {
            internal State마리엔재등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "재등장연출완료", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마리엔재등장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_02 : TriggerState {
            internal State마리엔재등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마리엔재등장_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_03 : TriggerState {
            internal State마리엔재등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State마리엔재등장_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_04 : TriggerState {
            internal State마리엔재등장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__6$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마리엔재등장_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_05 : TriggerState {
            internal State마리엔재등장_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__7$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔재등장_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_06 : TriggerState {
            internal State마리엔재등장_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__8$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State마리엔재등장_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마리엔재등장_07 : TriggerState {
            internal State마리엔재등장_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004294, msg: "$63000068_CS__63000068_MAIN__9$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State재등장연출완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재등장연출완료 : TriggerState {
            internal State재등장연출완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State퀘스트마리엔등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘스트마리엔등장 : TriggerState {
            internal State퀘스트마리엔등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {203}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {705}, arg2: new[] {30000355}, arg3: new byte[] {1})) {
                    return new State퀘스트마리엔퇴장_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {705}, arg2: new[] {30000355}, arg3: new byte[] {2})) {
                    return new State퀘스트마리엔퇴장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘스트마리엔퇴장_01 : TriggerState {
            internal State퀘스트마리엔퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State퀘스트마리엔퇴장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘스트마리엔퇴장_02 : TriggerState {
            internal State퀘스트마리엔퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {203});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}