using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303, 12000304, 12000305, 12000306, 12000307, 12000308, 12000309, 12000310, 12000311, 12000312, 12000313, 12000314, 12000315, 12000316, 12000317, 12000318, 12000319, 12000320, 12000321, 12000322}, arg2: 2);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 3001, 3002, 3003, 3004, 3005, 3006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetVisibleBreakableObject(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {900})) {
                    context.State = new StateLineStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLineStart : TriggerState {
            internal StateLineStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1101, 1103})) {
                    context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 3001, 3002, 3003, 3004, 3005, 3006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetVisibleBreakableObject(arg1: new[] {1001, 1002, 1003}, arg2: true);
                    context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1104, 1105, 1106}, arg2: false);
                    context.State = new StateCableOn_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_01 : TriggerState {
            internal StateCableOn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000302}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-15571.11f, 75.2856445f, 3600f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_01_1(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000303}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-15571.11f, -1561.813f, 3600f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_01_2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000301}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-15571.11f, 1730.293f, 3600f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_01_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_01_1 : TriggerState {
            internal StateCableDelay_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1002}, arg2: true);
                    context.State = new StateCableOff_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_01_2 : TriggerState {
            internal StateCableDelay_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1003}, arg2: true);
                    context.State = new StateCableOff_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_01_3 : TriggerState {
            internal StateCableDelay_01_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1001}, arg2: true);
                    context.State = new StateCableOff_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_01 : TriggerState {
            internal StateCableOff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 1);
                    context.State = new StateEnd_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_02 : TriggerState {
            internal StateCableOff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 2);
                    context.State = new StateEnd_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_03 : TriggerState {
            internal StateCableOff_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 3);
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
                if (context.WaitTick(waitTick: 5000)) { }
            }

            public override void OnExit() { }
        }
    }
}