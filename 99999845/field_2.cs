using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000307, 12000308, 12000309, 12000310, 12000311, 12000312}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    return new StateBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    return new StateBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
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
                if (context.MonsterDead(spawnIds: new []{1107})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1007, 1008}, arg2: true);
                    context.SetInteractObject(interactIds: new []{12000307, 12000308}, state: 1);
                    context.CreateMonster(spawnIds: new []{1110, 1111, 1112, 1113}, arg2: false);
                    return new StateCableOn_07_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1108})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1009, 1010}, arg2: true);
                    context.SetInteractObject(interactIds: new []{12000309, 12000310}, state: 1);
                    context.CreateMonster(spawnIds: new []{1110, 1111, 1112, 1113}, arg2: false);
                    return new StateCableOn_09_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1109})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1011, 1012}, arg2: true);
                    context.SetInteractObject(interactIds: new []{12000311, 12000312}, state: 1);
                    context.CreateMonster(spawnIds: new []{1110, 1111, 1112, 1113}, arg2: false);
                    return new StateCableOn_11_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_07_08 : TriggerState {
            internal StateCableOn_07_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000307}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000307, 12000308}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-8476.297f, -3480.99072f, 1343f));
                    return new StateCableDelay_07(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000308}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000307, 12000308}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-6726.70264f, -377.953552f, 1343f));
                    return new StateCableDelay_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_09_10 : TriggerState {
            internal StateCableOn_09_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000309}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000309, 12000310}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-8321.446f, -7475.03271f, 135f));
                    return new StateCableDelay_09(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000310}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000309, 12000310}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-6576.207f, -9063.119f, 135f));
                    return new StateCableDelay_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_11_12 : TriggerState {
            internal StateCableOn_11_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000311}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000311, 12000312}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-7723.194f, 5673.29346f, 2690f));
                    return new StateCableDelay_11(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000312}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000311, 12000312}, state: 2);
                    context.MoveUserToPos(position: new Vector3(-6276.41748f, 8028.68164f, 2690f));
                    return new StateCableDelay_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07 : TriggerState {
            internal StateCableDelay_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1007}, enabled: true);
                    return new StateCableOff_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08 : TriggerState {
            internal StateCableDelay_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1008}, enabled: true);
                    return new StateCableOff_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09 : TriggerState {
            internal StateCableDelay_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1009}, enabled: true);
                    return new StateCableOff_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10 : TriggerState {
            internal StateCableDelay_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1010}, enabled: true);
                    return new StateCableOff_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11 : TriggerState {
            internal StateCableDelay_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1011}, enabled: true);
                    return new StateCableOff_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12 : TriggerState {
            internal StateCableDelay_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1012}, enabled: true);
                    return new StateCableOff_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_07 : TriggerState {
            internal StateCableOff_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 2);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_08 : TriggerState {
            internal StateCableOff_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 1);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_09 : TriggerState {
            internal StateCableOff_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 2);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_10 : TriggerState {
            internal StateCableOff_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 3);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_11 : TriggerState {
            internal StateCableOff_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 1);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_12 : TriggerState {
            internal StateCableOff_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 4);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_02 : TriggerState {
            internal StateEnd_02(ITriggerContext context) : base(context) { }

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
