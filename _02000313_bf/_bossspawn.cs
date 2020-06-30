using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000313_bf {
    public static class _bossspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
                context.SetLadder(arg1: 4001, arg2: false, arg3: false);
                context.SetLadder(arg1: 4002, arg2: false, arg3: false);
                context.SetLadder(arg1: 4003, arg2: false, arg3: false);
                context.SetLadder(arg1: 4004, arg2: false, arg3: false);
                context.SetLadder(arg1: 4005, arg2: false, arg3: false);
                context.SetLadder(arg1: 4006, arg2: false, arg3: false);
                context.SetLadder(arg1: 4007, arg2: false, arg3: false);
                context.SetLadder(arg1: 4008, arg2: false, arg3: false);
                context.SetLadder(arg1: 4101, arg2: false, arg3: false);
                context.SetLadder(arg1: 4102, arg2: false, arg3: false);
                context.SetLadder(arg1: 4103, arg2: false, arg3: false);
                context.SetLadder(arg1: 4104, arg2: false, arg3: false);
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131,
                        3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147,
                        3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215,
                        3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231,
                        3232, 3233, 3234, 3235
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1099}, arg2: false);
                context.CreateMonster(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "15")) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
                context.CameraSelect(arg1: 30000, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "1차전투시작");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State1차전투시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 30000, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State1차전투시작 : TriggerState {
            internal State1차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031300, textID: 20031300, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State1차전투시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차전투시작2 : TriggerState {
            internal State1차전투시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031301, textID: 20031301, durationTime: 4000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2001})) {
                    context.State = new State1차NPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차NPC이동 : TriggerState {
            internal State1차NPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_1001A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 10101, arg2: new int[] {1001})) {
                    context.DestroyMonster(arg1: new int[] {1001});
                    context.CreateMonster(arg1: new int[] {1002}, arg2: false);
                    context.State = new State2차전투대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투대기 : TriggerState {
            internal State2차전투대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031302, textID: 20031302, durationTime: 4000);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "10102")) {
                    context.State = new State2차전투딜레이(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new int[] {2002})) {
                    context.State = new State2차전투딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투딜레이 : TriggerState {
            internal State2차전투딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State2차전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차전투시작 : TriggerState {
            internal State2차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1002});
                context.CreateMonster(arg1: new int[] {1003}, arg2: false);
                context.SetLadder(arg1: 4001, arg2: true, arg3: true);
                context.SetLadder(arg1: 4002, arg2: true, arg3: true);
                context.SetLadder(arg1: 4003, arg2: true, arg3: true);
                context.SetLadder(arg1: 4004, arg2: true, arg3: true);
                context.SetLadder(arg1: 4005, arg2: true, arg3: true);
                context.SetLadder(arg1: 4006, arg2: true, arg3: true);
                context.SetLadder(arg1: 4007, arg2: true, arg3: true);
                context.SetLadder(arg1: 4008, arg2: true, arg3: true);
                context.SetMesh(
                    arg1: new int[] {
                        3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115,
                        3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131,
                        3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147,
                        3148, 3149, 3150, 3151, 3152, 3153, 3154, 3155, 3156, 3157, 3158
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2002})) {
                    context.State = new State2차NPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차NPC이동 : TriggerState {
            internal State2차NPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003B");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 10104, arg2: new int[] {1003})) {
                    context.DestroyMonster(arg1: new int[] {1003});
                    context.CreateMonster(arg1: new int[] {1004}, arg2: false);
                    context.State = new State3차전투대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투대기 : TriggerState {
            internal State3차전투대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031302, textID: 20031302, durationTime: 4000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "10103")) {
                    context.State = new State3차전투딜레이(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new int[] {2003})) {
                    context.State = new State3차전투딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투딜레이 : TriggerState {
            internal State3차전투딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3차전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차전투시작 : TriggerState {
            internal State3차전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1004});
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                context.SetLadder(arg1: 4101, arg2: true, arg3: true);
                context.SetLadder(arg1: 4102, arg2: true, arg3: true);
                context.SetLadder(arg1: 4103, arg2: true, arg3: true);
                context.SetLadder(arg1: 4104, arg2: true, arg3: true);
                context.SetMesh(
                    arg1: new int[] {
                        3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215,
                        3216, 3217, 3218, 3219, 3220, 3221, 3222, 3223, 3224, 3225, 3226, 3227, 3228, 3229, 3230, 3231,
                        3232, 3233, 3234, 3235
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2003})) {
                    context.State = new State보스등장연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출 : TriggerState {
            internal State보스등장연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 30001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State보스등장연출2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출2 : TriggerState {
            internal State보스등장연출2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1099});
                context.DestroyMonster(arg1: new int[] {1005});
                context.CreateMonster(arg1: new int[] {2099}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State보스등장연출3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출3 : TriggerState {
            internal State보스등장연출3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 1101, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1102, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1103, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1104, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1105, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1106, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1107, arg2: "Dead_A", arg3: 9000f);
                context.SetNpcEmotionLoop(arg1: 1108, arg2: "Dead_A", arg3: 9000f);
                context.SetMesh(
                    arg1: new int[] {
                        3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315,
                        3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip(arg1: "보스전투시작");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스전투시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 30001, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
                context.SetNpcEmotionLoop(arg1: 1005, arg2: "Dead_Idle_A", arg3: 9999999999999999f);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }
        }

        private class State보스전투시작 : TriggerState {
            internal State보스전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031303, textID: 20031303, durationTime: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State보스전투시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투시작2 : TriggerState {
            internal State보스전투시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20031304, textID: 20031304, durationTime: 6000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State퀘스트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트체크 : TriggerState {
            internal State퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트코드확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퀘스트코드확인 : TriggerState {
            internal State퀘스트코드확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9997}, arg2: new int[] {10003105},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트연출_시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9998}, arg2: new int[] {10003105},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트연출_시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9999}, arg2: new int[] {10003105},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트연출_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_시작 : TriggerState {
            internal State퀘스트연출_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 9, arg2: "$02000313_BF__BOSSSPAWN__43$", arg3: false);
                context.CreateMonster(arg1: new int[] {205}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.CreateMonster(arg1: new int[] {204}, arg2: true);
                context.MoveUser(arg1: 02000313, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State퀘스트연출_상황보여주기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_01 : TriggerState {
            internal State퀘스트연출_상황보여주기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "퀘스트연출끝_이동", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 30000, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 0, msg: "$02000313_BF__BOSSSPAWN__44$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003392, msg: "$02000313_BF__BOSSSPAWN__45$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 205, arg2: "Stun_A", arg3: 160000000f);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Attack_Idle_A", arg3: 160000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_상황보여주기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_02 : TriggerState {
            internal State퀘스트연출_상황보여주기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_A");
                context.FaceEmotion(spawnPointID: 203, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__46$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__47$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_상황보여주기_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_03 : TriggerState {
            internal State퀘스트연출_상황보여주기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Attack_Idle_A", arg3: 999999999f);
                context.SetNpcEmotionSequence(arg1: 204, arg2: "Talk_A,Bore_B");
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.AddCinematicTalk(npcID: 11003454, msg: "$02000313_BF__BOSSSPAWN__48$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_04_1 : TriggerState {
            internal State퀘스트연출_상황보여주기_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 203, emotionName: "Trigger_Danger");
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__49$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__50$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003454, msg: "$02000313_BF__BOSSSPAWN__51$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State퀘스트연출_상황보여주기_04_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_04_2 : TriggerState {
            internal State퀘스트연출_상황보여주기_04_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.AddCinematicTalk(npcID: 0, msg: "$02000313_BF__BOSSSPAWN__52$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__53$", duration: 3000);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$02000313_BF__BOSSSPAWN__54$", duration: 2000,
                    delayTick: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_상황보여주기_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_04 : TriggerState {
            internal State퀘스트연출_상황보여주기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 201, emotionName: "Talk");
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Idle_A", arg3: 999999999f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State퀘스트연출_상황보여주기_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_05 : TriggerState {
            internal State퀘스트연출_상황보여주기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013}, arg2: 0);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_9991");
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__55$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_06 : TriggerState {
            internal State퀘스트연출_상황보여주기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Idle_A", arg3: 999999999f);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__56$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__57$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_상황보여주기_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_07 : TriggerState {
            internal State퀘스트연출_상황보여주기_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__58$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_08 : TriggerState {
            internal State퀘스트연출_상황보여주기_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Idle_A", arg3: 999999999f);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_A");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_9994");
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__15$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_09 : TriggerState {
            internal State퀘스트연출_상황보여주기_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Attack_Idle_A", arg3: 999999999f);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__59$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__60$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_상황보여주기_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_10 : TriggerState {
            internal State퀘스트연출_상황보여주기_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014}, arg2: 0);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_9995");
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__61$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$02000313_BF__BOSSSPAWN__62$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 204, arg2: "Talk_A");
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Attack_01_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_상황보여주기_10_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_10_1 : TriggerState {
            internal State퀘스트연출_상황보여주기_10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4013}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__63$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__64$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Attack_Idle_A", arg3: 999999999f);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__65$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__66$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$02000313_BF__BOSSSPAWN__67$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State퀘스트연출_상황보여주기_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_11 : TriggerState {
            internal State퀘스트연출_상황보여주기_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "ChatUp_A");
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Proud");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_9996");
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__68$", duration: 4000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__69$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State퀘스트연출_상황보여주기_11_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_11_1 : TriggerState {
            internal State퀘스트연출_상황보여주기_11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__70$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 203, arg2: "Sit_Down_A", arg3: 10000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_11_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_11_2 : TriggerState {
            internal State퀘스트연출_상황보여주기_11_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__71$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_11_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_11_3 : TriggerState {
            internal State퀘스트연출_상황보여주기_11_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_A");
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__72$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__73$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__74$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State퀘스트연출_상황보여주기_11_4_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_11_4_1 : TriggerState {
            internal State퀘스트연출_상황보여주기_11_4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 201, emotionName: "Trigger_Proud");
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__75$", duration: 6060);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6060)) {
                    context.State = new State퀘스트연출_상황보여주기_11_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_11_4 : TriggerState {
            internal State퀘스트연출_상황보여주기_11_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4019}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Attack_01_A");
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__76$", duration: 4000);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__77$", duration: 4000);
                context.SetSkip(arg1: "퀘스트연출_마지막전투_04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State퀘스트연출_상황보여주기_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_12 : TriggerState {
            internal State퀘스트연출_상황보여주기_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4014}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003387, msg: "$02000313_BF__BOSSSPAWN__78$", duration: 3000);
                context.FaceEmotion(spawnPointID: 203, emotionName: "Trigger_Embarrassed");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퀘스트연출_상황보여주기_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_상황보여주기_13 : TriggerState {
            internal State퀘스트연출_상황보여주기_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4018}, arg2: 0);
                context.VisibleMyPc(isVisible: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Attack_01_C");
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__79$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__80$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__81$", duration: 3000);
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.DestroyMonster(arg1: new int[] {203});
                context.DestroyMonster(arg1: new int[] {204});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State퀘스트연출_마지막전투_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_01 : TriggerState {
            internal State퀘스트연출_마지막전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4020}, arg2: 0);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Attack_04_G");
                context.AddCinematicTalk(npcID: 11003392, msg: "$02000313_BF__BOSSSPAWN__82$", duration: 1500);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State퀘스트연출_마지막전투_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_02 : TriggerState {
            internal State퀘스트연출_마지막전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.VisibleMyPc(isVisible: false);
                context.AddCinematicTalk(npcID: 11003393, msg: "$02000313_BF__BOSSSPAWN__83$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003407, msg: "$02000313_BF__BOSSSPAWN__84$", duration: 3000);
                context.SetOnetimeEffect(id: 102, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Attack_02_H");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State퀘스트연출_마지막전투_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_03 : TriggerState {
            internal State퀘스트연출_마지막전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_9993");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_9992");
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Attack_04_G");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트연출_마지막전투_03_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_03_1 : TriggerState {
            internal State퀘스트연출_마지막전투_03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Dead_A");
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Attack_01_B");
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State퀘스트연출_마지막전투_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_04 : TriggerState {
            internal State퀘스트연출_마지막전투_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[] {201});
                context.DestroyMonster(arg1: new int[] {202});
                context.DestroyMonster(arg1: new int[] {205});
                context.CreateMonster(arg1: new int[] {206}, arg2: true);
                context.CreateMonster(arg1: new int[] {207}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 206, arg2: "Dead_A", arg3: 1000000f);
                context.SetNpcEmotionLoop(arg1: 207, arg2: "Dead_B", arg3: 1000000f);
                context.FaceEmotion(spawnPointID: 206, emotionName: "Trigger_Dead");
                context.FaceEmotion(spawnPointID: 207, emotionName: "Trigger_Dead");
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State퀘스트연출_마지막전투_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_05 : TriggerState {
            internal State퀘스트연출_마지막전투_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG\weather\Eff_monochrome_03.xml");
                context.CameraSelectPath(arg1: new int[] {4021, 4022}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_마지막전투_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_06 : TriggerState {
            internal State퀘스트연출_마지막전투_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG\weather\Eff_monochrome_03.xml");
                context.SetProductionUI(arg1: 9, arg2: "$02000313_BF__BOSSSPAWN__85$", arg3: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State퀘스트연출_마지막전투_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_07 : TriggerState {
            internal State퀘스트연출_마지막전투_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$02000313_BF__BOSSSPAWN__86$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State퀘스트연출_마지막전투_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출_마지막전투_08 : TriggerState {
            internal State퀘스트연출_마지막전투_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트연출끝_이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트연출끝_이동 : TriggerState {
            internal State퀘스트연출끝_이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52010032, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}