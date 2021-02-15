namespace Maple2.Trigger._52100070_qd {
    public static class _52100070 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 400, arg2: true);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.SetCinematicUI(arg1: 1);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1000})) {
                    return new StateNarration01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNarration01 : TriggerState {
            internal StateNarration01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 9, arg2: "$52100070_QD__52100070__0$");
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 0);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {400, 401}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52100070_QD__52100070__1$", desc: "$52100070_QD__52100070__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
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
                context.SetSkip(arg1: "연출끝");
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 600, arg2: true);
                context.CameraSelectPath(arg1: new[] {600, 601}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5001, 5002, 5004, 5007}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {402, 403}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 500, arg2: true);
                context.CameraSelectPath(arg1: new[] {500, 501}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 404, arg2: false);
                context.CameraSelectPath(arg1: new[] {404, 405}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 406, arg2: false);
                context.CameraSelectPath(arg1: new[] {406, 407}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetTimeScale(enable: true, startScale: 0.5f, endScale: 0.5f, duration: 50.0f, interpolator: 1);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_11003867");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_11003868");
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {5005, 5006}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 0.3f, endScale: 0.3f, duration: 50.0f, interpolator: 1);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_11003866");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCinematic끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic끝 : TriggerState {
            internal StateCinematic끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007}, arg2: false);
                context.SetTimeScale(enable: false, startScale: 0.5f, endScale: 0.5f, duration: 50.0f, interpolator: 1);
                context.DestroyMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.SetSkip();
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(isVisible: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52010068, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}