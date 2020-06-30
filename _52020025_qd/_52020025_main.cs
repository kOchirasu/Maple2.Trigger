using System;

namespace Maple2.Trigger._52020025_qd {
    public static class _52020025_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State감지(context);

        private class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1001}, arg2: true);
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetAgent(arg1: "9003", arg2: true);
                context.SetAgent(arg1: "9004", arg2: true);
                context.SetAgent(arg1: "9005", arg2: true);
                context.SetAgent(arg1: "9006", arg2: true);
                context.SetAgent(arg1: "9007", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
                    context.State = new State카메라_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_시작 : TriggerState {
            internal State카메라_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "으아아악!!!", arg4: 2);
                context.SetSceneSkip(arg1: "카메라_종료", arg2: "exit");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetMesh(arg1: new int[] {1001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_PC(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_PC : TriggerState {
            internal State카메라_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_보스등장 : TriggerState {
            internal State카메라_보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Bossmove");
                context.SetNpcRotation(arg1: 0, arg2: 180);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "응??", arg4: 2);
                context.CameraSelect(arg1: 502, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라_PC도망준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_PC도망준비 : TriggerState {
            internal State카메라_PC도망준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 0, arg2: 180);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "튀자!!", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라_종료 : TriggerState {
            internal State카메라_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CameraReset(interpolationTime: 0.1f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetAgent(arg1: "9003", arg2: false);
                context.SetAgent(arg1: "9004", arg2: false);
                context.SetAgent(arg1: "9005", arg2: false);
                context.SetAgent(arg1: "9006", arg2: false);
                context.SetAgent(arg1: "9007", arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State달리기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State달리기시작 : TriggerState {
            internal State달리기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetLocalCamera(cameraId: 511, enable: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PCrun");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Bossrun");
                context.SetEventUI(arg1: 1, arg2: "무서운 몬스터로부터 도망치세요", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "902")) {
                    context.State = new State탈출성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈출성공 : TriggerState {
            internal State탈출성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG\Common\ScreenMask\Eff_CameraMasking_white.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020008, arg2: 6001);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}