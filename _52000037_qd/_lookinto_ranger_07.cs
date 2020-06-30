using System;

namespace Maple2.Trigger._52000037_qd {
    public static class _lookinto_ranger_07 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "Dead_A");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Ending_Chord_01.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 4, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 5, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {60100070}, arg3: new byte[] {3},
                    arg4: 50)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {60100070}, arg3: new byte[] {2},
                    arg4: 50)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {60100070}, arg3: new byte[] {1},
                    arg4: 50)) {
                    context.State = new StateLoadingDelay02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {60100065}, arg3: new byte[] {3},
                    arg4: 50)) {
                    context.State = new StateDefaultSetting02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {60100065}, arg3: new byte[] {2},
                    arg4: 50)) {
                    context.State = new StateLoadingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(arg1: 800, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 801, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraWalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk04 : TriggerState {
            internal StateCameraWalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Ending_Chord_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraShot01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraShot01 : TriggerState {
            internal StateCameraShot01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 802, arg2: true);
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateCameraShot02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraShot02 : TriggerState {
            internal StateCameraShot02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 803, arg2: true);
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateCameraShot03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraShot03 : TriggerState {
            internal StateCameraShot03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: true);
                context.SetOnetimeEffect(id: 5, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraShot04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraShot04 : TriggerState {
            internal StateCameraShot04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 804, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefaultSetting02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting02 : TriggerState {
            internal StateDefaultSetting02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {60100070},
                    arg3: new byte[] {1})) {
                    context.State = new StateLoadingDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new int[] {501}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLoadingDelay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay03 : TriggerState {
            internal StateLoadingDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000037, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFindDoor01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFindDoor01 : TriggerState {
            internal StateFindDoor01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUserPath(arg1: "MS2PatrolData_1200");
                context.CameraSelect(arg1: 810, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFindDoor02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFindDoor02 : TriggerState {
            internal StateFindDoor02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_500");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateFindDoor03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFindDoor03 : TriggerState {
            internal StateFindDoor03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 811, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateChase01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChase01 : TriggerState {
            internal StateChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: false, arg3: 100, arg4: 200, arg5: 1f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateChase02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChase02 : TriggerState {
            internal StateChase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 501, arg2: "MS2PatrolData_501");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9500, arg2: new int[] {501})) {
                    context.State = new StateChase03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChase03 : TriggerState {
            internal StateChase03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {501});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 811, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000037_QD__LOOKINTO_RANGER_07__0$", arg3: new int[] {3000},
                    arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}