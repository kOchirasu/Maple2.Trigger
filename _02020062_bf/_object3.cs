namespace Maple2.Trigger._02020062_bf {
    public static class _object3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 0);
                context.SetInteractObject(arg1: new[] {12000109}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 1) {
                    return new State레버3_가이드메시지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_가이드메시지 : TriggerState {
            internal State레버3_가이드메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {723}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new State대기(context);
                }

                if (context.UserDetected(arg1: new[] {9013})) {
                    context.SetEventUI(arg1: 1, arg2: "$02020062_BF__OBJECT3__0$", arg3: 5000, arg4: "9013");
                    return new State레버3_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_체크 : TriggerState {
            internal State레버3_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {713})) {
                    return new State레버3_발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_발동 : TriggerState {
            internal State레버3_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000109}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02020062_BF__OBJECT3__1$", arg3: 5000, arg4: "9013");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000109}, arg2: 0)) {
                    return new State레버3_몬스터등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_몬스터등장 : TriggerState {
            internal State레버3_몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new State레버3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성 : TriggerState {
            internal State레버3_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000109}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2 && context.MonsterDead(arg1: new[] {701})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000109}, arg2: 0)) {
                    return new State레버3_재활성_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버3_재활성_대기 : TriggerState {
            internal State레버3_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2 && context.MonsterDead(arg1: new[] {701})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new State레버3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5201}, arg2: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 2);
                context.DestroyMonster(arg1: new[] {723}, arg2: false);
                context.SetInteractObject(arg1: new[] {12000109}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}