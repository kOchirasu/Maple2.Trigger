using System;

namespace Maple2.Trigger._52000127_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001},
                    arg2: new int[] {60100215, 60100216, 60100217, 60100218, 60100219, 60100220},
                    arg3: new byte[] {2})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001},
                    arg2: new int[] {
                        60100220, 60100221, 60100222, 60100223, 60100224, 60100225, 60100226, 60100227, 60100228,
                        60100229, 60100230
                    }, arg3: new byte[] {2})) {
                    context.State = new Stateopen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statesetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesetting : TriggerState {
            internal Statesetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: true);
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.MoveUser(arg1: 52000127, arg2: 6001);
                context.SetSound(arg1: 7001, arg2: true);
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statedreamscene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_01 : TriggerState {
            internal Statedreamscene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__0$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statedreamscene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_02 : TriggerState {
            internal Statedreamscene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__1$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statedreamscene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_03 : TriggerState {
            internal Statedreamscene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__2$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statedreamscene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_04 : TriggerState {
            internal Statedreamscene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__3$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statedreamscene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_05 : TriggerState {
            internal Statedreamscene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__4$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statedreamscene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_06 : TriggerState {
            internal Statedreamscene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__5$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statedreamscene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedreamscene_07 : TriggerState {
            internal Statedreamscene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000127_QD__MAIN__6$", arg3: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                context.SetSound(arg1: 7001, arg2: false);
                context.SetSound(arg1: 7002, arg2: true);
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 21000f);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Stun");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 0, emotionName: "Stun");
                context.ShowCaption(type: "VerticalCaption", title: "$52000127_QD__MAIN__12$",
                    desc: "$52000127_QD__MAIN__13$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 0, emotionName: "Stun");
                context.AddCinematicTalk(npcID: 11003218, msg: "$52000127_QD__MAIN__7$", duration: 3000,
                    illustID: "Jordy_normal", align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Stun");
                context.AddCinematicTalk(npcID: 11003218, msg: "$52000127_QD__MAIN__8$", duration: 3000,
                    align: "Right");
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
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003218, msg: "$52000127_QD__MAIN__9$", duration: 3000,
                    align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.FaceEmotion(spawnPointID: 0, emotionName: "calm");
                context.AddCinematicTalk(npcID: 0, msg: "$52000127_QD__MAIN__10$", duration: 3000, align: "Right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.FaceEmotion(spawnPointID: 0, emotionName: "Ride_Sp_Run_005");
                context.AddCinematicTalk(npcID: 11003218, msg: "$52000127_QD__MAIN__11$", duration: 3000,
                    align: "Right");
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Stateopen : TriggerState {
            internal Stateopen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: true);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateopen2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopen2 : TriggerState {
            internal Stateopen2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}