using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_5 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000322}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 0);
                    return new StateBlock_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1117})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1022}, arg2: true);
                    context.SetInteractObject(interactIds: new []{12000322}, state: 1);
                    // return new StateCableOn_04(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_22 : TriggerState {
            internal StateCableOn_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000322}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000322}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-12687.7676f, -1071.39685f, 2530f));
                    return new StateCableDelay_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04 : TriggerState {
            internal StateCableDelay_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1004}, enabled: true);
                    return new StateCableOff_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05 : TriggerState {
            internal StateCableDelay_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1005}, enabled: true);
                    return new StateCableOff_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06 : TriggerState {
            internal StateCableDelay_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1006}, enabled: true);
                    return new StateCableOff_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_04 : TriggerState {
            internal StateCableOff_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.MoveUserToPos(position: new Vector3(-9825f, -1425f, 1350f));
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 1);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_05 : TriggerState {
            internal StateCableOff_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.MoveUserToPos(position: new Vector3(-9375f, -9225f, 150f));
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 2);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_06 : TriggerState {
            internal StateCableOff_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.MoveUserToPos(position: new Vector3(-8475f, 7275f, 2700f));
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 3);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_01 : TriggerState {
            internal StateEnd_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1004, 1005, 1006}, arg2: false);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
