namespace Maple2.Trigger._02000066_bf {
    public static class _pato {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{1299})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{103}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{1601, 1602, 1603, 1604}, arg2: false);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__PATO__0$", arg4: 2);
                context.SetSkip(state: new StateStopCinematic(context));
            }

            public override TriggerState? Execute() {
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
                context.RemoveBuff(boxId: 103, skillId: 70000107);
                context.CameraSelect(triggerId: 301, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
