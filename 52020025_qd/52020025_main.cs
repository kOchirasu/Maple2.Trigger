namespace Maple2.Trigger._52020025_qd {
    public static class _52020025_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1001}, arg2: true);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateCamera_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_시작 : TriggerState {
            internal StateCamera_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "으아아악!!!", arg4: 2);
                context.SetSceneSkip(state: new StateCamera_종료(context), arg2: "exit");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetMesh(arg1: new[] {1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_PC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_PC : TriggerState {
            internal StateCamera_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_BossSpawn : TriggerState {
            internal StateCamera_BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Bossmove");
                context.SetNpcRotation(arg1: 0, arg2: 180);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "응??", arg4: 2);
                context.CameraSelect(arg1: 502, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera_PC도망Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_PC도망Prepare : TriggerState {
            internal StateCamera_PC도망Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 0, arg2: 180);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "튀자!!", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCamera_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_종료 : TriggerState {
            internal StateCamera_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CameraReset(interpolationTime: 0.1f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State달리기시작(context);
            }

            public override void OnExit() { }
        }

        private class State달리기시작 : TriggerState {
            internal State달리기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetLocalCamera(cameraId: 511, enable: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PCrun");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Bossrun");
                context.SetEventUI(arg1: 1, arg2: "무서운 몬스터로부터 도망치세요", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
                    return new State탈출Success(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈출Success : TriggerState {
            internal State탈출Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG\Common\ScreenMask\Eff_CameraMasking_white.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02020008, arg2: 6001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}