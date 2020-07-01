using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000304, 12000305, 12000306}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    context.State = new StateBlock_1(context);
                    return;
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    context.State = new StateBlock_2(context);
                    return;
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
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
                if (context.MonsterDead(arg1: new[] {1104})) {
                    context.SetVisibleBreakableObject(arg1: new[] {1004}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000304}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1107, 1108, 1109}, arg2: false);
                    context.State = new StateCableOn_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1105})) {
                    context.SetVisibleBreakableObject(arg1: new[] {1005}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000305}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1107, 1108, 1109}, arg2: false);
                    context.State = new StateCableOn_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1106})) {
                    context.SetVisibleBreakableObject(arg1: new[] {1006}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000306}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1107, 1108, 1109}, arg2: false);
                    context.State = new StateCableOn_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_04 : TriggerState {
            internal StateCableOn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000304}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000304}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-12687.7676f, -1071.39685f, 2530f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_05 : TriggerState {
            internal StateCableOn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000305}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000305}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-11673.0137f, -6377.65674f, 1639f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_06 : TriggerState {
            internal StateCableOn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000306}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000306}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-11221.6494f, 6215.7334f, 433f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04 : TriggerState {
            internal StateCableDelay_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1004}, arg2: true);
                    context.State = new StateCableOff_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05 : TriggerState {
            internal StateCableDelay_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1005}, arg2: true);
                    context.State = new StateCableOff_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06 : TriggerState {
            internal StateCableDelay_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1006}, arg2: true);
                    context.State = new StateCableOff_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_04 : TriggerState {
            internal StateCableOff_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 1);
                    context.State = new StateEnd_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_05 : TriggerState {
            internal StateCableOff_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 2);
                    context.State = new StateEnd_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_06 : TriggerState {
            internal StateCableOff_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 3);
                    context.State = new StateEnd_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_01 : TriggerState {
            internal StateEnd_01(ITriggerContext context) : base(context) { }

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