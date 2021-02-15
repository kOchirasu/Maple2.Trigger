namespace Maple2.Trigger._52000043_qd {
    public static class _50001453 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1003, 2003});
                context.SetAgent(arg1: new[] {9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: false);
                context.SetEffect(arg1: new[] {603, 604, 605}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50001453}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {1003, 2003});
                    return new StateStart조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart조건 : TriggerState {
            internal StateStart조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003, 2003}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001020}, arg2: 2);
                context.SetInteractObject(arg1: new[] {10001021}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001021}, arg2: 0)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {2100, 2101}, arg2: false);
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1004A");
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2004A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 29000121, arg3: "$52000043_QD__50001453__0$", arg4: 3);
                context.SetSkip(arg1: "NPCScript01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01스킵 : TriggerState {
            internal StateNPCScript01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타Script01(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script01 : TriggerState {
            internal State준타Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001453__1$", arg4: 3);
                context.SetSkip(arg1: "준타Script01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State준타Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01스킵 : TriggerState {
            internal State준타Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State준타Script02(context);
            }

            public override void OnExit() { }
        }

        private class State준타Script02 : TriggerState {
            internal State준타Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$52000043_QD__50001453__2$", arg4: 2);
                context.SetSkip(arg1: "준타Script02스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State틴차이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script02스킵 : TriggerState {
            internal State준타Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State틴차이Script01(context);
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01 : TriggerState {
            internal State틴차이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$52000043_QD__50001453__3$", arg4: 4);
                context.SetSkip(arg1: "틴차이Script01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State틴차이Script01스킵 : TriggerState {
            internal State틴차이Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateStopCinematic(context);
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1003, 2003});
                context.CreateMonster(arg1: new[] {1004, 2004}, arg2: false);
                context.SetAgent(arg1: new[] {9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 303, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2100, 2101})) {
                    return new StateCinematic02시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic02시작 : TriggerState {
            internal StateCinematic02시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetInteractObject(arg1: new[] {10001021}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1002C");
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData_2002C");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1004})) {
                    return new StateNPC교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체01 : TriggerState {
            internal StateNPC교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1004});
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {2004})) {
                    return new StateNPC교체02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체02 : TriggerState {
            internal StateNPC교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2004});
                context.CreateMonster(arg1: new[] {2003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStopCinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic2 : TriggerState {
            internal StateStopCinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
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