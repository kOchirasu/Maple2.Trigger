using System.Numerics;

namespace Maple2.Trigger._83000002_colosseum {
    public static class _start {
        public class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2001}, arg2: 0)) {
                    context.State = new State연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비 : TriggerState {
            internal State연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.DestroyMonster(arg1: new[] {202});
                context.DestroyMonster(arg1: new[] {203});
                context.CreateMonster(arg1: new[] {203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_01 : TriggerState {
            internal State연출_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출_01_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_01_01 : TriggerState {
            internal State연출_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_02 : TriggerState {
            internal State연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_03 : TriggerState {
            internal State연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_05 : TriggerState {
            internal State연출_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4005, 4006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출_07 : TriggerState {
            internal State연출_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007, 4008}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$83000002_COLOSSEUM__START__0$",
                    align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetProductionUI(arg1: 0);
                    context.CameraReset(interpolationTime: 0f);
                    context.State = new State연출끝_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetProductionUI(arg1: 0);
                    context.CameraReset(interpolationTime: 0f);
                    context.State = new State대화딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화딜레이 : TriggerState {
            internal State대화딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State연출끝_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출끝_01 : TriggerState {
            internal State연출끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.TalkNpc(spawnPointId: 203);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    context.State = new State대화딜레이(context);
                    return;
                }

                if (context.GetUserValue(key: "DungeonPlayType") == 1) {
                    context.State = new StateNewGame(context);
                    return;
                }

                if (context.GetUserValue(key: "DungeonPlayType") == 2) {
                    context.State = new StateContinueGame(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNewGame : TriggerState {
            internal StateNewGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "새로 시작하기를 설정했습니다.");
                context.SetUserValue(triggerId: 900001, key: "MainStart", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateContinueGame : TriggerState {
            internal StateContinueGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "이어하기를 설정했습니다.");
                context.DungeonDisableRanking();
                context.SetUserValue(triggerId: 900001, key: "MainStart", value: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}