namespace Maple2.Trigger._52000141_qd {
    public static class _main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State침대로이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침대로이동 : TriggerState {
            internal State침대로이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52000141, arg2: 10);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_01 : TriggerState {
            internal StateCameraCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Down_Idle_B", arg2: 100000f);
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_02 : TriggerState {
            internal StateCameraCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraCinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic_03 : TriggerState {
            internal StateCameraCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State루아나와알론대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나와알론대화_01 : TriggerState {
            internal State루아나와알론대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State정리(context), arg2: "exit");
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__0$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State루아나와알론대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나와알론대화_02 : TriggerState {
            internal State루아나와알론대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003330, msg: "$52000141_QD__MAIN__1$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003330, msg: "$52000141_QD__MAIN__2$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State루아나와알론대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나와알론대화_03 : TriggerState {
            internal State루아나와알론대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__3$", duration: 2200);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__4$", duration: 2200);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State루아나줌인_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나줌인_01 : TriggerState {
            internal State루아나줌인_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State버즈아이뷰_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버즈아이뷰_01 : TriggerState {
            internal State버즈아이뷰_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루아나워킹_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나워킹_01 : TriggerState {
            internal State루아나워킹_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State알론워킹_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론워킹_01 : TriggerState {
            internal State알론워킹_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_01 : TriggerState {
            internal StateCamera이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다시루아나와알론대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시루아나와알론대화_01 : TriggerState {
            internal State다시루아나와알론대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003330, msg: "$52000141_QD__MAIN__5$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State다시루아나와알론대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시루아나와알론대화_02 : TriggerState {
            internal State다시루아나와알론대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__6$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__7$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6300)) {
                    return new State다시루아나와알론대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시루아나와알론대화_03 : TriggerState {
            internal State다시루아나와알론대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003330, msg: "$52000141_QD__MAIN__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003330, msg: "$52000141_QD__MAIN__9$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6300)) {
                    return new State다시루아나와알론대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시루아나와알론대화_04 : TriggerState {
            internal State다시루아나와알론대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__10$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__11$", duration: 2500);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__12$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State다시루아나와알론대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시루아나와알론대화_05 : TriggerState {
            internal State다시루아나와알론대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003330, msg: "$52000141_QD__MAIN__13$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State다시루아나와알론대화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시루아나와알론대화_06 : TriggerState {
            internal State다시루아나와알론대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__14$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__15$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003328, msg: "$52000141_QD__MAIN__16$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9300)) {
                    return new State알론Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알론Exit_01 : TriggerState {
            internal State알론Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State루아나Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나Exit_01 : TriggerState {
            internal State루아나Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2004");
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State루아나Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나Exit_02 : TriggerState {
            internal State루아나Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State루아나Exit_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State루아나Exit_03 : TriggerState {
            internal State루아나Exit_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 100000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Point_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State우울한PC_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우울한PC_01 : TriggerState {
            internal State우울한PC_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State프레데릭Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭Spawn_01 : TriggerState {
            internal State프레데릭Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State프레데릭Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭Spawn_02 : TriggerState {
            internal State프레데릭Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2005");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State우울한PC_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State우울한PC_02 : TriggerState {
            internal State우울한PC_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State프레데릭Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭Spawn_03 : TriggerState {
            internal State프레데릭Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Think_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State프레데릭과대화_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭과대화_01 : TriggerState {
            internal State프레데릭과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__17$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State프레데릭과대화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭과대화_02 : TriggerState {
            internal State프레데릭과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000141_QD__MAIN__18$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State프레데릭과대화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭과대화_03 : TriggerState {
            internal State프레데릭과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__19$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    return new State프레데릭과대화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭과대화_04 : TriggerState {
            internal State프레데릭과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000141_QD__MAIN__20$", duration: 2500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State프레데릭과대화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레데릭과대화_05 : TriggerState {
            internal State프레데릭과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__21$", duration: 2500);
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__22$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__23$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__24$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__25$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003331, msg: "$52000141_QD__MAIN__26$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new State프리스트의독백_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프리스트의독백_01 : TriggerState {
            internal State프리스트의독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8008, 8006}, arg2: false);
                context.FaceEmotion(spawnPointId: 0, emotionName: "Sit_Ground_Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State프리스트의독백_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프리스트의독백_02 : TriggerState {
            internal State프리스트의독백_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000141_QD__MAIN__27$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State프리스트의독백_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프리스트의독백_03 : TriggerState {
            internal State프리스트의독백_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0);
                context.AddCinematicTalk(npcId: 0, msg: "$52000141_QD__MAIN__28$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {101, 102, 103});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State암전_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전_01 : TriggerState {
            internal State암전_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}