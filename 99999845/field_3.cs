using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000313, 12000314, 12000315, 12000316, 12000317, 12000318}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateBlock_3(context);
                }

                if (context.GetUserValue(key: "Block") == 4) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateBlock_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1110})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1013}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000313}, state: 1);
                    context.CreateMonster(spawnIds: new []{1114, 1115, 1116}, arg2: false);
                    return new StateCableOn_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1111})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1014, 1015}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000314, 12000315}, state: 1);
                    context.CreateMonster(spawnIds: new []{1114, 1115, 1116}, arg2: false);
                    return new StateCableOn_14_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1112})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1016, 1017}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000316, 12000317}, state: 1);
                    context.CreateMonster(spawnIds: new []{1114, 1115, 1116}, arg2: false);
                    return new StateCableOn_16_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_4 : TriggerState {
            internal StateBlock_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1113})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1018}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000318}, state: 1);
                    context.CreateMonster(spawnIds: new []{1114, 1115, 1116}, arg2: false);
                    return new StateCableOn_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_13 : TriggerState {
            internal StateCableOn_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000313}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000313}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-2514.072f, 3816.40259f, 1500f));
                    return new StateCableDelay_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_14_15 : TriggerState {
            internal StateCableOn_14_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000314}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000314, 12000315}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-3524.431f, -1479.53162f, 137f));
                    return new StateCableDelay_14(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000315}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000314, 12000315}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-1478.22412f, -4127.897f, 137f));
                    return new StateCableDelay_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_16_17 : TriggerState {
            internal StateCableOn_16_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000316}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000316, 12000317}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-848.5522f, -7473.63f, 2690f));
                    return new StateCableDelay_16(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000317}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000316, 12000317}, state: 2);
                    context.MoveUserToPos(position: new Vector3(1372.17615f, -8612.513f, 2690f));
                    return new StateCableDelay_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_18 : TriggerState {
            internal StateCableOn_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000318}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000318}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-840.132935f, 6427.83936f, 1640f));
                    return new StateCableDelay_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13 : TriggerState {
            internal StateCableDelay_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1013}, enabled: true);
                    return new StateCableOff_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14 : TriggerState {
            internal StateCableDelay_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1014}, enabled: true);
                    return new StateCableOff_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15 : TriggerState {
            internal StateCableDelay_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1015}, enabled: true);
                    return new StateCableOff_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16 : TriggerState {
            internal StateCableDelay_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1016}, enabled: true);
                    return new StateCableOff_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17 : TriggerState {
            internal StateCableDelay_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1017}, enabled: true);
                    return new StateCableOff_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18 : TriggerState {
            internal StateCableDelay_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1018}, enabled: true);
                    return new StateCableOff_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_13 : TriggerState {
            internal StateCableOff_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 1);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_14 : TriggerState {
            internal StateCableOff_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 1);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_15 : TriggerState {
            internal StateCableOff_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 2);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_16 : TriggerState {
            internal StateCableOff_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 1);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_17 : TriggerState {
            internal StateCableOff_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 2);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_18 : TriggerState {
            internal StateCableOff_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 3);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_03 : TriggerState {
            internal StateEnd_03(ITriggerContext context) : base(context) { }

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
