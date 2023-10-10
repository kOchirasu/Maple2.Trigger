using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._83000002_colosseum {
    public static class _start {
        public class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001}, jobCode: 0)) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.DestroyMonster(spawnIds: new []{202, 203});
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_01 : TriggerState {
            internal StateCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCinematic_01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_01_01 : TriggerState {
            internal StateCinematic_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_02 : TriggerState {
            internal StateCinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003, 4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_03 : TriggerState {
            internal StateCinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCinematic_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_05 : TriggerState {
            internal StateCinematic_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4005, 4006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic_07 : TriggerState {
            internal StateCinematic_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$83000002_COLOSSEUM__START__0$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetCinematicUI(type: 0);
                    context.CameraReset(interpolationTime: 0f);
                    return new StateEndCinematic_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetCinematicUI(type: 0);
                    context.CameraReset(interpolationTime: 0f);
                    return new State대화Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화Delay : TriggerState {
            internal State대화Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateEndCinematic_01(context);
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic_01 : TriggerState {
            internal StateEndCinematic_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.TalkNpc(spawnId: 203);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    context.MoveUserToPos(position: new Vector3(300f, -225f, 1500f), rotation: new Vector3(0f, 0f, 270f));
                    return new State대화Delay(context);
                }

                if (context.GetUserValue(key: "DungeonPlayType") == 1) {
                    return new StateNewGame(context);
                }

                if (context.GetUserValue(key: "DungeonPlayType") == 2) {
                    return new StateContinueGame(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNewGame : TriggerState {
            internal StateNewGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "새로 시작하기를 설정했습니다.");
                context.SetUserValue(triggerId: 900001, key: "MainStart", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateContinueGame : TriggerState {
            internal StateContinueGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "이어하기를 설정했습니다.");
                context.DungeonDisableRanking();
                context.SetUserValue(triggerId: 900001, key: "MainStart", value: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
