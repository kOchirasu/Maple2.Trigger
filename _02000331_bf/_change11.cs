namespace Maple2.Trigger._02000331_bf {
    public static class _change11 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9022, arg2: new[] {602})) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new[] {990})) {
                    return new State분기점(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9030, arg2: new[] {999})) {
                    return new State보스전투(context);
                }

                if (context.MonsterDead(arg1: new[] {602})) {
                    return new State교체딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스전투 : TriggerState {
            internal State보스전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new State전투종료(context);
                }

                if (context.MonsterDead(arg1: new[] {602})) {
                    return new State교체딜레이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투종료 : TriggerState {
            internal State전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9022, arg2: new[] {602})) {
                    return new State디펜스성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디펜스성공 : TriggerState {
            internal State디펜스성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State교체딜레이 : TriggerState {
            internal State교체딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State교체쓰러짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교체쓰러짐 : TriggerState {
            internal State교체쓰러짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {612});
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9020, arg2: new[] {600})) {
                    return new State교체일어남(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교체일어남 : TriggerState {
            internal State교체일어남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 612, arg2: 210);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}