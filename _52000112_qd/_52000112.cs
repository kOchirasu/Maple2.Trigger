using System;

namespace Maple2.Trigger._52000112_qd {
    public static class _52000112 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSTART(context);

        private class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetActor(arg1: 231, arg2: true, arg3: "Closed");
                context.SetEffect(arg1: new int[] {400}, arg2: false);
                context.SetEffect(arg1: new int[] {401}, arg2: false);
                context.SetEffect(arg1: new int[] {402}, arg2: false);
                context.SetEffect(arg1: new int[] {403}, arg2: false);
                context.SetEffect(arg1: new int[] {404}, arg2: false);
                context.SetEffect(arg1: new int[] {405}, arg2: false);
                context.SetEffect(arg1: new int[] {406}, arg2: false);
                context.SetEffect(arg1: new int[] {407}, arg2: false);
                context.SetMesh(arg1: new int[] {300, 301, 302, 303, 304, 305, 306, 307}, arg2: true, arg3: 0,
                    arg4: 1000, arg5: 1000f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002306},
                    arg3: new byte[] {2})) {
                    context.State = new State재즈바1층습격_완료가능01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002306},
                    arg3: new byte[] {1})) {
                    context.State = new State재즈바1층습격_진행중01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002308},
                    arg3: new byte[] {2})) {
                    context.State = new State재즈바_지하습격_완료가능01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002313},
                    arg3: new byte[] {2})) {
                    context.State = new State쉐도우클로전투_완료연출01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002311},
                    arg3: new byte[] {3})) {
                    context.State = new State재즈바_지하습격_완료가능01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002308},
                    arg3: new byte[] {3})) {
                    context.State = new State재즈바_지하습격_완료가능01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002306},
                    arg3: new byte[] {3})) {
                    context.State = new State재즈바1층습격_완료가능01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_진행중01 : TriggerState {
            internal State재즈바1층습격_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeID: new int[] {102, 103, 104, 105, 106, 107}, isAutoTargeting: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002306},
                    arg3: new byte[] {2})) {
                    context.State = new State재즈바1층습격_완료가능01_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능01_b : TriggerState {
            internal State재즈바1층습격_완료가능01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000112_QD__52000112__0$", duration: 6000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State재즈바1층습격_완료가능01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능01 : TriggerState {
            internal State재즈바1층습격_완료가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State재즈바1층습격_완료가능02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능02 : TriggerState {
            internal State재즈바1층습격_완료가능02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.DestroyMonster(arg1: new int[] {102, 103, 104, 105, 106, 107});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State재즈바1층습격_완료가능03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바1층습격_완료가능03 : TriggerState {
            internal State재즈바1층습격_완료가능03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_shadowClawMove");
                context.AddBalloonTalk(spawnPointID: 111, msg: "$52000112_QD__52000112__1$", duration: 6000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002308},
                    arg3: new byte[] {1})) {
                    context.State = new State재즈바_지하습격_진행중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_진행중01 : TriggerState {
            internal State재즈바_지하습격_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
                context.SetActor(arg1: 231, arg2: true, arg3: "Opened");
                context.CreateMonster(arg1: new int[] {200, 209, 204, 205, 210, 206}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002308},
                    arg3: new byte[] {2})) {
                    context.State = new State재즈바_지하습격_완료가능01_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능01_b : TriggerState {
            internal State재즈바_지하습격_완료가능01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000112_QD__52000112__2$", duration: 6000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State재즈바_지하습격_완료가능01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능01 : TriggerState {
            internal State재즈바_지하습격_완료가능01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 20, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State재즈바_지하습격_완료가능02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능02 : TriggerState {
            internal State재즈바_지하습격_완료가능02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(arg1: new int[] {208}, arg2: false);
                context.CreateMonster(arg1: new int[] {201, 202, 203}, arg2: false);
                context.CreateMonster(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219}, arg2: false);
                context.DestroyMonster(arg1: new int[] {108, 109, 110, 111, 200, 209, 204, 205, 210, 206});
                context.MoveUser(arg1: 52000112, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State재즈바_지하습격_완료가능03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재즈바_지하습격_완료가능03 : TriggerState {
            internal State재즈바_지하습격_완료가능03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002311},
                    arg3: new byte[] {3})) {
                    context.State = new StatePC_로그스거역_진행중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC_로그스거역_진행중01 : TriggerState {
            internal StatePC_로그스거역_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 211, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 212, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 213, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 214, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 215, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 216, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 217, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 218, arg2: "Attack_Idle_A", arg3: 15000f);
                context.SetNpcEmotionLoop(arg1: 219, arg2: "Attack_Idle_A", arg3: 15000f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002312},
                    arg3: new byte[] {3})) {
                    context.State = new StatePC_로그스거역_대원들01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002312},
                    arg3: new byte[] {2})) {
                    context.State = new StatePC_로그스거역_대원들01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002312},
                    arg3: new byte[] {1})) {
                    context.State = new StatePC_로그스거역_대원들01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC_로그스거역_대원들01 : TriggerState {
            internal StatePC_로그스거역_대원들01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219});
                context.CreateMonster(arg1: new int[] {220, 221, 222, 223, 224, 225, 226, 227, 228}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002313},
                    arg3: new byte[] {1})) {
                    context.State = new State쉐도우클로전투_진행중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_진행중01 : TriggerState {
            internal State쉐도우클로전투_진행중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {211, 212, 213, 214, 215, 216, 217, 218, 219});
                context.DestroyMonster(arg1: new int[] {220, 221, 222, 223, 224, 225, 226, 227, 228});
                context.SetSound(arg1: 9000, arg2: true);
                context.DestroyMonster(arg1: new int[] {208});
                context.CreateMonster(arg1: new int[] {229}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002313},
                    arg3: new byte[] {2})) {
                    context.State = new State쉐도우클로전투_완료연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출01 : TriggerState {
            internal State쉐도우클로전투_완료연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9000, arg2: false);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {207});
                context.CreateMonster(arg1: new int[] {208}, arg2: false);
                context.MoveUser(arg1: 52000112, arg2: 3);
                context.SetNpcEmotionLoop(arg1: 208, arg2: "Attack_Idle_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Sit_Down_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Sit_Down_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Sit_Down_A", arg3: 17500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State쉐도우클로전투_완료연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출02 : TriggerState {
            internal State쉐도우클로전투_완료연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "쉐도우클로전투_완료연출09", arg2: "exit");
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CameraSelectPath(arg1: new int[] {3000, 3001}, arg2: 0);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 5000f);
                context.FaceEmotion(spawnPointID: 0, emotionName: "PC_Pain_86000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State쉐도우클로전투_완료연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출03 : TriggerState {
            internal State쉐도우클로전투_완료연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3002, 3003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003185, illustID: "0", msg: "$52000112_QD__52000112__3$",
                    duration: 5000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State쉐도우클로전투_완료연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출04 : TriggerState {
            internal State쉐도우클로전투_완료연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, illustID: "0", msg: "$52000112_QD__52000112__4$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State쉐도우클로전투_완료연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출05 : TriggerState {
            internal State쉐도우클로전투_완료연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 5.5f, interpolator: 2);
                context.CameraSelectPath(arg1: new int[] {3004}, arg2: 0);
                context.SetPcEmotionSequence(arg1: "Assassin_DarkSight_A");
                context.SetPcEmotionLoop(arg1: "Assassin_DarkSight_A", arg2: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State쉐도우클로전투_완료연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출06 : TriggerState {
            internal State쉐도우클로전투_완료연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3005, 3006}, arg2: 0);
                context.SetPcEmotionSequence(arg1: "Assassin_Enterance_A");
                context.SetPcEmotionLoop(arg1: "Assassin_Enterance_A", arg2: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State쉐도우클로전투_완료연출07_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출07_b : TriggerState {
            internal State쉐도우클로전투_완료연출07_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {400}, arg2: true);
                context.SetEffect(arg1: new int[] {401}, arg2: true);
                context.SetEffect(arg1: new int[] {402}, arg2: true);
                context.SetEffect(arg1: new int[] {403}, arg2: true);
                context.SetEffect(arg1: new int[] {404}, arg2: true);
                context.SetEffect(arg1: new int[] {405}, arg2: true);
                context.SetEffect(arg1: new int[] {406}, arg2: true);
                context.SetEffect(arg1: new int[] {407}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1700)) {
                    context.State = new State쉐도우클로전투_완료연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출07 : TriggerState {
            internal State쉐도우클로전투_완료연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3007, 3008}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003185, illustID: "0", msg: "$52000112_QD__52000112__5$",
                    duration: 4000, align: "right");
                context.SetNpcEmotionLoop(arg1: 208, arg2: "Stun_A", arg3: 15500f);
                context.SetMesh(arg1: new int[] {300, 301, 302, 303, 304, 305, 306, 307}, arg2: false, arg3: 0,
                    arg4: 700, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State쉐도우클로전투_완료연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출08 : TriggerState {
            internal State쉐도우클로전투_완료연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3009, 3010}, arg2: 0);
                context.DestroyMonster(arg1: new int[] {201, 202, 203});
                context.VisibleMyPc(isVisible: false);
                context.AddCinematicTalk(npcID: 11003185, illustID: "0", msg: "$52000112_QD__52000112__6$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State쉐도우클로전투_완료연출08_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출08_1 : TriggerState {
            internal State쉐도우클로전투_완료연출08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State쉐도우클로전투_완료연출09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로전투_완료연출09 : TriggerState {
            internal State쉐도우클로전투_완료연출09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000111, arg2: 11);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}