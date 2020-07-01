using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _field_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000307, 12000308, 12000309, 12000310, 12000311, 12000312}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    context.State = new StateBlock_1(context);
                    return;
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    context.State = new StateBlock_2(context);
                    return;
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
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
                if (context.MonsterDead(arg1: new[] {1107})) {
                    context.SetVisibleBreakableObject(arg1: new[] {1007, 1008}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000307, 12000308}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113}, arg2: false);
                    context.State = new StateCableOn_07_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1108})) {
                    context.SetVisibleBreakableObject(arg1: new[] {1009, 1010}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000309, 12000310}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113}, arg2: false);
                    context.State = new StateCableOn_09_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1109})) {
                    context.SetVisibleBreakableObject(arg1: new[] {1011, 1012}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000311, 12000312}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113}, arg2: false);
                    context.State = new StateCableOn_11_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_07_08 : TriggerState {
            internal StateCableOn_07_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000307}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000307, 12000308}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-8476.297f, -3480.99072f, 1343f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_07(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000308}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000307, 12000308}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-6726.70264f, -377.953552f, 1343f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_09_10 : TriggerState {
            internal StateCableOn_09_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000309}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000309, 12000310}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-8321.446f, -7475.03271f, 135f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_09(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000310}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000309, 12000310}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-6576.207f, -9063.119f, 135f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_11_12 : TriggerState {
            internal StateCableOn_11_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000311}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000311, 12000312}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-7723.194f, 5673.29346f, 2690f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_11(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000312}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000311, 12000312}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-6276.41748f, 8028.68164f, 2690f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07 : TriggerState {
            internal StateCableDelay_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1007}, arg2: true);
                    context.State = new StateCableOff_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08 : TriggerState {
            internal StateCableDelay_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1008}, arg2: true);
                    context.State = new StateCableOff_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09 : TriggerState {
            internal StateCableDelay_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1009}, arg2: true);
                    context.State = new StateCableOff_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10 : TriggerState {
            internal StateCableDelay_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1010}, arg2: true);
                    context.State = new StateCableOff_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11 : TriggerState {
            internal StateCableDelay_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1011}, arg2: true);
                    context.State = new StateCableOff_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12 : TriggerState {
            internal StateCableDelay_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1012}, arg2: true);
                    context.State = new StateCableOff_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_07 : TriggerState {
            internal StateCableOff_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 2);
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_08 : TriggerState {
            internal StateCableOff_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 1);
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_09 : TriggerState {
            internal StateCableOff_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 2);
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_10 : TriggerState {
            internal StateCableOff_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 3);
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_11 : TriggerState {
            internal StateCableOff_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 1);
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_12 : TriggerState {
            internal StateCableOff_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 4);
                    context.State = new StateEnd_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_02 : TriggerState {
            internal StateEnd_02(ITriggerContext context) : base(context) { }

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