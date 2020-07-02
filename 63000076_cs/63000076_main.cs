namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(arg1: new[] {105, 106, 107, 118, 119}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: true);
                context.SetMesh(arg1: new[] {4005, 4006, 4007, 4008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000375}, arg3: new byte[] {2})) {
                    return new State보Boss발소리_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000375}, arg3: new byte[] {1})) {
                    return new StateWait_01(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State요정잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_01 : TriggerState {
            internal State요정잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "요정잡담종료_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State요정잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_02 : TriggerState {
            internal State요정잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 103, msg: "$63000076_CS__63000076_MAIN__0$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_03 : TriggerState {
            internal State요정잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "$63000076_CS__63000076_MAIN__1$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_04 : TriggerState {
            internal State요정잡담_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State요정잡담_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_05 : TriggerState {
            internal State요정잡담_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 105, msg: "$63000076_CS__63000076_MAIN__2$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_06 : TriggerState {
            internal State요정잡담_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 107, msg: "$63000076_CS__63000076_MAIN__3$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_07 : TriggerState {
            internal State요정잡담_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State요정잡담_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_08 : TriggerState {
            internal State요정잡담_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 112, msg: "$63000076_CS__63000076_MAIN__4$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_09 : TriggerState {
            internal State요정잡담_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 113, msg: "$63000076_CS__63000076_MAIN__5$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State요정잡담_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담_10 : TriggerState {
            internal State요정잡담_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 114, msg: "$63000076_CS__63000076_MAIN__6$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State요정잡담종료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State요정잡담종료_01 : TriggerState {
            internal State요정잡담종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State요정잡담종료_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
            }
        }

        private class State요정잡담종료_02 : TriggerState {
            internal State요정잡담종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708}, arg2: new[] {30000375}, arg3: new byte[] {2})) {
                    return new State보Boss발소리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_01 : TriggerState {
            internal State보Boss발소리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss발소리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_02 : TriggerState {
            internal State보Boss발소리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 202, 203, 204, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217});
                context.MoveUser(arg1: 63000076, arg2: 1);
                context.SetSceneSkip(arg1: "연출종료_01", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보Boss발소리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_03 : TriggerState {
            internal State보Boss발소리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, msg: "$63000076_CS__63000076_MAIN__7$", duration: 2000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보Boss발소리_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보Boss발소리_04 : TriggerState {
            internal State보Boss발소리_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, msg: "$63000076_CS__63000076_MAIN__8$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보BossSpawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_01 : TriggerState {
            internal State보BossSpawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.CreateMonster(arg1: new[] {141, 142}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
                context.SetMesh(arg1: new[] {4005, 4006, 4007, 4008}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보BossSpawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_02 : TriggerState {
            internal State보BossSpawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossSpawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_03 : TriggerState {
            internal State보BossSpawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 106, msg: "$63000076_CS__63000076_MAIN__9$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State보BossSpawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_04 : TriggerState {
            internal State보BossSpawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 111, msg: "$63000076_CS__63000076_MAIN__10$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보BossSpawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_05 : TriggerState {
            internal State보BossSpawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, msg: "$63000076_CS__63000076_MAIN__11$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State보BossSpawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_06 : TriggerState {
            internal State보BossSpawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004, 8006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보BossSpawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_07 : TriggerState {
            internal State보BossSpawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 142, msg: "$63000076_CS__63000076_MAIN__12$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State보BossSpawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_08 : TriggerState {
            internal State보BossSpawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000076_CS__63000076_MAIN__13$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State보BossSpawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_09 : TriggerState {
            internal State보BossSpawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State보BossSpawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보BossSpawn_10 : TriggerState {
            internal State보BossSpawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000076_CS__63000076_MAIN__14$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State사라진케이크_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State사라진케이크_01 : TriggerState {
            internal State사라진케이크_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State사라진케이크_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사라진케이크_02 : TriggerState {
            internal State사라진케이크_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, msg: "$63000076_CS__63000076_MAIN__15$", duration: 2500, align: "right");
                context.SetMesh(arg1: new[] {4005, 4006, 4007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State사라진케이크_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사라진케이크_03 : TriggerState {
            internal State사라진케이크_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004375, msg: "$63000076_CS__63000076_MAIN__16$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State사라진케이크_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119});
            }
        }

        private class State사라진케이크_04 : TriggerState {
            internal State사라진케이크_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000076_CS__63000076_MAIN__17$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State사라진케이크_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State사라진케이크_05 : TriggerState {
            internal State사라진케이크_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Appear_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_01 : TriggerState {
            internal State미아Appear_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Appear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_02 : TriggerState {
            internal State미아Appear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, msg: "$63000076_CS__63000076_MAIN__18$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Appear_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_03 : TriggerState {
            internal State미아Appear_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, msg: "$63000076_CS__63000076_MAIN__19$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Appear_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_04 : TriggerState {
            internal State미아Appear_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004372, msg: "$63000076_CS__63000076_MAIN__20$", duration: 3000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Appear_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_05 : TriggerState {
            internal State미아Appear_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 141, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Appear_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_06 : TriggerState {
            internal State미아Appear_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Appear_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_07 : TriggerState {
            internal State미아Appear_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {141});
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
                context.MoveUser(arg1: 63000076, arg2: 2);
                context.MoveNpc(arg1: 142, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Appear_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_08 : TriggerState {
            internal State미아Appear_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미아Appear_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_09 : TriggerState {
            internal State미아Appear_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, msg: "$63000076_CS__63000076_MAIN__21$", duration: 3000, illustId: "Mia_annoyed", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Appear_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_10 : TriggerState {
            internal State미아Appear_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000076_CS__63000076_MAIN__22$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Appear_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_11 : TriggerState {
            internal State미아Appear_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, msg: "$63000076_CS__63000076_MAIN__23$", duration: 2500, illustId: "Mia_annoyed", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Appear_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_12 : TriggerState {
            internal State미아Appear_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000076_CS__63000076_MAIN__24$", duration: 3500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State미아Appear_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_13 : TriggerState {
            internal State미아Appear_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, msg: "$63000076_CS__63000076_MAIN__25$", duration: 3000, illustId: "Mia_normal", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Appear_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_14 : TriggerState {
            internal State미아Appear_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$63000076_CS__63000076_MAIN__26$", duration: 2500, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State미아Appear_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_15 : TriggerState {
            internal State미아Appear_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004364, msg: "$63000076_CS__63000076_MAIN__27$", duration: 3000, illustId: "Mia_annoyed", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미아Appear_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_16 : TriggerState {
            internal State미아Appear_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State미아Appear_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_17 : TriggerState {
            internal State미아Appear_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new[] {142});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State미아Appear_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미아Appear_18 : TriggerState {
            internal State미아Appear_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic_01 : TriggerState {
            internal StateStopCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic_02 : TriggerState {
            internal StateStopCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4001, 4002, 4003, 4004, 4005, 4006, 4007}, arg2: false);
                context.SetMesh(arg1: new[] {4008}, arg2: true);
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 141, 142});
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic_03 : TriggerState {
            internal StateStopCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}