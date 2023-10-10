using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100070_qd {
    public static class _52100070 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 400, enabled: true);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007}, visible: false);
                context.VisibleMyPc(visible: false);
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1000})) {
                    return new StateNarration01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration01 : TriggerState {
            internal StateNarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 9, script: "$52100070_QD__52100070__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State암전1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전1 : TriggerState {
            internal State암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateCamera_Move_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_Move_01 : TriggerState {
            internal StateCamera_Move_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{400, 401}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52100070_QD__52100070__1$", script: "$52100070_QD__52100070__2$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateEndCinematic(context));
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State전경Camera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경Camera1 : TriggerState {
            internal State전경Camera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enabled: true);
                context.CameraSelectPath(pathIds: new []{600, 601}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State퐈이야(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퐈이야 : TriggerState {
            internal State퐈이야(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5004, 5007}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateIshuraCamera1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraCamera1 : TriggerState {
            internal StateIshuraCamera1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{402, 403}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateIshuraCamera2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraCamera2 : TriggerState {
            internal StateIshuraCamera2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enabled: true);
                context.CameraSelectPath(pathIds: new []{500, 501}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateIshuraCamera3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraCamera3 : TriggerState {
            internal StateIshuraCamera3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 404, enabled: false);
                context.CameraSelectPath(pathIds: new []{404, 405}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateIshuraCamera4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshuraCamera4 : TriggerState {
            internal StateIshuraCamera4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 406, enabled: false);
                context.CameraSelectPath(pathIds: new []{406, 407}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State렌듀비앙이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙이동1 : TriggerState {
            internal State렌듀비앙이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 0.5f, endScale: 0.5f, duration: 50.0f, interpolator: 1);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_11003867");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유페리아이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아이동1 : TriggerState {
            internal State유페리아이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_11003868");
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateIshura이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동1 : TriggerState {
            internal StateIshura이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005, 5006}, visible: true);
                context.SetTimeScale(enabled: true, startScale: 0.3f, endScale: 0.3f, duration: 50.0f, interpolator: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_11003866");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007}, visible: false);
                context.SetTimeScale(enabled: false, startScale: 0.5f, endScale: 0.5f, duration: 50.0f, interpolator: 1);
                context.DestroyMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52010068, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
