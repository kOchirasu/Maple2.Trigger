using System;

namespace Maple2.Trigger._52010055_qd {
    public static class _52010055 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {500}, arg2: false);
                context.SetEffect(arg1: new int[] {501}, arg2: false);
                context.SetEffect(arg1: new int[] {502}, arg2: false);
                context.RemoveBuff(arg1: 9002, arg2: 99910311);
                context.DestroyMonster(arg1: new int[] {-1});
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9002")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(arg1: new int[] {10000}, arg2: true);
                context.SetMesh(arg1: new int[] {10001}, arg2: true);
                context.SetMesh(arg1: new int[] {30000}, arg2: true);
                context.SetMesh(arg1: new int[] {30001}, arg2: true);
                context.SetMesh(arg1: new int[] {30002}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {1}, arg2: false);
                context.CreateMonster(arg1: new int[] {2}, arg2: false);
                context.CreateMonster(arg1: new int[] {3}, arg2: false);
                context.CreateMonster(arg1: new int[] {4}, arg2: false);
                context.CreateMonster(arg1: new int[] {5}, arg2: false);
                context.CreateMonster(arg1: new int[] {10000}, arg2: false);
                context.CreateMonster(arg1: new int[] {10001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10002}, arg2: false);
                context.CreateMonster(arg1: new int[] {100}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.CreateMonster(arg1: new int[] {111}, arg2: false);
                context.CreateMonster(arg1: new int[] {112}, arg2: false);
                context.CreateMonster(arg1: new int[] {113}, arg2: false);
                context.CreateMonster(arg1: new int[] {114}, arg2: false);
                context.CreateMonster(arg1: new int[] {115}, arg2: false);
                context.CreateMonster(arg1: new int[] {116}, arg2: false);
                context.CreateMonster(arg1: new int[] {117}, arg2: false);
                context.CreateMonster(arg1: new int[] {118}, arg2: false);
                context.CreateMonster(arg1: new int[] {119}, arg2: false);
                context.CreateMonster(arg1: new int[] {120}, arg2: false);
                context.CreateMonster(arg1: new int[] {121}, arg2: false);
                context.CreateMonster(arg1: new int[] {122}, arg2: false);
                context.CreateMonster(arg1: new int[] {123}, arg2: false);
                context.MoveUser(arg1: 52010055, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State크림슨발록비춤1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨발록비춤1 : TriggerState {
            internal State크림슨발록비춤1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(arg1: new int[] {10000}, arg2: false);
                context.SetMesh(arg1: new int[] {10001}, arg2: false);
                context.SetSceneSkip(arg1: "게임시작", arg2: "nextState");
                context.CameraSelect(arg1: 4001, arg2: true);
                context.AddCinematicTalk(npcID: 11003781, msg: "$52010055_QD__52010055__0$", duration: 3000,
                    align: "right");
                context.AddCinematicTalk(npcID: 11003781, msg: "$52010055_QD__52010055__1$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State크림슨이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨이동 : TriggerState {
            internal State크림슨이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 29000378, msg: "$52010055_QD__52010055__2$", duration: 3000,
                    align: "right");
                context.MoveNpc(arg1: 101, arg2: "PatrolDataBalrog_Open_101");
                context.MoveNpc(arg1: 102, arg2: "PatrolDataBalrog_Open_102");
                context.MoveNpc(arg1: 103, arg2: "PatrolDataBalrog_Open_103");
                context.MoveNpc(arg1: 104, arg2: "PatrolDataBalrog_Open_104");
                context.MoveNpc(arg1: 105, arg2: "PatrolDataBalrog_Open_105");
                context.MoveNpc(arg1: 106, arg2: "PatrolDataBalrog_Open_106");
                context.MoveNpc(arg1: 107, arg2: "PatrolDataBalrog_Open_107");
                context.MoveNpc(arg1: 108, arg2: "PatrolDataBalrog_Open_108");
                context.MoveNpc(arg1: 109, arg2: "PatrolDataBalrog_Open_109");
                context.MoveNpc(arg1: 110, arg2: "PatrolDataBalrog_Open_110");
                context.MoveNpc(arg1: 111, arg2: "PatrolDataBalrog_Open_111");
                context.MoveNpc(arg1: 112, arg2: "PatrolDataBalrog_Open_112");
                context.MoveNpc(arg1: 113, arg2: "PatrolDataBalrog_Open_113");
                context.MoveNpc(arg1: 114, arg2: "PatrolDataBalrog_Open_114");
                context.MoveNpc(arg1: 115, arg2: "PatrolDataBalrog_Open_115");
                context.MoveNpc(arg1: 116, arg2: "PatrolDataBalrog_Open_116");
                context.MoveNpc(arg1: 117, arg2: "PatrolDataBalrog_Open_117");
                context.MoveNpc(arg1: 118, arg2: "PatrolDataBalrog_Open_118");
                context.MoveNpc(arg1: 119, arg2: "PatrolDataBalrog_Open_119");
                context.MoveNpc(arg1: 120, arg2: "PatrolDataBalrog_Open_120");
                context.MoveNpc(arg1: 121, arg2: "PatrolDataBalrog_Open_121");
                context.MoveNpc(arg1: 122, arg2: "PatrolDataBalrog_Open_122");
                context.MoveNpc(arg1: 123, arg2: "PatrolDataBalrog_Open_123");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State함교비춤1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State함교비춤1 : TriggerState {
            internal State함교비춤1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
                    121, 122, 123
                });
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52010055, arg2: 2);
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 2, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003536, illustID: "Neirin_surprise",
                    msg: "$52010055_QD__52010055__3$", duration: 3000, align: "left");
                context.AddCinematicTalk(npcID: 11003682, illustID: "Bliche_closeEye",
                    msg: "$52010055_QD__52010055__4$", duration: 4000, align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State함교비춤2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State함교비춤2 : TriggerState {
            internal State함교비춤2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 1, arg2: 180);
                context.SetNpcEmotionSequence(arg1: 1, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__5$",
                    duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State콘대르대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르대사 : TriggerState {
            internal State콘대르대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 3, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52010055_QD__52010055__6$",
                    duration: 2000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State콘대르이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State콘대르이동 : TriggerState {
            internal State콘대르이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 3, arg2: "PatrolDataOpenConder0");
                context.SetNpcEmotionSequence(arg1: 5, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003584, illustID: "Schatten_normal",
                    msg: "$52010055_QD__52010055__7$", duration: 2000, align: "Reft");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State샤텐이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State샤텐이동 : TriggerState {
            internal State샤텐이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 5, arg2: "PatrolDataOpenSchatten0");
                context.SetNpcEmotionSequence(arg1: 4, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003586, illustID: "Mason_closeEye", msg: "$52010055_QD__52010055__8$",
                    duration: 3000, align: "Left");
                context.DestroyMonster(arg1: new int[] {3});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State메이슨이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메이슨이동 : TriggerState {
            internal State메이슨이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {5});
                context.MoveNpc(arg1: 4, arg2: "PatrolDataOpenMason0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State함교비춤3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State함교비춤3 : TriggerState {
            internal State함교비춤3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 1, arg2: 270);
                context.SetNpcEmotionSequence(arg1: 1, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__9$",
                    duration: 3000, align: "right");
                context.DestroyMonster(arg1: new int[] {4});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State함교비춤4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State함교비춤4 : TriggerState {
            internal State함교비춤4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 2, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003536, illustID: "Neirin_surprise",
                    msg: "$52010055_QD__52010055__10$", duration: 2000, align: "left");
                context.SetNpcEmotionSequence(arg1: 1, arg2: "Talk_A");
                context.SetNpcRotation(arg1: 1, arg2: 170);
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__11$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State함교비춤5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State함교비춤5 : TriggerState {
            internal State함교비춤5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Calm_A");
                context.InitNpcRotation(arg1: new int[] {1});
                context.SetNpcEmotionSequence(arg1: 1, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__12$",
                    duration: 3000, align: "Left");
                context.SetNpcEmotionSequence(arg1: 2, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003536, illustID: "Neirin_surprise",
                    msg: "$52010055_QD__52010055__13$", duration: 3000, align: "Right");
                context.SetNpcEmotionSequence(arg1: 1, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__14$",
                    duration: 2000, align: "right");
                context.AddCinematicTalk(npcID: 11003682, illustID: "Bliche_closeEye",
                    msg: "$52010055_QD__52010055__15$", duration: 2000, align: "right");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__16$",
                    duration: 2000, align: "right");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State게임시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10002, 10003, 10004, 10005}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {4003, 4019}, arg2: false);
                context.VisibleMyPc(isVisible: true);
                context.CameraReset(interpolationTime: 0f);
                context.MoveUser(arg1: 52010055, arg2: 3);
                context.SetLocalCamera(cameraId: 9009, enable: true);
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SideNpcTalk(npcID: 11003533, illust: "Bliche_closeEye", duration: 3000,
                    script: "$52010055_QD__52010055__17$", voice: @"ko/Npc/00002154");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1차발록스피어스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차발록스피어스폰 : TriggerState {
            internal State1차발록스피어스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4019, arg2: true);
                context.SetMesh(arg1: new int[] {10000}, arg2: false);
                context.CreateMonster(arg1: new int[] {1}, arg2: false);
                context.CreateMonster(arg1: new int[] {2}, arg2: false);
                context.CreateMonster(arg1: new int[] {10000}, arg2: false);
                context.CreateMonster(arg1: new int[] {10001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10002}, arg2: false);
                context.CreateMonster(arg1: new int[] {1000}, arg2: false);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                context.CreateMonster(arg1: new int[] {1004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1000, 1001, 1002, 1003, 1004})) {
                    context.State = new State2차발록스피어스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차발록스피어스폰 : TriggerState {
            internal State2차발록스피어스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                context.CreateMonster(arg1: new int[] {1006}, arg2: false);
                context.CreateMonster(arg1: new int[] {1007}, arg2: false);
                context.CreateMonster(arg1: new int[] {1008}, arg2: false);
                context.CreateMonster(arg1: new int[] {1009}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1005, 1006, 1007, 1008, 1009})) {
                    context.State = new State3차발록스피어스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차발록스피어스폰 : TriggerState {
            internal State3차발록스피어스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1010}, arg2: false);
                context.CreateMonster(arg1: new int[] {1011}, arg2: false);
                context.CreateMonster(arg1: new int[] {1012}, arg2: false);
                context.CreateMonster(arg1: new int[] {1013}, arg2: false);
                context.CreateMonster(arg1: new int[] {1014}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1010, 1011, 1012, 1013, 1014})) {
                    context.State = new State1차크림슨스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차크림슨스폰 : TriggerState {
            internal State1차크림슨스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {200, 201, 202, 203})) {
                    context.State = new State2차크림슨스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차크림슨스폰 : TriggerState {
            internal State2차크림슨스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {204}, arg2: false);
                context.CreateMonster(arg1: new int[] {205}, arg2: false);
                context.CreateMonster(arg1: new int[] {206}, arg2: false);
                context.CreateMonster(arg1: new int[] {207}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {204, 205, 206, 207})) {
                    context.State = new State3차크림슨스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차크림슨스폰 : TriggerState {
            internal State3차크림슨스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                context.CreateMonster(arg1: new int[] {1006}, arg2: false);
                context.CreateMonster(arg1: new int[] {1007}, arg2: false);
                context.CreateMonster(arg1: new int[] {1008}, arg2: false);
                context.CreateMonster(arg1: new int[] {1009}, arg2: false);
                context.CreateMonster(arg1: new int[] {209}, arg2: false);
                context.CreateMonster(arg1: new int[] {210}, arg2: false);
                context.CreateMonster(arg1: new int[] {211}, arg2: false);
                context.CreateMonster(arg1: new int[] {212}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1005, 1006, 1007, 1008, 1009, 209, 210, 211, 212})) {
                    context.State = new State4차크림슨스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차크림슨스폰 : TriggerState {
            internal State4차크림슨스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1010}, arg2: false);
                context.CreateMonster(arg1: new int[] {1011}, arg2: false);
                context.CreateMonster(arg1: new int[] {1012}, arg2: false);
                context.CreateMonster(arg1: new int[] {1013}, arg2: false);
                context.CreateMonster(arg1: new int[] {1014}, arg2: false);
                context.CreateMonster(arg1: new int[] {213}, arg2: false);
                context.CreateMonster(arg1: new int[] {214}, arg2: false);
                context.CreateMonster(arg1: new int[] {215}, arg2: false);
                context.CreateMonster(arg1: new int[] {216}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1010, 1011, 1012, 1013, 1014, 213, 214, 215, 216})) {
                    context.State = new State보스전연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전연출준비 : TriggerState {
            internal State보스전연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52010055, arg2: 4);
                context.RemoveBuff(arg1: 9002, arg2: 99910311);
                context.CameraReset(interpolationTime: 0f);
                context.SetMesh(arg1: new int[] {10002, 10003, 10004, 10005}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스전연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전연출시작 : TriggerState {
            internal State보스전연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(arg1: 4006, arg2: true);
                context.CreateMonster(arg1: new int[] {1}, arg2: false);
                context.CreateMonster(arg1: new int[] {2}, arg2: false);
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스전연출1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전연출1 : TriggerState {
            internal State보스전연출1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 2000, arg2: "Attack_01_A");
                context.AddCinematicTalk(npcID: 29000382, msg: "$52010055_QD__52010055__21$", duration: 3000,
                    align: "right");
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전시작 : TriggerState {
            internal State보스전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4019, arg2: true);
                context.DestroyMonster(arg1: new int[] {2000});
                context.CreateMonster(arg1: new int[] {2001}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.State = new State보스사망체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스사망체크 : TriggerState {
            internal State보스사망체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 5, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스전끝크림슨발록대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전끝크림슨발록대사1 : TriggerState {
            internal State보스전끝크림슨발록대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(arg1: new int[] {10002, 10003, 10004, 10005}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {1}, arg2: false);
                context.CreateMonster(arg1: new int[] {2}, arg2: false);
                context.CreateMonster(arg1: new int[] {13}, arg2: false);
                context.CreateMonster(arg1: new int[] {14}, arg2: false);
                context.CreateMonster(arg1: new int[] {15}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
                context.MoveUser(arg1: 52010055, arg2: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩연출크림슨발록보스1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출크림슨발록보스1 : TriggerState {
            internal State엔딩연출크림슨발록보스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 14, arg2: -10);
                context.SetNpcRotation(arg1: 15, arg2: 10);
                context.CameraSelect(arg1: 4006, arg2: true);
                context.MoveUserPath(arg1: "PatrolDataEndPC0");
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Dead_01_A");
                context.AddCinematicTalk(npcID: 29000382, msg: "$52010055_QD__52010055__22$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩연출크림슨발록보스2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출크림슨발록보스2 : TriggerState {
            internal State엔딩연출크림슨발록보스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 2002, arg2: 2003);
                context.SetNpcEmotionSequence(arg1: 2003, arg2: "Dead_01_A");
                context.SetSceneSkip(arg1: "맵이동", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {4007, 4008}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.SetNpcEmotionSequence(arg1: 13,
                    arg2: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.SetNpcEmotionSequence(arg1: 14,
                    arg2: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.SetNpcEmotionSequence(arg1: 15,
                    arg2: "Attack_Idle_A,Attack_Idle_A,Attack_Idle_A,Attack_Idle_A");
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52010055_QD__52010055__23$",
                    duration: 2000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State엔딩연출샤텐1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출샤텐1 : TriggerState {
            internal State엔딩연출샤텐1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2002});
                context.SetNpcEmotionSequence(arg1: 13, arg2: "Attack_Idle_A");
                context.SetNpcEmotionSequence(arg1: 14, arg2: "Attack_Idle_A");
                context.SetNpcEmotionSequence(arg1: 15, arg2: "Attack_Idle_A");
                context.AddCinematicTalk(npcID: 11003584, illustID: "Schatten_normal",
                    msg: "$52010055_QD__52010055__24$", duration: 3000, align: "Reft");
                context.CameraSelectPath(arg1: new int[] {4009, 4010}, arg2: false);
                context.CameraSelect(arg1: 4010, arg2: true);
                context.SetNpcEmotionSequence(arg1: 15, arg2: "Attack_Idle_A,Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State엔딩연출메이슨1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출메이슨1 : TriggerState {
            internal State엔딩연출메이슨1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003586, illustID: "Mason_closeEye",
                    msg: "$52010055_QD__52010055__25$", duration: 1500, align: "Reft");
                context.CameraSelect(arg1: 4014, arg2: true);
                context.CameraSelectPath(arg1: new int[] {4014, 4015}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 13, arg2: "Attack_Idle_A");
                context.SetNpcEmotionSequence(arg1: 14, arg2: "Attack_Idle_A,Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State엔딩연출콘대르1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출콘대르1 : TriggerState {
            internal State엔딩연출콘대르1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {500}, arg2: true);
                context.SetEffect(arg1: new int[] {501}, arg2: true);
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52010055_QD__52010055__26$",
                    duration: 3000, align: "Reft");
                context.CameraSelectPath(arg1: new int[] {4016, 4017}, arg2: false);
                context.MoveNpc(arg1: 13, arg2: "PatrolDataCondorAttack1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩연출콘대르2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출콘대르2 : TriggerState {
            internal State엔딩연출콘대르2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4006, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {502}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 13, arg2: "Attack_01_G,Attack_02_G,Attack_03_G,Attack_06_G");
                context.SetNpcEmotionSequence(arg1: 2003, arg2: "Stun_A,Stun_A,Stun_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3002)) {
                    context.State = new State엔딩연출클림슨발록사망1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출클림슨발록사망1 : TriggerState {
            internal State엔딩연출클림슨발록사망1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 2003, arg2: "Dead_01_A");
                context.AddCinematicTalk(npcID: 29000382, msg: "$52010055_QD__52010055__27$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State엔딩연출준비1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출준비1 : TriggerState {
            internal State엔딩연출준비1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new int[] {2003}, arg2: false);
                context.DestroyMonster(arg1: new int[] {13});
                context.DestroyMonster(arg1: new int[] {14});
                context.DestroyMonster(arg1: new int[] {15});
                context.MoveUser(arg1: 52010055, arg2: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩연출준비2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출준비2 : TriggerState {
            internal State엔딩연출준비2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State크림슨대사준비1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨대사준비1 : TriggerState {
            internal State크림슨대사준비1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {700}, arg2: false);
                context.CreateMonster(arg1: new int[] {701}, arg2: false);
                context.CreateMonster(arg1: new int[] {702}, arg2: false);
                context.CreateMonster(arg1: new int[] {703}, arg2: false);
                context.CreateMonster(arg1: new int[] {704}, arg2: false);
                context.CreateMonster(arg1: new int[] {705}, arg2: false);
                context.CreateMonster(arg1: new int[] {706}, arg2: false);
                context.CreateMonster(arg1: new int[] {707}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.MoveUser(arg1: 52010055, arg2: 7);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩연출크림슨카메라1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출크림슨카메라1 : TriggerState {
            internal State엔딩연출크림슨카메라1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(arg1: 4023, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State엔딩연출크림슨대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출크림슨대사1 : TriggerState {
            internal State엔딩연출크림슨대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 29000378, msg: "$52010055_QD__52010055__29$", duration: 3000,
                    align: "right");
                context.MoveNpc(arg1: 700, arg2: "PatrolData700");
                context.MoveNpc(arg1: 701, arg2: "PatrolData701");
                context.MoveNpc(arg1: 702, arg2: "PatrolData702");
                context.MoveNpc(arg1: 703, arg2: "PatrolData703");
                context.MoveNpc(arg1: 704, arg2: "PatrolData704");
                context.MoveNpc(arg1: 705, arg2: "PatrolData705");
                context.MoveNpc(arg1: 706, arg2: "PatrolData706");
                context.MoveNpc(arg1: 707, arg2: "PatrolData707");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State엔딩이동준비1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩이동준비1 : TriggerState {
            internal State엔딩이동준비1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 1);
                context.DestroyMonster(arg1: new int[] {-1});
                context.MoveUser(arg1: 52010055, arg2: 8, arg3: 9002);
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩이동준비2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩이동준비2 : TriggerState {
            internal State엔딩이동준비2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4024, arg2: true);
                context.CreateMonster(arg1: new int[] {1}, arg2: false);
                context.CreateMonster(arg1: new int[] {2}, arg2: false);
                context.CreateMonster(arg1: new int[] {13}, arg2: false);
                context.CreateMonster(arg1: new int[] {14}, arg2: false);
                context.CreateMonster(arg1: new int[] {15}, arg2: false);
                context.CreateMonster(arg1: new int[] {10001}, arg2: false);
                context.CreateMonster(arg1: new int[] {10002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엔딩NPC이동1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩NPC이동1 : TriggerState {
            internal State엔딩NPC이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "PatrolDataEndPC2");
                context.MoveNpc(arg1: 13, arg2: "PatrolDataEndCondor1");
                context.MoveNpc(arg1: 14, arg2: "PatrolDataEndMason1");
                context.MoveNpc(arg1: 15, arg2: "PatrolDataEndSchatten1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩대사콘대르1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩대사콘대르1 : TriggerState {
            internal State엔딩대사콘대르1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 15, arg2: 60);
                context.SetNpcRotation(arg1: 14, arg2: 330);
                context.SetNpcEmotionSequence(arg1: 13, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003776, illustID: "Conder_normal", msg: "$52010055_QD__52010055__30$",
                    duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩대사샤텐1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩대사샤텐1 : TriggerState {
            internal State엔딩대사샤텐1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 15, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003584, illustID: "Schatten_normal",
                    msg: "$52010055_QD__52010055__31$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩대사메이슨1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩대사메이슨1 : TriggerState {
            internal State엔딩대사메이슨1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: false);
                context.SetMesh(arg1: new int[] {10001}, arg2: false);
                context.SetMesh(arg1: new int[] {10002}, arg2: false);
                context.SetMesh(arg1: new int[] {10003}, arg2: false);
                context.SetMesh(arg1: new int[] {10004}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 14, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003586, illustID: "Mason_closeEye",
                    msg: "$52010055_QD__52010055__32$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State함교로카메라전환1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State함교로카메라전환1 : TriggerState {
            internal State함교로카메라전환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 4025, arg2: true);
                context.VisibleMyPc(isVisible: false);
                context.MoveUser(arg1: 52010055, arg2: 2);
                context.SetOnetimeEffect(id: 10, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State엔딩대사네이린1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩대사네이린1 : TriggerState {
            internal State엔딩대사네이린1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 22, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003536, illustID: "Neirin_normal", msg: "$52010055_QD__52010055__33$",
                    duration: 4000, align: "right");
                context.AddCinematicTalk(npcID: 11003536, illustID: "Neirin_normal", msg: "$52010055_QD__52010055__34$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State엔딩대사블리체1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩대사블리체1 : TriggerState {
            internal State엔딩대사블리체1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 21, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__35$",
                    duration: 3000, align: "right");
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010055_QD__52010055__36$",
                    duration: 5000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State엔딩연출종료1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출종료1 : TriggerState {
            internal State엔딩연출종료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(isVisible: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 9002, arg2: "trigger", arg3: "rescueskyfortress");
                context.SetOnetimeEffect(id: 12, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.MoveUser(arg1: 52010052);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}