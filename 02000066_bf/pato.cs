namespace Maple2.Trigger._02000066_bf {
    public static class _pato {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {1299})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {103}, arg2: 70000107, arg3: 1, arg4: false, arg5: false);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {1601, 1602, 1603, 1604}, arg2: false);
                context.SetSkip(arg1: "StopCinematic");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateCinematic진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic진행 : TriggerState {
            internal StateCinematic진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__PATO__0$", arg4: 2);
                context.SetSkip(arg1: "StopCinematic");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2429)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 103, arg2: 70000107);
                context.CameraSelect(arg1: 301, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}