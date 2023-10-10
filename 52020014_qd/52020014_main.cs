namespace Maple2.Trigger._52020014_qd {
    public static class _52020014_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false);
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetMesh(triggerIds: new []{9101, 9102}, visible: true);
                context.SetVisibleBreakableObject(triggerIds: new []{1}, visible: false);
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010}, visible: false);
                context.SetLadder(triggerId: 10001, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 10002, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 10003, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 10004, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 10005, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 10006, visible: false, animationEffect: false);
                context.SetBreakable(triggerIds: new []{10001}, enabled: false);
                context.SetInteractObject(interactIds: new []{10002004, 10002005}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new State1차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차전투 : TriggerState {
            internal State1차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{904})) {
                    return new State2차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104, 105, 106}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105, 106})) {
                    return new StateLadder발견(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder발견 : TriggerState {
            internal StateLadder발견(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetMesh(triggerIds: new []{9102}, visible: false);
                context.SetVisibleBreakableObject(triggerIds: new []{1}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{907})) {
                    return new State이펙트꺼주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트꺼주기 : TriggerState {
            internal State이펙트꺼주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State3차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차전투 : TriggerState {
            internal State3차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 112}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new State4차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차전투 : TriggerState {
            internal State4차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{113, 114, 115}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114, 115})) {
                    return new State이공간레버활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간레버활성 : TriggerState {
            internal State이공간레버활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002004}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002004}, arg2: 0)) {
                    return new State이공간다리활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간다리활성 : TriggerState {
            internal State이공간다리활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010}, visible: true, arg3: 0, arg4: 200, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{905})) {
                    return new StateLever힌트_Camera(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever힌트_Camera : TriggerState {
            internal StateLever힌트_Camera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State이공간1차전투(context), arg2: "nextState");
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, script: "저 레버를 작동시키면 되는건가...?", arg4: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
                context.CreateMonster(spawnIds: new []{121, 122, 123}, arg2: true);
                context.SetEventUI(arg1: 1, script: "에고 웨폰을 모두 처치하고 레버를 작동시키세요.", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{906})) {
                    return new State이공간2차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이공간2차전투 : TriggerState {
            internal State이공간2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{124, 125, 126}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 122, 123, 124, 125, 126})) {
                    return new StateLadder활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder활성 : TriggerState {
            internal StateLadder활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 10001, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 10002, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 10003, visible: true, animationEffect: true, animationDelay: 4);
                context.SetLadder(triggerId: 10004, visible: true, animationEffect: true, animationDelay: 6);
                context.SetLadder(triggerId: 10005, visible: true, animationEffect: true, animationDelay: 8);
                context.SetLadder(triggerId: 10006, visible: true, animationEffect: true, animationDelay: 10);
                context.SetInteractObject(interactIds: new []{10002005}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002005}, arg2: 0)) {
                    return new State비밀의문(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비밀의문 : TriggerState {
            internal State비밀의문(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera리셋(context), arg2: "nextState");
                context.CameraSelect(triggerId: 501, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetBreakable(triggerIds: new []{10001}, enabled: true);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetMesh(triggerIds: new []{9101}, visible: false, arg3: 0, arg4: 0, arg5: 30f);
                context.SetConversation(type: 1, spawnId: 0, script: "Success이야!", arg4: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
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
