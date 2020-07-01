namespace Maple2.Trigger._52020009_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001266}, arg2: 0);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: false);
                context.SetEffect(arg1: new[] {5100, 5101, 5102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020}, arg3: new byte[] {2})) {
                    return new StateMeshOff(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020}, arg3: new byte[] {3})) {
                    return new StateMeshOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006}, arg2: true);
                context.SetMesh(arg1: new[] {8001}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "!", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206, 207})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001266}, arg2: 1);
                context.SetMesh(arg1: new[] {8001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000449}, arg2: 0)) {
                    return new StateMeshOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeshOff : TriggerState {
            internal StateMeshOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200020}, arg3: new byte[] {1})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}