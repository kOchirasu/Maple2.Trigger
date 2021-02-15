namespace Maple2.Trigger._52020014_qd {
    public static class _52020014_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetMesh(arg1: new[] {9101, 9102}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {1}, arg2: false);
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010}, arg2: false);
                context.SetLadder(arg1: 10001, arg2: false, arg3: false);
                context.SetLadder(arg1: 10002, arg2: false, arg3: false);
                context.SetLadder(arg1: 10003, arg2: false, arg3: false);
                context.SetLadder(arg1: 10004, arg2: false, arg3: false);
                context.SetLadder(arg1: 10005, arg2: false, arg3: false);
                context.SetLadder(arg1: 10006, arg2: false, arg3: false);
                context.SetBreakable(arg1: new[] {10001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10002004, 10002005}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State1차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투 : TriggerState {
            internal State1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {904})) {
                    return new State2차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104, 105, 106}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105, 106})) {
                    return new StateLadder발견(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder발견 : TriggerState {
            internal StateLadder발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {9102}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {1}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {907})) {
                    return new State이펙트꺼주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트꺼주기 : TriggerState {
            internal State이펙트꺼주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {902})) {
                    return new State3차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 112}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {903})) {
                    return new State4차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투 : TriggerState {
            internal State4차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113, 114, 115}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114, 115})) {
                    return new State이공간레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간레버활성 : TriggerState {
            internal State이공간레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002004}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002004}, arg2: 0)) {
                    return new State이공간다리활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간다리활성 : TriggerState {
            internal State이공간다리활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010}, arg2: true, arg3: 0, arg4: 200, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {905})) {
                    return new StateLever힌트_Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever힌트_Camera : TriggerState {
            internal StateLever힌트_Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "이공간1차전투", arg2: "nextState");
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLever힌트_Camera대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever힌트_Camera대사 : TriggerState {
            internal StateLever힌트_Camera대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg3: "저 레버를 작동시키면 되는건가...?", arg4: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이공간1차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간1차전투 : TriggerState {
            internal State이공간1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
                context.CreateMonster(arg1: new[] {121, 122, 123}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "에고 웨폰을 모두 처치하고 레버를 작동시키세요.", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {906})) {
                    return new State이공간2차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간2차전투 : TriggerState {
            internal State이공간2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {124, 125, 126}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126})) {
                    return new StateLadder활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder활성 : TriggerState {
            internal StateLadder활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 10001, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 10002, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 10003, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 10004, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 10005, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 10006, arg2: true, arg3: true, arg4: 10);
                context.SetInteractObject(arg1: new[] {10002005}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002005}, arg2: 0)) {
                    return new State비밀의문(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비밀의문 : TriggerState {
            internal State비밀의문(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Camera리셋", arg2: "nextState");
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetBreakable(arg1: new[] {10001}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {9101}, arg2: false, arg3: 0, arg4: 0, arg5: 30f);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "Success이야!", arg4: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋 : TriggerState {
            internal StateCamera리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}