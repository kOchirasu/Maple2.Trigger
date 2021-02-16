namespace Maple2.Trigger._02000334_bf {
    public static class _wave_02_warning {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new[] {151})) {
                    return new State1차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State돌격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌격 : TriggerState {
            internal State돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98001}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 190, script: "$02000334_BF__WAVE__2$", arg4: 3);
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_3501");
                context.CreateMonster(arg1: new[] {991, 993, 994}, arg2: true);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateCamera_복구(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_복구 : TriggerState {
            internal StateCamera_복구(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98006}, arg2: true);
                context.AddBuff(arg1: new[] {90001}, arg2: 70000068, arg3: 1);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000334_BF__WAVE__3$", arg4: 3);
                context.CameraSelectPath(pathIds: new[] {8017}, arg2: false);
                context.SetTimer(id: "15", arg2: 15);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State돌격2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌격2 : TriggerState {
            internal State돌격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98001}, arg2: true);
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_3501");
                context.SetConversation(arg1: 1, arg2: 190, script: "$02000334_BF__WAVE__4$", arg4: 3);
                context.CreateMonster(arg1: new[] {992, 995}, arg2: true);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateCamera_복구2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_복구2 : TriggerState {
            internal StateCamera_복구2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98006}, arg2: true);
                context.AddBuff(arg1: new[] {90001}, arg2: 70000068, arg3: 1);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000334_BF__WAVE__5$", arg4: 3);
                context.CameraSelectPath(pathIds: new[] {8017}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}