namespace Maple2.Trigger._99999841 {
    public static class _team2_box1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 911, value: false);
                context.SetInteractObject(interactIds: new []{10002179}, state: 0, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "Start") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002179}, state: 1, arg3: false);
                context.SetInteractObject(interactIds: new []{10002180}, state: 1, arg3: false);
                context.SetInteractObject(interactIds: new []{10002181}, state: 1, arg3: false);
                context.SetInteractObject(interactIds: new []{10002182}, state: 1, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002179}, arg2: 0)) {
                    return new State애디셔널_중첩1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩1 : TriggerState {
            internal State애디셔널_중첩1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 911, value: true);
                context.AddBuff(boxIds: new []{9001}, skillId: 70002531, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new State애디셔널_중첩2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩2 : TriggerState {
            internal State애디셔널_중첩2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9001}, skillId: 70002531, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new State애디셔널_중첩3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩3 : TriggerState {
            internal State애디셔널_중첩3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9001}, skillId: 70002531, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 902) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 903) == true) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002179}, state: 0, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BadMob") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
