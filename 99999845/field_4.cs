using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_4 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000319, 12000320, 12000321}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    return new StateBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    return new StateBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
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
                if (context.MonsterDead(spawnIds: new []{1114})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1019}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000319}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117}, arg2: false);
                    return new StateCableOn_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1115})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1020}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000320}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117}, arg2: false);
                    return new StateCableOn_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1116})) {
                    context.SetVisibleBreakableObject(triggerIds: new []{1021}, visible: true);
                    context.SetInteractObject(interactIds: new []{12000321}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117}, arg2: false);
                    return new StateCableOn_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_19 : TriggerState {
            internal StateCableOn_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000319}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000319}, state: 2);
                    context.MoveUserToPos(position: new Vector3(1974.56885f, 372.1966f, 289f));
                    return new StateCableDelay_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_20 : TriggerState {
            internal StateCableOn_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000320}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000320}, state: 2);
                    context.MoveUserToPos(position: new Vector3(3971.3916f, -4325.10742f, 1492f));
                    return new StateCableDelay_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_21 : TriggerState {
            internal StateCableOn_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000321}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000321}, state: 2);
                    context.MoveUserToPos(position: new Vector3(3528.33643f, 2824.1394f, 2528f));
                    return new StateCableDelay_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19 : TriggerState {
            internal StateCableDelay_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1019}, enabled: true);
                    return new StateCableOff_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20 : TriggerState {
            internal StateCableDelay_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1020}, enabled: true);
                    return new StateCableOff_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21 : TriggerState {
            internal StateCableDelay_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1021}, enabled: true);
                    return new StateCableOff_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_19 : TriggerState {
            internal StateCableOff_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    return new StateEnd_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_20 : TriggerState {
            internal StateCableOff_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    return new StateEnd_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_21 : TriggerState {
            internal StateCableOff_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    return new StateEnd_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_04 : TriggerState {
            internal StateEnd_04(ITriggerContext context) : base(context) { }

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
