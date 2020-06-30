using System;
using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000319}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000320}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000321}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Block", value: 1)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 0);
                    context.State = new StateBlock_1(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 2)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 0);
                    context.State = new StateBlock_2(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 3)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 0);
                    context.State = new StateBlock_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1114})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1019}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000319}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1117}, arg2: false);
                    context.State = new StateCableOn_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1115})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1020}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000320}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1117}, arg2: false);
                    context.State = new StateCableOn_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1116})) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1021}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000321}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1117}, arg2: false);
                    context.State = new StateCableOn_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_19 : TriggerState {
            internal StateCableOn_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000319}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000319}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(1974.56885f, 372.1966f, 289f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_20 : TriggerState {
            internal StateCableOn_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000320}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000320}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(3971.3916f, -4325.10742f, 1492f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_21 : TriggerState {
            internal StateCableOn_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000321}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000321}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(3528.33643f, 2824.1394f, 2528f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19 : TriggerState {
            internal StateCableDelay_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1019}, arg2: true);
                    context.State = new StateCableOff_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20 : TriggerState {
            internal StateCableDelay_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1020}, arg2: true);
                    context.State = new StateCableOff_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21 : TriggerState {
            internal StateCableDelay_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1021}, arg2: true);
                    context.State = new StateCableOff_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_19 : TriggerState {
            internal StateCableOff_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900006, key: "Block", value: 1);
                    context.State = new StateEnd_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_20 : TriggerState {
            internal StateCableOff_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900006, key: "Block", value: 1);
                    context.State = new StateEnd_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_21 : TriggerState {
            internal StateCableOff_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900006, key: "Block", value: 1);
                    context.State = new StateEnd_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_04 : TriggerState {
            internal StateEnd_04(ITriggerContext context) : base(context) { }

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