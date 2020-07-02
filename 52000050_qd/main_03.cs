namespace Maple2.Trigger._52000050_qd {
    public static class _main_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10003042}, arg3: new byte[] {2})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.AddBuff(arg1: new[] {199}, arg2: 70000095, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State자베스대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사01 : TriggerState {
            internal State자베스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000050_QD__MAIN_03__0$", arg4: 3);
                context.SetSkip(arg1: "자베스대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State브라보대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자베스대사01스킵 : TriggerState {
            internal State자베스대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State브라보대사01(context);
            }

            public override void OnExit() { }
        }

        private class State브라보대사01 : TriggerState {
            internal State브라보대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000050_QD__MAIN_03__1$", arg4: 3);
                context.SetSkip(arg1: "브라보대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State제이시대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State브라보대사01스킵 : TriggerState {
            internal State브라보대사01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State제이시대사01(context);
            }

            public override void OnExit() { }
        }

        private class State제이시대사01 : TriggerState {
            internal State제이시대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000515, arg3: "$52000050_QD__MAIN_03__2$", arg4: 5);
                context.SetSkip(arg1: "제이시대사01스킵");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제이시대사01스킵 : TriggerState {
            internal State제이시대사01스킵(ITriggerContext context) : base(context) { }

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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
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