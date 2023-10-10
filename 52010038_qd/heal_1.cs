namespace Maple2.Trigger._52010038_qd {
    public static class _heal_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001258, 10001259, 10001260, 10001261, 10001262, 10001263, 10001264, 10001265}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WoundStart") == 1) {
                    return new StateRandom조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom조건 : TriggerState {
            internal StateRandom조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 13)) {
                    return new State10001258체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001259체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001260체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001261체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001262체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001263체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001264체크(context);
                }

                if (context.RandomCondition(rate: 13)) {
                    return new State10001265체크(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001258체크 : TriggerState {
            internal State10001258체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001258}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001258Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001258Creation : TriggerState {
            internal State10001258Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001258}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001259체크 : TriggerState {
            internal State10001259체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001259}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001259Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001259Creation : TriggerState {
            internal State10001259Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001259}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001260체크 : TriggerState {
            internal State10001260체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001260}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001260Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001260Creation : TriggerState {
            internal State10001260Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001260}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001261체크 : TriggerState {
            internal State10001261체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001261}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001261Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001261Creation : TriggerState {
            internal State10001261Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001261}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001262체크 : TriggerState {
            internal State10001262체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001262}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001262Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001262Creation : TriggerState {
            internal State10001262Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001262}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001263체크 : TriggerState {
            internal State10001263체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001263}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001263Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001263Creation : TriggerState {
            internal State10001263Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001263}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001264체크 : TriggerState {
            internal State10001264체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001264}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001264Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001264Creation : TriggerState {
            internal State10001264Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001264}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001265체크 : TriggerState {
            internal State10001265체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001265}, arg2: 1)) {
                    return new StateRandom조건(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new State10001265Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10001265Creation : TriggerState {
            internal State10001265Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001265}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRandom조건(context);
                }

                if (context.GetUserValue(key: "WoundEnd") == 1) {
                    context.SetUserValue(triggerId: 993001, key: "WoundStart", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
