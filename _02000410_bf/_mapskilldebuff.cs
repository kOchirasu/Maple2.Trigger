namespace Maple2.Trigger._02000410_bf {
    public static class _mapskilldebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {444, 666}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new State전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonPlayTime() == 600) {
                    return new State1단계_70000103(context);
                }

                if (!context.NpcDetected(arg1: 700, arg2: new[] {0})) {
                    return new State스킬끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계_70000103 : TriggerState {
            internal State1단계_70000103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {444}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonPlayTime() == 780) {
                    return new State2단계_70000104(context);
                }

                if (!context.NpcDetected(arg1: 700, arg2: new[] {0})) {
                    return new State스킬끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계_70000104 : TriggerState {
            internal State2단계_70000104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {666}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonPlayTime() == 900) {
                    return new State스킬끄기(context);
                }

                if (!context.NpcDetected(arg1: 700, arg2: new[] {0})) {
                    return new State스킬끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬끄기 : TriggerState {
            internal State스킬끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {444, 666}, arg2: false);
                context.AddBuff(arg1: new[] {750}, arg2: 50004524, arg3: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}