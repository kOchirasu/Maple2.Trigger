using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000304, 12000305, 12000306}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    return new StateBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    return new StateBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    return new StateBlock_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1104})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1004}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000304}, state: 1);
                    context.CreateMonster(spawnIds: new []{1107, 1108, 1109}, arg2: false);
                    return new StateCableOn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1105})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1005}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000305}, state: 1);
                    context.CreateMonster(spawnIds: new []{1107, 1108, 1109}, arg2: false);
                    return new StateCableOn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1106})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1006}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000306}, state: 1);
                    context.CreateMonster(spawnIds: new []{1107, 1108, 1109}, arg2: false);
                    return new StateCableOn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_04 : TriggerState {
            internal StateCableOn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000304}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000304}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-12687.7676f, -1071.39685f, 2530f));
                    return new StateCableDelay_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_05 : TriggerState {
            internal StateCableOn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000305}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000305}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-11673.0137f, -6377.65674f, 1639f));
                    return new StateCableDelay_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_06 : TriggerState {
            internal StateCableOn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000306}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000306}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-11221.6494f, 6215.7334f, 433f));
                    return new StateCableDelay_06(context);
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
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
