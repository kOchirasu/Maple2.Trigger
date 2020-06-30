using System;

namespace Maple2.Trigger._52000068_qd {
    public static class _tria_seige_movie {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "tria_seige", value: 1)) {
                    context.State = new StateLoadingDelayB0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayB0 : TriggerState {
            internal StateLoadingDelayB0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "NPC이동", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkill(arg1: new int[] {701}, arg2: true);
                context.SetActor(arg1: 11010, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 11010, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 16000, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 16001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 16002, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16003, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16004, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16005, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16006, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16007, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 16008, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16009, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16010, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16011, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 16012, arg2: true, arg3: "Stun_A");
                context.CreateMonster(
                    arg1: new int[] {
                        10000, 10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012,
                        10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023
                    }, arg2: false);
                context.CreateMonster(
                    arg1: new int[] {10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033, 10034},
                    arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {5000, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012},
                    arg2: false);
                context.CreateMonster(arg1: new int[] {11000, 11001, 11002, 11003, 11004, 11005, 11006, 11007},
                    arg2: false);
                context.CreateMonster(arg1: new int[] {11009}, arg2: false);
                context.SetSound(arg1: 90000, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLoadingDelayB1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayB1 : TriggerState {
            internal StateLoadingDelayB1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State원경카메라01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State원경카메라01 : TriggerState {
            internal State원경카메라01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {12000, 12001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State원경카메라02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State원경카메라02 : TriggerState {
            internal State원경카메라02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {12002, 12003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State원경카메라03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State원경카메라03 : TriggerState {
            internal State원경카메라03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {12004, 12005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State프레이대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이대사 : TriggerState {
            internal State프레이대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11000064, illustID: "Lennon_closeEye",
                    msg: "$52000068_QD__TRIA_SEIGE_MOVIE__0$", duration: 5000, align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State알론대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알론대사 : TriggerState {
            internal State알론대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000076, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State근위대원등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State근위대원등장 : TriggerState {
            internal State근위대원등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.CreateMonster(arg1: new int[] {11008}, arg2: false);
                context.MoveNpc(arg1: 11008, arg2: "MS2PatrolData_soldier");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State근위대대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State근위대대사01 : TriggerState {
            internal State근위대대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001968, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE__2$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State근위대대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State근위대대사02 : TriggerState {
            internal State근위대대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001968, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE__3$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State근위대대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State근위대대사03 : TriggerState {
            internal State근위대대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000601, arg3: "$52000068_QD__TRIA_SEIGE_MOVIE__4$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State근위대대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State근위대대사04 : TriggerState {
            internal State근위대대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.MoveNpc(arg1: 11000, arg2: "MS2PatrolData_GoToJody_ereb");
                context.MoveNpc(arg1: 11001, arg2: "MS2PatrolData_GoToJody_karl");
                context.MoveNpc(arg1: 11002, arg2: "MS2PatrolData_GoToJody_luana");
                context.MoveNpc(arg1: 11003, arg2: "MS2PatrolData_GoToJody_BlackEye");
                context.MoveNpc(arg1: 11004, arg2: "MS2PatrolData_GoToJody_lennon");
                context.MoveNpc(arg1: 11005, arg2: "MS2PatrolData_GoToJody_eve");
                context.MoveNpc(arg1: 11006, arg2: "MS2PatrolData_GoToJody_alon");
                context.MoveNpc(arg1: 11007, arg2: "MS2PatrolData_GoToJody_pray");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    // context.State = new State지원군등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}