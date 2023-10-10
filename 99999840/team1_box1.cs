namespace Maple2.Trigger._99999840 {
    public static class _team1_box1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 901, value: false);
                context.SetInteractObject(interactIds: new []{10002175}, state: 0, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 911) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 912) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 913) == true) {
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
                context.SetInteractObject(interactIds: new []{10002175}, state: 1, arg3: false);
                context.SetInteractObject(interactIds: new []{10002176}, state: 1, arg3: false);
                context.SetInteractObject(interactIds: new []{10002177}, state: 1, arg3: false);
                context.SetInteractObject(interactIds: new []{10002178}, state: 1, arg3: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 911) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 912) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 913) == true) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002175}, arg2: 0)) {
                    return new State애디셔널_중첩1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State애디셔널_중첩1 : TriggerState {
            internal State애디셔널_중첩1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(id: 901, value: true);
                context.AddBuff(boxIds: new []{9001}, skillId: 70002511, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 911) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 912) == true) {
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 913) == true) {
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
                context.AddBuff(boxIds: new []{9001}, skillId: 70002511, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
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
                context.AddBuff(boxIds: new []{9001}, skillId: 70002511, level: 1, arg5: false);
            }

            public override TriggerState? Execute() {
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
                context.SetInteractObject(interactIds: new []{10002175}, state: 0, arg3: false);
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
