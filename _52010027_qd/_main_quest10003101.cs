using System;

namespace Maple2.Trigger._52010027_qd {
    public static class _main_quest10003101 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003101},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010027, arg2: 6005);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State집에서나옴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에서나옴 : TriggerState {
            internal State집에서나옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_3006");
                context.CreateMonster(arg1: new int[] {801}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52010027_QD__MAIN_QUEST10003101__0$", duration: 3000,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State집에서나와서대사침(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에서나와서대사침 : TriggerState {
            internal State집에서나와서대사침(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Suprise_A");
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52010027_QD__MAIN_QUEST10003101__1$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State집에나와서대사침01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침01 : TriggerState {
            internal State집에나와서대사침01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 10000f);
                context.AddCinematicTalk(npcID: 0, msg: "$52010027_QD__MAIN_QUEST10003101__2$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State집에나와서대사침02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침02 : TriggerState {
            internal State집에나와서대사침02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__3$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State집에나와서대사침03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침03 : TriggerState {
            internal State집에나와서대사침03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4011}, arg2: 0);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 10000f);
                context.AddCinematicTalk(npcID: 0, msg: "$52010027_QD__MAIN_QUEST10003101__4$", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State집에나와서대사침04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침04 : TriggerState {
            internal State집에나와서대사침04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4012}, arg2: 0);
                context.MoveNpc(arg1: 801, arg2: "MS2PatrolData_3005");
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__5$", duration: 3000);
                context.AddCinematicTalk(npcID: 0, msg: "$52010027_QD__MAIN_QUEST10003101__6$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__7$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__8$", duration: 4000);
                context.AddCinematicTalk(npcID: 0, msg: "$52010027_QD__MAIN_QUEST10003101__9$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    context.State = new State집에나와서대사침05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State집에나와서대사침05 : TriggerState {
            internal State집에나와서대사침05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 801, arg2: "Attack_01_G");
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__10$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__11$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State전투시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작01 : TriggerState {
            internal State전투시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010027, arg2: 6006);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투시작01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작01_1 : TriggerState {
            internal State전투시작01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52010027, arg2: 6006);
                context.CreateMonster(arg1: new int[] {801}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작02 : TriggerState {
            internal State전투시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {801});
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전투시작03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작03 : TriggerState {
            internal State전투시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {802}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52010027_QD__MAIN_QUEST10003101__12$", arg3: new int[] {3000},
                    arg4: "0");
                context.AddBalloonTalk(spawnPointID: 802, msg: "$52010027_QD__MAIN_QUEST10003101__13$", duration: 3000,
                    delayTick: 5000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {802})) {
                    context.State = new State전투종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료01 : TriggerState {
            internal State전투종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52010027, arg2: 6007);
                context.DestroyMonster(arg1: new int[] {802});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전투종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료02 : TriggerState {
            internal State전투종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003431, msg: "$52010027_QD__MAIN_QUEST10003101__14$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 803, arg2: "Stun_A", arg3: 160000000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투종료03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투종료03 : TriggerState {
            internal State전투종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
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