namespace Maple2.Trigger._52000037_qd {
    public static class _lookinto_knight_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "Dead_A");
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Ending_Chord_01.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100070}, questStates: new byte[]{3}, jobCode: 10)) {
                    return new StateQuit(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100070}, questStates: new byte[]{2}, jobCode: 10)) {
                    return new StateQuit(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100070}, questStates: new byte[]{1}, jobCode: 10)) {
                    return new StateLoadingDelay02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100065}, questStates: new byte[]{3}, jobCode: 10)) {
                    return new StateDefaultSetting02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100065}, questStates: new byte[]{2}, jobCode: 10)) {
                    return new StateLoadingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(triggerId: 800, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 801, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk04 : TriggerState {
            internal StateCameraWalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Ending_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraShot01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraShot01 : TriggerState {
            internal StateCameraShot01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 802, enabled: true);
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateCameraShot02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraShot02 : TriggerState {
            internal StateCameraShot02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 803, enabled: true);
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateCameraShot03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraShot03 : TriggerState {
            internal StateCameraShot03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 804, enabled: true);
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraFadeIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraFadeIn01 : TriggerState {
            internal StateCameraFadeIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraFadeOut01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraFadeOut01 : TriggerState {
            internal StateCameraFadeOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(triggerId: 804, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefaultSetting02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting02 : TriggerState {
            internal StateDefaultSetting02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100070}, questStates: new byte[]{1})) {
                    return new StateLoadingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{501}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLoadingDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay03 : TriggerState {
            internal StateLoadingDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000037, portalId: 11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFindDoor01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFindDoor01 : TriggerState {
            internal StateFindDoor01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_1200");
                context.CameraSelect(triggerId: 810, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFindDoor02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFindDoor02 : TriggerState {
            internal StateFindDoor02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 13, visible: true, enabled: true, minimapVisible: true);
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_500");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFindDoor03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFindDoor03 : TriggerState {
            internal StateFindDoor03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 811, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateChase01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChase01 : TriggerState {
            internal StateChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 100, arg4: 200, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateChase02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChase02 : TriggerState {
            internal StateChase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_501");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9500, spawnIds: new []{501})) {
                    return new StateChase03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChase03 : TriggerState {
            internal StateChase03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{501});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 811, enabled: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000037_QD__LOOKINTO_KNIGHT_03__0$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
