namespace Maple2.Trigger._52000046_qd {
    public static class _10003042 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003042}, arg3: new byte[] {2})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddBuff(arg1: new[] {199}, arg2: 70000095, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State자베스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script01 : TriggerState {
            internal State자베스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, script: "$52000046_QD__10003042__0$", arg4: 3);
                context.SetSkip(state: new State자베스Script01스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스Script01스킵 : TriggerState {
            internal State자베스Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State브라보Script01(context);
            }

            public override void OnExit() { }
        }

        private class State브라보Script01 : TriggerState {
            internal State브라보Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, script: "$52000046_QD__10003042__1$", arg4: 3);
                context.SetSkip(state: new State브라보Script01스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이시Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보Script01스킵 : TriggerState {
            internal State브라보Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State제이시Script01(context);
            }

            public override void OnExit() { }
        }

        private class State제이시Script01 : TriggerState {
            internal State제이시Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000515, script: "$52000046_QD__10003042__2$", arg4: 5);
                context.SetSkip(state: new State제이시Script01스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시Script01스킵 : TriggerState {
            internal State제이시Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.AddBuff(arg1: new[] {199}, arg2: 70000096, arg3: 1);
                context.MoveUser(arg1: 52000046, arg2: 2);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 301, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_9000");
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