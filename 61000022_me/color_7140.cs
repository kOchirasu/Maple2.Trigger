namespace Maple2.Trigger._61000022_me {
    public static class _color_7140 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Color14", value: 10);
                context.SetMesh(triggerIds: new []{814}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{914, 1014}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ColorStart") == 1) {
                    return new StateYellowBefore(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateYellowBefore : TriggerState {
            internal StateYellowBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{814}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{914, 1014}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 3) {
                    // return new StateYellowtoRed(context);
                    return null;
                }

                if (context.GetUserValue(key: "Color14") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color14") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedBefore : TriggerState {
            internal StateRedBefore(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1014}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{914, 814}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color14") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGreenAfter : TriggerState {
            internal StateGreenAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{914}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 3) {
                    return new StateRedAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color14") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateYellowAfter : TriggerState {
            internal StateYellowAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{814}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{914}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1014}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 3) {
                    return new StateRedAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color14") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRedAfter : TriggerState {
            internal StateRedAfter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1014}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{914}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{814}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 1) {
                    return new StateYellowAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 2) {
                    return new StateGreenAfter(context);
                }

                if (context.GetUserValue(key: "Color14") == 4) {
                    return new StateClear(context);
                }

                if (context.GetUserValue(key: "Color14") == 0) {
                    return new StateReset(context);
                }

                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{914}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{814}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{1014}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateRegen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRegen : TriggerState {
            internal StateRegen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{814}, visible: true, arg3: 400, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{914, 1014}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ColorStart", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Color14") == 5) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
