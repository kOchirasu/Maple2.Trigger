namespace Maple2.Trigger._52010038_qd {
    public static class _heal_1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001258, 10001259, 10001260, 10001261, 10001262, 10001263, 10001264, 10001265}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WoundStart") == 1) {
                    return new State랜덤조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤조건 : TriggerState {
            internal State랜덤조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001258체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001259체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001260체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001261체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001262체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001263체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001264체크(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State10001265체크(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001258체크 : TriggerState {
            internal State10001258체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001258}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001258생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001258생성 : TriggerState {
            internal State10001258생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001258}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001259체크 : TriggerState {
            internal State10001259체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001259}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001259생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001259생성 : TriggerState {
            internal State10001259생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001259}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001260체크 : TriggerState {
            internal State10001260체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001260}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001260생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001260생성 : TriggerState {
            internal State10001260생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001260}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001261체크 : TriggerState {
            internal State10001261체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001261}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001261생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001261생성 : TriggerState {
            internal State10001261생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001261}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001262체크 : TriggerState {
            internal State10001262체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001262}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001262생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001262생성 : TriggerState {
            internal State10001262생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001262}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001263체크 : TriggerState {
            internal State10001263체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001263}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001263생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001263생성 : TriggerState {
            internal State10001263생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001263}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001264체크 : TriggerState {
            internal State10001264체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001264}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001264생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001264생성 : TriggerState {
            internal State10001264생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001264}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001265체크 : TriggerState {
            internal State10001265체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001265}, arg2: 1)) {
                    return new State랜덤조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001265생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001265생성 : TriggerState {
            internal State10001265생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001265}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new State랜덤조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}