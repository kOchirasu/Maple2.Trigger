using System;
using System.Numerics;

namespace Maple2.Trigger._99999845 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000301}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000302}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000303}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000304}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000305}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000306}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000307}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000308}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000309}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000310}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000311}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000312}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000313}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000314}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000315}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000316}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000317}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000318}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000319}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000320}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000321}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000322}, arg2: 2);
                context.SetMesh(arg1: new int[] {1001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {1006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010}, arg2: false);
                context.SetVisibleBreakableObject(
                    arg1: new int[] {1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {1021, 1022}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "900")) {
                    context.State = new StateLineStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLineStart : TriggerState {
            internal StateLineStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010},
                    arg2: false);
                context.CreateMonster(arg1: new int[] {1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1101, 1103})) {
                    context.SetMesh(arg1: new int[] {1001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {1002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {1003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {1004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {1005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {1006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {2008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(arg1: new int[] {3006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetVisibleBreakableObject(arg1: new int[] {1001, 1002, 1003}, arg2: true);
                    context.SetInteractObject(arg1: new int[] {12000301}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000302}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000303}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1106}, arg2: false);
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
                if (context.ObjectInteracted(arg1: new int[] {12000302}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000301}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000302}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000303}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-15571.11f, 75.2856445f, 3600f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_01_1(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000303}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000301}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000302}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000303}, arg2: 2);
                    context.MoveUserToPos(pos: new Vector3(-15571.11f, -1561.813f, 3600f),
                        rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateCableDelay_01_2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000301}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000301}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000302}, arg2: 2);
                    context.SetInteractObject(arg1: new int[] {12000303}, arg2: 2);
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
                    context.SetBreakable(arg1: new int[] {1002}, arg2: true);
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
                    context.SetBreakable(arg1: new int[] {1003}, arg2: true);
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
                    context.SetBreakable(arg1: new int[] {1001}, arg2: true);
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
                    context.SetUserValue(triggerID: 900002, key: "Block", value: 1);
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
                    context.SetUserValue(triggerID: 900002, key: "Block", value: 2);
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
                    context.SetUserValue(triggerID: 900002, key: "Block", value: 3);
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