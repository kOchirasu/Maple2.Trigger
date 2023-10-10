using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010064_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000073}, questStates: new byte[]{3})) {
                    return new State돌아가(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000073}, questStates: new byte[]{2})) {
                    return new StateCameraEffect01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000073}, questStates: new byte[]{1})) {
                    return new StateCameraEffect01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000072}, questStates: new byte[]{3})) {
                    return new State돌아가(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{91000073}, questStates: new byte[]{1})) {
                    return new State돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateQuit01(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "flyingtristan");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State트리스탄Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script01 : TriggerState {
            internal State트리스탄Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", script: "$52010064_QD__main__0$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script02 : TriggerState {
            internal State트리스탄Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", script: "$52010064_QD__main__1$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script03 : TriggerState {
            internal State트리스탄Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", script: "$52010064_QD__main__2$", duration: 3000, align: Align.Right);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Tristan_walking");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script04 : TriggerState {
            internal State트리스탄Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", script: "$52010064_QD__main__3$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script05 : TriggerState {
            internal State트리스탄Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", script: "$52010064_QD__main__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State트리스탄Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리스탄Script06 : TriggerState {
            internal State트리스탄Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003842, illustId: "Tristan_normal", script: "$52010064_QD__main__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마무리줌아웃(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리줌아웃 : TriggerState {
            internal State마무리줌아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetCinematicUI(type: 0);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit03 : TriggerState {
            internal StateQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.MoveUser(mapId: 52010052, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌아가 : TriggerState {
            internal State돌아가(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010052, portalId: 1);
                context.VisibleMyPc(visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State돌아가(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
