using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000074_cs {
    public static class _63000074_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101});
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000370}, questStates: new byte[]{2})) {
                    return new StateMoveto63000072(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000370}, questStates: new byte[]{1})) {
                    return new StateDiary_ready(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{30000370}, questStates: new byte[]{1})) {
                    return new StateScene_fin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDiary_ready : TriggerState {
            internal StateDiary_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDiary_set(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDiary_set : TriggerState {
            internal StateDiary_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 63000074, portalId: 10);
                context.CameraSelect(triggerId: 8000, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDiary_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDiary_start : TriggerState {
            internal StateDiary_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSceneskip_1(context), arg2: "exit");
                context.SetCinematicUI(type: 9, script: "$63000074_CS__63000074_MAIN__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEvelyn_monologue_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_00 : TriggerState {
            internal StateEvelyn_monologue_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvelyn_monologue_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_01 : TriggerState {
            internal StateEvelyn_monologue_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11004354, script: "$63000074_CS__63000074_MAIN__1$", duration: 4000, illustId: "Evelyn_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvelyn_monologue_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_02 : TriggerState {
            internal StateEvelyn_monologue_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.AddCinematicTalk(npcId: 11004354, script: "$63000074_CS__63000074_MAIN__2$", duration: 4000, illustId: "Evelyn_sad", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvelyn_monologue_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_03 : TriggerState {
            internal StateEvelyn_monologue_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.AddCinematicTalk(npcId: 11004354, script: "$63000074_CS__63000074_MAIN__3$", duration: 5000, illustId: "Evelyn_sad", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvelyn_monologue_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_04 : TriggerState {
            internal StateEvelyn_monologue_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.AddCinematicTalk(npcId: 11004354, script: "$63000074_CS__63000074_MAIN__4$", duration: 3500);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateBobos_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBobos_ready : TriggerState {
            internal StateBobos_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBobos_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBobos_01 : TriggerState {
            internal StateBobos_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000074_CS__63000074_MAIN__5$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBobos_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBobos_02 : TriggerState {
            internal StateBobos_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$63000074_CS__63000074_MAIN__6$");
                context.SetMesh(triggerIds: new []{4001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateRednose_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRednose_01 : TriggerState {
            internal StateRednose_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRednose_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRednose_02 : TriggerState {
            internal StateRednose_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateRednose_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSceneskip_1 : TriggerState {
            internal StateSceneskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRednose_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRednose_03 : TriggerState {
            internal StateRednose_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "LonelyEvelyn");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMoveto63000072(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveto63000072 : TriggerState {
            internal StateMoveto63000072(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000072, portalId: 11);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveto63000072_2 : TriggerState {
            internal StateMoveto63000072_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000072, portalId: 11);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_fin : TriggerState {
            internal StateScene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
