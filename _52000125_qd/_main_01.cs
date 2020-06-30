using System;

namespace Maple2.Trigger._52000125_qd {
    public static class _main_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001},
                    arg2: new int[] {60100190, 60100191, 60100192, 60100193, 60100194, 60100195},
                    arg3: new byte[] {2})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.MoveUser(arg1: 52000125, arg2: 6001);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Clap_A");
                context.AddCinematicTalk(npcID: 11003205, msg: "$52000125_QD__MAIN_01__0$", duration: 3000,
                    align: "center");
                context.SetSceneSkip(arg1: "scene_08", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "ChatUp");
                context.AddCinematicTalk(npcID: 11003205, msg: "$52000125_QD__MAIN_01__1$", duration: 1000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003208, msg: "$52000125_QD__MAIN_01__2$", duration: 2000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003205, msg: "$52000125_QD__MAIN_01__3$", duration: 3000,
                    align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003, 4004, 4005}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100195},
                    arg3: new byte[] {2})) {
                    context.State = new Stateeventtalk_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_start : TriggerState {
            internal Stateeventtalk_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateeventtalk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_01 : TriggerState {
            internal Stateeventtalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_3004");
                context.AddBalloonTalk(spawnPointID: 102, msg: "$52000125_QD__MAIN_01__4$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateeventtalk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_02 : TriggerState {
            internal Stateeventtalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "ChatUp_A");
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000125_QD__MAIN_01__5$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateeventtalk_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_03 : TriggerState {
            internal Stateeventtalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Talk_A");
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000125_QD__MAIN_01__6$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateeventtalk_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_04 : TriggerState {
            internal Stateeventtalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "ChatUp_A");
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000125_QD__MAIN_01__7$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateeventtalk_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_05 : TriggerState {
            internal Stateeventtalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Idle_A");
                context.AddBalloonTalk(spawnPointID: 102, msg: "$52000125_QD__MAIN_01__8$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateeventtalk_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateeventtalk_06 : TriggerState {
            internal Stateeventtalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Idle_A");
                context.AddBalloonTalk(spawnPointID: 202, msg: "$52000125_QD__MAIN_01__9$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new Stateeventtalk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}