namespace Maple2.Trigger._02000334_bf {
    public static class _wave_01_warning {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new[] {150})) {
                    return new State1차타이머(context);
                }

                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "30", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
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
                context.MoveNpc(arg1: 190, arg2: "MS2PatrolData_3501");
                context.SetConversation(arg1: 1, arg2: 190, script: "$02000334_BF__WAVE__0$", arg4: 3);
                context.CreateMonster(arg1: new[] {991, 992, 993}, arg2: true);
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateCamera복구(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera복구 : TriggerState {
            internal StateCamera복구(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98006}, arg2: true);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_3502");
                context.AddBuff(arg1: new[] {90001}, arg2: 70000068, arg3: 1);
                context.SetConversation(arg1: 1, arg2: 199, script: "$02000334_BF__WAVE__1$", arg4: 3);
                context.CameraSelectPath(pathIds: new[] {8017}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}