using System;

namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {60100245},
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statepcmove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statepcmove : TriggerState {
            internal Statepcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateErebTalk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_01 : TriggerState {
            internal StateErebTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {700}, arg2: 0);
                context.AddCinematicTalk(npcID: 11001663, illustID: "Ereb_normal",
                    msg: "$52000033_QD__AUDIENCEWITHEREB_03__0$", duration: 3000, delayTick: 0, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateErebTalk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_02 : TriggerState {
            internal StateErebTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {901}, arg2: 0);
                context.AddCinematicTalk(npcID: 11001663, msg: "$52000033_QD__AUDIENCEWITHEREB_03__1$", duration: 3000,
                    delayTick: 0, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateErebTalk_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_03 : TriggerState {
            internal StateErebTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {601}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestory_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestory_01 : TriggerState {
            internal Statestory_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000033_QD__AUDIENCEWITHEREB_03__2$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestory_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestory_02 : TriggerState {
            internal Statestory_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000033_QD__AUDIENCEWITHEREB_03__3$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestory_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestory_03 : TriggerState {
            internal Statestory_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000033_QD__AUDIENCEWITHEREB_03__4$", arg3: false);
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_1005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statefadein(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateErebTalk_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_04 : TriggerState {
            internal StateErebTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001663, illustID: "Ereb_surprise",
                    msg: "$52000033_QD__AUDIENCEWITHEREB_03__5$", duration: 3000, delayTick: 0, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateErebTalk_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_05 : TriggerState {
            internal StateErebTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.AddCinematicTalk(npcID: 11001663, illustID: "Ereb_closeEye",
                    msg: "$52000033_QD__AUDIENCEWITHEREB_03__6$", duration: 3000, delayTick: 0, align: "left");
                context.AddBalloonTalk(spawnPointID: 401, msg: "$52000033_QD__AUDIENCEWITHEREB_03__7$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateErebTalk_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_06 : TriggerState {
            internal StateErebTalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001663, illustID: "Ereb_serious",
                    msg: "$52000033_QD__AUDIENCEWITHEREB_03__8$", duration: 3000, delayTick: 0, align: "left");
                context.MoveNpc(arg1: 601, arg2: "MS2PatrolData_1006");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateErebTalk_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_07 : TriggerState {
            internal StateErebTalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001663, illustID: "Ereb_closeEye",
                    msg: "$52000033_QD__AUDIENCEWITHEREB_03__9$", duration: 3000, delayTick: 0, align: "left");
                context.DestroyMonster(arg1: new int[] {601});
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[] {601});
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}