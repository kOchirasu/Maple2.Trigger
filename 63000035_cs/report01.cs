using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000035_cs {
    public static class _report01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 6000, 6001}, arg2: false);
                context.SetSound(arg1: 10000, arg2: false);
                context.SetSound(arg1: 10001, arg2: false);
                context.SetSound(arg1: 10002, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePlayOpeningMovie02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayOpeningMovie02 : TriggerState {
            internal StatePlayOpeningMovie02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieId: 2);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, arg2: "IsStop", arg3: "2")) {
                    return new StatePlayMovie01(context);
                }

                if (context.WaitTick(waitTick: 190000)) {
                    return new StatePlayMovie01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie01 : TriggerState {
            internal StatePlayMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePlayMovie02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie02 : TriggerState {
            internal StatePlayMovie02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Cut_Vivid_Dream.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, arg2: "IsStop", arg3: "1")) {
                    return new StateLodingDelay01(context);
                }

                if (context.WaitTick(waitTick: 77000)) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraWalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: true);
                context.SetSound(arg1: 10001, arg2: true);
                context.SetSound(arg1: 10002, arg2: true);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateOperator01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOperator01 : TriggerState {
            internal StateOperator01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001705, script: "$63000035_CS__REPORT01__0$", arg4: 6);
                context.SetSceneSkip(state: new StatePCTeleport01(context), arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateOperatorSkip01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOperatorSkip01 : TriggerState {
            internal StateOperatorSkip01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateOperator02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOperator02 : TriggerState {
            internal StateOperator02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001705, script: "$63000035_CS__REPORT01__1$", arg4: 6);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateOperatorSkip02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOperatorSkip02 : TriggerState {
            internal StateOperatorSkip02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMonitorOn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonitorOn01 : TriggerState {
            internal StateMonitorOn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 502, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateMonitorOn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonitorOn02 : TriggerState {
            internal StateMonitorOn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateMonitorOn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonitorOn03 : TriggerState {
            internal StateMonitorOn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 503, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKahnTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnTalk01 : TriggerState {
            internal StateKahnTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, script: "$63000035_CS__REPORT01__2$", arg4: 6);
                context.SetEffect(arg1: new[] {6001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateKahnTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnTalk02 : TriggerState {
            internal StateKahnTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateKahnTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateKahnTalk03 : TriggerState {
            internal StateKahnTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: true);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateKahnTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnTalk04 : TriggerState {
            internal StateKahnTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKahnTalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnTalk05 : TriggerState {
            internal StateKahnTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, script: "$63000035_CS__REPORT01__3$", arg4: 6);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateKahnTalk06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKahnTalk06 : TriggerState {
            internal StateKahnTalk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCTeleport01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCTeleport02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: false);
                context.SetSound(arg1: 10001, arg2: false);
                context.SetSound(arg1: 10002, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCTeleport03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport03 : TriggerState {
            internal StatePCTeleport03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000024, arg2: 2);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 504, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}