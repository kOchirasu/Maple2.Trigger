using System;
using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000313}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000314}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000315}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000316}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000317}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000318}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Block", value: 1)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateBlock_1(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 2)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateBlock_2(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 3)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateBlock_3(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 4)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateBlock_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1110})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1013}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000313}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.State = new StateCableOn_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1111})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1014}, arg2: true);
                    context.SetVisibleBreakableObject(arg1: new int[] {1015}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000314}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000315}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.State = new StateCableOn_14_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1112})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1016}, arg2: true);
                    context.SetVisibleBreakableObject(arg1: new int[] {1017}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000316}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000317}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.State = new StateCableOn_16_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_4 : TriggerState {
            internal StateBlock_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1113})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1018}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000318}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.State = new StateCableOn_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_13 : TriggerState {
            internal StateCableOn_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000313}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000313}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-2514.072f, 3816.40259f, 1500f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_14_15 : TriggerState {
            internal StateCableOn_14_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000314}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000314}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000315}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-3524.431f, -1479.53162f, 137f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_14(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000315}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000314}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000315}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-1478.22412f, -4127.897f, 137f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_16_17 : TriggerState {
            internal StateCableOn_16_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000316}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000316}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000317}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-848.5522f, -7473.63f, 2690f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_16(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000317}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000316}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000317}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(1372.17615f, -8612.513f, 2690f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_18 : TriggerState {
            internal StateCableOn_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000318}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000318}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-840.132935f, 6427.83936f, 1640f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13 : TriggerState {
            internal StateCableDelay_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1013}, arg2: true);
                    context.State = new StateCableOff_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14 : TriggerState {
            internal StateCableDelay_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1014}, arg2: true);
                    context.State = new StateCableOff_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15 : TriggerState {
            internal StateCableDelay_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1015}, arg2: true);
                    context.State = new StateCableOff_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16 : TriggerState {
            internal StateCableDelay_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1016}, arg2: true);
                    context.State = new StateCableOff_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17 : TriggerState {
            internal StateCableDelay_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1017}, arg2: true);
                    context.State = new StateCableOff_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18 : TriggerState {
            internal StateCableDelay_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1018}, arg2: true);
                    context.State = new StateCableOff_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_13 : TriggerState {
            internal StateCableOff_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 1);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_14 : TriggerState {
            internal StateCableOff_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 1);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_15 : TriggerState {
            internal StateCableOff_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 2);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_16 : TriggerState {
            internal StateCableOff_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 1);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_17 : TriggerState {
            internal StateCableOff_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 2);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_18 : TriggerState {
            internal StateCableOff_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 3);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_03 : TriggerState {
            internal StateEnd_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}