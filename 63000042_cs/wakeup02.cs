using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000042_cs {
    public static class _wakeup02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100005, 60100006, 60100007, 60100008, 60100009, 60100010}, questStates: new byte[]{2})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{102});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.MoveUser(mapId: 63000042, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__0$", duration: 3000);
                context.SetSceneSkip(state: new StateSitReady(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__1$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_03 : TriggerState {
            internal StateTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__2$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_04 : TriggerState {
            internal StateTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003145, script: "$63000042_CS__WAKEUP02__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_05 : TriggerState {
            internal StateTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTalk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_06 : TriggerState {
            internal StateTalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__5$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_07 : TriggerState {
            internal StateTalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_08 : TriggerState {
            internal StateTalk_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003145, script: "$63000042_CS__WAKEUP02__7$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_09 : TriggerState {
            internal StateTalk_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$63000042_CS__WAKEUP02__8$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateSitReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSitReady : TriggerState {
            internal StateSitReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 13000f);
                context.SetSound(triggerId: 7002, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePraymove_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePraymove_01 : TriggerState {
            internal StatePraymove_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_103");
                context.AddCinematicTalk(npcId: 11003165, illustId: "Fray_normal", script: "$63000042_CS__WAKEUP02__9$", duration: 3000, align: Align.Left);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePraytalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePraytalk_02 : TriggerState {
            internal StatePraytalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003165, script: "$63000042_CS__WAKEUP02__10$", duration: 3000);
                context.CameraSelectPath(pathIds: new []{502}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePray(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePray : TriggerState {
            internal StatePray(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(scale: 2.5f, type: CaptionType.Name, title: "$63000042_CS__WAKEUP02__11$", script: "$63000042_CS__WAKEUP02__12$", align: Align.Center | Align.Right, offsetRateX: 0.5f, duration: 4000);
                context.CameraSelectPath(pathIds: new []{502, 503}, returnView: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 100f);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100010}, questStates: new byte[]{1})) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000033, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
